using AsaSavegameToolkit.Extensions;
using AsaSavegameToolkit.Propertys;
using AsaSavegameToolkit.Structs;

namespace AsaSavegameToolkit
{
    public class AsaObject
    {
        public Guid Uuid { get; private set; } = Guid.Empty;
        public string ClassName { get; private set; } = string.Empty;
        public bool IsItem { get; private set; } = false;
        public List<string> Names { get; private set; } = new List<string>();
        public AsaLocation? Location { get; private set; }

        public List<AsaProperty<dynamic>> Properties { get; private set; } = new List<AsaProperty<dynamic>>();

        private int propertiesOffset = 0;


        public AsaObject(AsaArchive archive)
        {
            Uuid = GuidExtensions.ToGuid(archive.ReadBytes(16));
            ClassName = archive.ReadString();
            IsItem = archive.ReadBool();

            var nameCount = archive.ReadInt();
            while (nameCount-- > 0)
            {
                var name = archive.ReadString();
                Names.Add(name);
            }

            var fromDataFile = archive.ReadBool();
            var dataFileIndex = archive.ReadInt();
            var hasLocation = archive.ReadBool();
            if (hasLocation)
            {
                AsaVector vector = new AsaVector(archive);
                AsaRotator rotator = new AsaRotator(archive);

                Location = new AsaLocation(vector.X, vector.Y, vector.X, rotator.Pitch, rotator.Yaw, rotator.Roll);
            }
            propertiesOffset = archive.ReadInt();
            var shouldBeZero = archive.ReadInt();
        }

        public AsaObject(AsaArchive archive, int propertyOffset)
        {
            Uuid = GuidExtensions.ToGuid(archive.ReadBytes(16));
            ClassName = archive.ReadString();
            IsItem = archive.ReadBool();

            var nameCount = archive.ReadInt();
            while (nameCount-- > 0)
            {
                var name = archive.ReadString();
                Names.Add(name);
            }

            var fromDataFile = archive.ReadBool();
            var dataFileIndex = archive.ReadInt();
            var hasLocation = archive.ReadBool();
            if (hasLocation)
            {
                AsaVector vector = new AsaVector(archive);
                AsaRotator rotator = new AsaRotator(archive);

                Location = new AsaLocation(vector.X, vector.Y, vector.X, rotator.Pitch, rotator.Yaw, rotator.Roll);
            }
            propertiesOffset = archive.ReadInt();
            var shouldBeZero = archive.ReadInt();
        }
        
        public void ReadProperties(AsaArchive archive)
        {
            ReadProperties(archive,true);
        }

        public void ReadProperties(AsaArchive archive, bool usePropertiesOffset)
        {
            Properties.Clear();

            if (usePropertiesOffset)
            {
                archive.Position = propertiesOffset;
            }          

            try
            {
                var property = AsaPropertyRegistry.ReadProperty(archive);
                while (property != null)
                {
                    Properties.Add(property);
                    property = AsaPropertyRegistry.ReadProperty(archive);
                }

            }
            catch
            {

            }
        }


    }
}
