using AsaSavegameToolkit.Types;
using System.IO.Compression;
using System.Reflection.PortableExecutable;


namespace AsaSavegameToolkit
{
    public class AsaDataStore
    {
        private enum ReadState
        {
            None,
            Escape,
            Switch
        }


        public int SaveVersion { get;internal set; } = 0;
        public int StoreSize { get; internal set; } = 0;
        public int NametableOffset { get; internal set; } = 0;

        public Dictionary<Guid, AsaGameObject> Objects { get; internal set; } = new Dictionary<Guid, AsaGameObject>();

        private List<AsaGameObject> gameObjects = new List<AsaGameObject>();

        public AsaDataStore(byte[] storeData) 
        {

            SaveVersion = BitConverter.ToInt16(storeData, 0)-1024;
            StoreSize = BitConverter.ToInt16(storeData, 4);                           
            NametableOffset = BitConverter.ToInt16(storeData, 8);

            byte[] dataBytes = storeData.AsSpan().Slice(12,storeData.Length-12).ToArray();

            var decompressedData = ZlibDecompress(dataBytes).AsSpan();
            

            dataBytes = new byte[0];
            byte[] rawBytes;

            rawBytes = AsaCompressedData.Inflate(decompressedData);

            decompressedData = new byte[0];

            using (var stream = new MemoryStream(rawBytes))
            {
                using (AsaArchive archive = new AsaArchive(stream))
                {
                    archive.Position = NametableOffset;
                    Dictionary<int, string> nameTable = new Dictionary<int, string>();
                    int nameTableCount = archive.ReadInt();
                    for (int nameIndex = 0; nameIndex < nameTableCount; nameIndex++)
                    {
                        nameTable.Add((nameIndex | 0x10000000), archive.ReadString());
                    }

                    //add constant names
                    Dictionary<int, string> constantNameTable = new Dictionary<int, string>();

                    constantNameTable.Add(0, "TribeName");
                    constantNameTable.Add(1, "StrProperty");
                    constantNameTable.Add(2, "bServerInitializedDino");
                    constantNameTable.Add(3, "BoolProperty");
                    constantNameTable.Add(5, "FloatProperty");
                    constantNameTable.Add(6, "ColorSetIndices");
                    constantNameTable.Add(7, "ByteProperty");
                    constantNameTable.Add(8, "None");
                    constantNameTable.Add(9, "ColorSetNames");
                    constantNameTable.Add(10, "NameProperty");
                    constantNameTable.Add(11, "TamingTeamID");
                    constantNameTable.Add(12, "UInt64Property"); //???
                    constantNameTable.Add(13, "RequiredTameAffinity");
                    constantNameTable.Add(14, "TamingTeamID");
                    constantNameTable.Add(15, "IntProperty");
                    constantNameTable.Add(19, "StructProperty");
                    constantNameTable.Add(23, "DinoID1");
                    constantNameTable.Add(24, "UInt32Property");
                    constantNameTable.Add(25, "DinoID2");
                    constantNameTable.Add(31, "UploadedFromServerName");
                    constantNameTable.Add(32, "TamedOnServerName");
                    constantNameTable.Add(36, "TargetingTeam");
                    constantNameTable.Add(38, "bReplicateGlobalStatusValues");
                    constantNameTable.Add(39, "bAllowLevelUps");
                    constantNameTable.Add(40, "bServerFirstInitialized");
                    constantNameTable.Add(41, "ExperiencePoints");
                    constantNameTable.Add(42, "CurrentStatusValues");
                    constantNameTable.Add(44, "ArrayProperty");
                    constantNameTable.Add(55, "bIsFemale");




                    archive.NameTable = nameTable;
                    archive.ConstantNameTable = constantNameTable;

                    archive.Position = 0;
                    var objectCount = archive.ReadInt();
                    for (int x = 0; x < objectCount; x++)
                    {
                        AsaGameObject gameObject = new AsaGameObject(archive);

                        gameObjects.Add(gameObject);
                    }

                    foreach (var gameObject in gameObjects)
                    {
                        gameObject.ReadProperties(archive);

                    }
                }
            }
            rawBytes = new byte[0];

            
            foreach(var gameObject in gameObjects)
            {
                gameObject.Guid = Guid.NewGuid();                  
            }

            //add reference to new statuscomponent id
            if(gameObjects.Count > 1)
            {
                var statusObject = gameObjects.First(o => o.ClassString.Contains("CharacterStatus")) ?? gameObjects[1];

                if (statusObject != null)
                {
                    gameObjects[0].Properties.Add(new Propertys.AsaProperty<dynamic>("MyCharacterStatusComponent", "ObjectProperty", 0, 0, new AsaObjectReference(statusObject.Guid)));
                    gameObjects[0].Properties.Add(new Propertys.AsaProperty<dynamic>("IsInCryo", "BoolProperty", 0, 0, true));


                    foreach (var gameObject in gameObjects)
                    {
                        Objects.Add(gameObject.Guid, gameObject);
                    }
                    gameObjects.Clear();

                }

            }

        }
        private byte[] ZlibDecompress(byte[] compressed)
        {

            using var inputStream = new MemoryStream(compressed);
            using (var brotliStream = new ZLibStream(inputStream, System.IO.Compression.CompressionMode.Decompress, leaveOpen: false))
            {
                const int bufferSize = 4096;
                using (var ms = new MemoryStream())
                {
                    byte[] buffer = new byte[bufferSize];
                    int count;
                    while ((count = brotliStream.Read(buffer, 0, buffer.Length)) != 0)
                        ms.Write(buffer, 0, count);
                    return ms.ToArray();
                }

            }
        }

    }
}
