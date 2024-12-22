using AsaSavegameToolkit.Propertys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsaSavegameToolkit
{
    public class AsaTribe
    {
        public DateTime TribeFileTimestamp { get; set; } = DateTime.MinValue;
        public List<AsaObject> Objects { get; private set; } = new List<AsaObject>();
        public List<AsaProperty<dynamic>> Properties => Tribe?.Properties ?? new List<AsaProperty<dynamic>>();
        public AsaObject? Tribe
        {
            get
            {
                return Objects.FirstOrDefault(o => o.ClassName.EndsWith("PrimalTribeData"));
            }
        }

        public void Read(AsaArchive archive, bool usePropertiesOffset = true)
        {
            var tribeVersion = archive.ReadInt();
            var tribeCount = archive.ReadInt();

            Objects.Clear();

            while (tribeCount-- > 0)
            {
                var aObject = new AsaObject(archive);
                Objects.Add(aObject);
            }

            foreach (var aObject in Objects)
            {
                aObject.ReadProperties(archive,usePropertiesOffset);
            }

        }

        public void Read(string filename, Dictionary<int, string> nameTable)
        {
            TribeFileTimestamp = File.GetLastWriteTimeUtc(filename);

            using (var ms = new MemoryStream(File.ReadAllBytes(filename)))
            {
                using (AsaArchive archive = new AsaArchive(ms))
                {
                    archive.NameTable = nameTable;
                    var tribeVersion = archive.ReadInt();
                    var tribeCount = archive.ReadInt();

                    Objects.Clear();

                    while (tribeCount-- > 0)
                    {
                        var aObject = new AsaObject(archive);
                        Objects.Add(aObject);
                    }

                    foreach (var aObject in Objects)
                    {
                        aObject.ReadProperties(archive);
                    }
                  
                }
                
                ms.Close();                
            }
        }

    }
}
