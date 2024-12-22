using AsaSavegameToolkit.Propertys;

namespace AsaSavegameToolkit
{
    public class AsaProfile
    {
        public List<AsaObject> Objects { get; private set; } = new List<AsaObject>();
        public List<AsaProperty<dynamic>> Properties => Profile?.Properties ?? new List<AsaProperty<dynamic>>();
        public AsaObject? Profile
        {
            get
            {
                return Objects.FirstOrDefault(o => o.ClassName.EndsWith("PrimalPlayerDataBP_C"));
            }
        }


        public void Read(AsaArchive archive)
        {
            var profileVersion = archive.ReadInt();
            var profilesCount = archive.ReadInt();
            if (profilesCount == 0)
            {
                return;
            }

            Objects.Clear();

            while (profilesCount-- > 0)
            {
                var aObject = new AsaObject(archive);
                Objects.Add(aObject);
            }

            foreach (var aObject in Objects)
            {
                aObject.ReadProperties(archive,false);
            }

        }

        public void Read(string filename)
        {
            using (var ms = new MemoryStream(File.ReadAllBytes(filename)))
            {
                using (AsaArchive archive = new AsaArchive(ms))
                {
                    var profileVersion = archive.ReadInt();
                    var profilesCount = archive.ReadInt();
                    if (profilesCount == 0)
                    {
                        return;
                    }

                    Objects.Clear();

                    while (profilesCount-- > 0)
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
