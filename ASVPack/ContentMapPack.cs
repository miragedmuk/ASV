
using ASVPack.Models;
using Newtonsoft.Json.Linq;

namespace ASVPack
{
    public class ContentMapPack
    {
        public List<ContentMap> SupportedMaps { get; set; } = new List<ContentMap>();

        public ContentMapPack()
        {
            SupportedMaps = new List<ContentMap>();
            LoadConfiguredMaps();
        }

        private void LoadConfiguredMaps()
        {
            string mapConfigFilename = Path.Combine(AppContext.BaseDirectory, @"maps.json");

            if (File.Exists(mapConfigFilename))
            {
                string fileContent = File.ReadAllText(mapConfigFilename);
                JObject mapContent = JObject.Parse(fileContent);
                foreach (var mapDef in mapContent["maps"])
                {
                    SupportedMaps.Add(new ContentMap()
                    {
                        MapName = mapDef["MapName"].Value<string>(),
                        Filename = mapDef["Filename"].Value<string>(),
                        ImageFile = mapDef["ImageFile"].Value<string>(),
                        LatShift = mapDef["LatShift"].Value<decimal>(),
                        LatDiv = mapDef["LatDiv"].Value<decimal>(),
                        LonShift = mapDef["LonShift"].Value<decimal>(),
                        LonDiv = mapDef["LonDiv"].Value<decimal>()
                    });
                }

            }

        }

        public ContentMap GetMap(string mapName)
        {
            ContentMap map = SupportedMaps.FirstOrDefault(m => m.Filename.ToLower() == mapName.ToLower());
            return map;
        }
    }
}
