using AsaSavegameToolkit.Extensions;
using AsaSavegameToolkit.Propertys;
using AsaSavegameToolkit.Structs;
using AsaSavegameToolkit.Types;

namespace AsaSavegameToolkit
{
    public class AsaGameObject
    {


        public Guid Guid { get; set; } = Guid.Empty;
        public string Blueprint { get; private set; } = string.Empty;
        public AsaName ClassName { get; private set; } = AsaName.NameNone;
        public string ClassString
        {
            get
            {
                return ClassName?.ToString() ?? "";
            }
        }
        public bool IsItem { get; private set; } = false;

        public readonly List<AsaName> Names = new List<AsaName>();
        public AsaLocation? Location { get; set; } = null;
        public List<AsaProperty<dynamic>> Properties { get; private set; } = new List<AsaProperty<dynamic>>();
        public readonly Dictionary<AsaName, AsaGameObject> Components = new Dictionary<AsaName, AsaGameObject>();
        public IEnumerable<AsaName> ParentNames => Names.Skip(1).ToList();
        public int DataFileIndex { get; private set; } = 0;
        public long PropertyOffset { get;private set; } = 0;
        

        public AsaGameObject(AsaArchive archive)
        {
            Guid = GuidExtensions.ToGuid(archive.ReadBytes(16));

            var bluePrintPath = archive.ReadString();

            ClassName = AsaName.From(bluePrintPath.Substring(bluePrintPath.LastIndexOf(".")+1));

            var shouldBeZero = archive.ReadInt();

            int nameCount = archive.ReadInt();
            Names.Clear();
            while (nameCount-- > 0)
            {
                Names.Add(AsaName.From(archive.ReadString()));
            }
            bool fromDataFile = archive.ReadBool();
            DataFileIndex = archive.ReadInt();
            
            var hasLocation = archive.ReadBool();
            if (hasLocation)
            {
                AsaRotator rotator = new AsaRotator(archive);
            }
            PropertyOffset = archive.ReadInt();
            var anotherZero = archive.ReadInt();

            //readProperties(archive);           
        }


        private dynamic? GetPropertyValue<T>(string name, int index = 0, dynamic? defaultValue = null)
        {
            foreach (var prop in Properties)
            {
                if (prop.Position == index && prop.Name == name)
                {
                    return prop.Value;
                }
            }

            return defaultValue;
        }


        public AsaGameObject(Guid newId, List<AsaProperty<dynamic>> properties)
        {
            Guid = newId;
            Properties = properties;

            AsaObjectReference? classRef = GetPropertyValue<AsaObjectReference?>("ItemArchetype", 0, null);
            if (classRef != null)
            {
                var classString = classRef.Value.Substring(classRef.Value.LastIndexOf('.') + 1);

                ClassName = AsaName.From(classString);
            }

            AsaProperty<dynamic>? itemQty = properties.FirstOrDefault(p => p.Name == "ItemQuantity");
            if (itemQty != null && itemQty.Value == 0)
            {
                properties.Remove(itemQty);
                properties.Add(new AsaProperty<dynamic>("ItemQuantity", "UInt32Property", 0, 0, 1));
            }


            IsItem = true;
        }


        public AsaGameObject(List<AsaProperty<dynamic>> properties)
        {
            Guid = Guid.NewGuid();
            Properties = properties;

            AsaObjectReference? classRef = GetPropertyValue<AsaObjectReference?>("ItemArchetype", 0, null);
            if (classRef != null)
            {
                var classString = classRef.Value.Substring(classRef.Value.LastIndexOf('.')+1);

                ClassName = AsaName.From(classString);
            }

            AsaProperty<dynamic>? itemQty = properties.FirstOrDefault(p => p.Name == "ItemQuantity");
            if (itemQty != null && itemQty.Value ==0)
            {
                properties.Remove(itemQty);
                properties.Add(new AsaProperty<dynamic>("ItemQuantity", "UInt32Property", 0, 0, 1));
            }


            IsItem = true;
        }

        public AsaGameObject(Guid objectId, AsaArchive archive)
        {
            Guid = objectId;
            ClassName = archive.ReadName();
            IsItem = archive.ReadBool();//? not isitem - always false?

            int nameCount = archive.ReadInt();           
            Names.Clear();
            while (nameCount-- > 0)
            {
                if(archive.SaveVersion < 13)
                {
                    Names.Add(archive.ReadName());
                }

                if (archive.SaveVersion >= 13)
                {
                    Names.Add(AsaName.From(archive.ReadString()));
                }

            }

            
           
            DataFileIndex = archive.ReadInt();
            archive.SkipBytes(1);

            PropertyOffset = archive.Position;

            //readproperties
            ReadProperties(archive);
        }

        public void AddComponent(AsaGameObject component)
        {
            Components.Add(component.Names[0], component);
        }

        public void ReadProperties(AsaArchive archive)
        {
            archive.Position = PropertyOffset;



            long lastPropertyPosition = archive.Position;
            if (archive.Position == archive.Limit)
            { 
                //No properties to read
                return; 
            }

            try
            {


                var property = AsaPropertyRegistry.ReadProperty(archive);
                while (property != null && archive.Position < archive.Limit)
                {


                    lastPropertyPosition = archive.Position;
                    Properties.Add(property);
                    property = AsaPropertyRegistry.ReadProperty(archive);

                }
            }
            catch (Exception ex)
            {

            }


        }

        public override string ToString()
        {
            return ClassString;
        }
    }
}
