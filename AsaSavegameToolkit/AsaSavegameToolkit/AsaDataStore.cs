using AsaSavegameToolkit.Extensions;
using AsaSavegameToolkit.Types;
using Ionic.Zlib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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

            byte[] dataBytes = new byte[storeData.Length-12];
            for (int x = 12; x < storeData.Length; x++)
            {
                dataBytes[x-12] = storeData[x];
            }

            var decompressedData = ZlibDecompress(dataBytes);
            dataBytes = new byte[0];
            byte[] rawBytes;

            using (var compressedStream = new MemoryStream(decompressedData)) 
            {
                var compressedData = new AsaCompressedData(compressedStream);
                rawBytes = compressedData.Inflate();
                //var testBytes = compressedData.InflateTest();
            }
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
            int outputSize = 2048;
            byte[] output = new Byte[outputSize];

            // If you have a ZLIB stream, set this to true.  If you have
            // a bare DEFLATE stream, set this to false.
            bool expectRfc1950Header = true;

            using (MemoryStream ms = new MemoryStream())
            {
                ZlibCodec compressor = new ZlibCodec();
                compressor.InitializeInflate(expectRfc1950Header);

                compressor.InputBuffer = compressed;
                compressor.AvailableBytesIn = compressed.Length;
                compressor.NextIn = 0;
                compressor.OutputBuffer = output;

                foreach (var f in new FlushType[] { FlushType.None, FlushType.Finish })
                {
                    int bytesToWrite = 0;
                    do
                    {
                        compressor.AvailableBytesOut = outputSize;
                        compressor.NextOut = 0;
                        compressor.Inflate(f);

                        bytesToWrite = outputSize - compressor.AvailableBytesOut;
                        if (bytesToWrite > 0)
                            ms.Write(output, 0, bytesToWrite);
                    }
                    while ((f == FlushType.None && (compressor.AvailableBytesIn != 0 || compressor.AvailableBytesOut == 0)) ||
                           (f == FlushType.Finish && bytesToWrite != 0));
                }

                compressor.EndInflate();

                return ms.ToArray();
            }
        }


    }
}
