using AsaSavegameToolkit.Propertys;
using AsaSavegameToolkit.Structs;
using AsaSavegameToolkit.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsaSavegameToolkit
{
    public class AsaGameObject
    {


        public Guid Guid { get; private set; } = Guid.Empty;
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



        public AsaGameObject(Guid objectId, AsaArchive archive)
        {
            Guid = objectId;

            ClassName = archive.ReadName();


            IsItem = archive.ReadBool();

            int nameCount = archive.ReadInt();
            Names.Clear();
            while (nameCount-- > 0)
            {
                Names.Add(archive.ReadName());
            }

            var shouldBeZero = archive.ReadInt();
            if (shouldBeZero != 0)
            {
                return;
            }

            archive.SkipBytes(1);

            //readproperties
            readProperties(archive);


        }

        public void AddComponent(AsaGameObject component)
        {
            Components.Add(component.Names[0], component);
        }

        private void readProperties(AsaArchive archive)
        {
            long lastPropertyPosition = archive.Position;


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
