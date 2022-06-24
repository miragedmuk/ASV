
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
                    var newMap = new ContentMap()
                    {
                        MapName = mapDef["MapName"].Value<string>(),
                        Filename = mapDef["Filename"].Value<string>(),
                        ImageFile = mapDef["ImageFile"].Value<string>(),
                        LatShift = mapDef["LatShift"].Value<decimal>(),
                        LatDiv = mapDef["LatDiv"].Value<decimal>(),
                        LonShift = mapDef["LonShift"].Value<decimal>(),
                        LonDiv = mapDef["LonDiv"].Value<decimal>()
                    };

                    if (mapDef["Regions"] != null)
                    {
                        foreach(var mapRegion in mapDef["Regions"])
                        {
                            //RegionName, ImageFile, LatStart, LatEnd, LonStart, LonEnd, ZStart, ZEnd
                            var newRegion = new ContentMapRegion()
                            {
                                RegionName = mapRegion["RegionName"].Value<string>(),
                                ImageFile = mapRegion["ImageFile"].Value<string>(),
                                ZStart = mapRegion["ZStart"].Value<float>(),
                                ZEnd = mapRegion["ZEnd"].Value<float>(),
                                LatitudeStart = mapRegion["LatStart"].Value<float>(),
                                LatitudeEnd = mapRegion["LatEnd"].Value<float>(),
                                LongitudeStart = mapRegion["LonStart"].Value<float>(),
                                LongitudeEnd= mapRegion["LonEnd"].Value<float>(),
                                MarkerColor = mapRegion["MarkerColor"].Value<string>()
                            };

                            newMap.Regions.Add(newRegion);                            
                        }
                    }


                    SupportedMaps.Add(newMap);
                }

            }

        }

        public ContentMap GetMap(string mapFilename)
        {
            ContentMap map = SupportedMaps.FirstOrDefault(m => m.Filename.ToLower() == mapFilename.ToLower());
            return map;
        }
    }
}
