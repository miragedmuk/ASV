
using ASVPack.Models;
using Newtonsoft.Json.Linq;
using System.Transactions;

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
                if (mapContent!=null)
                {
                    var localMaps = mapContent["maps"];

                    if (localMaps != null)
                    {
                        foreach (var mapDef in localMaps)
                        {
                            var newMap = new ContentMap()
                            {
                                MapName = mapDef["MapName"]?.Value<string>()??"",
                                Filename = mapDef["Filename"]?.Value<string>()??"",
                                ImageFile = mapDef["ImageFile"]?.Value<string>()??"",
                                LatShift = mapDef["LatShift"]?.Value<decimal>()??0,
                                LatDiv = mapDef["LatDiv"]?.Value<decimal>()??0,
                                LonShift = mapDef["LonShift"]?.Value<decimal>()??0,
                                LonDiv = mapDef["LonDiv"]?.Value<decimal>()??0
                            };

                            var mapRegions = mapDef["Regions"];

                            if (mapRegions!=null)
                            {
                                foreach (var mapRegion in mapRegions)
                                {
                                    //RegionName, ImageFile, LatStart, LatEnd, LonStart, LonEnd, ZStart, ZEnd
                                    var newRegion = new ContentMapRegion()
                                    {
                                        RegionName = mapRegion["RegionName"]?.Value<string>()??"",
                                        ImageFile = mapRegion["ImageFile"]?.Value<string>()??"",
                                        ZStart = mapRegion["ZStart"]?.Value<float>()??0,
                                        ZEnd = mapRegion["ZEnd"]?.Value<float>()??0,
                                        LatitudeStart = mapRegion["LatStart"]?.Value<float>()??0,
                                        LatitudeEnd = mapRegion["LatEnd"]?.Value<float>()??0,
                                        LongitudeStart = mapRegion["LonStart"]?.Value<float>()??0,
                                        LongitudeEnd = mapRegion["LonEnd"]?.Value<float>()??0,
                                        MarkerColor = mapRegion["MarkerColor"]?.Value<string>()??""
                                    };

                                    newMap.Regions.Add(newRegion);
                                }
                            }


                            SupportedMaps.Add(newMap);
                        }
                    }
                    

                }
                

            }

        }

        public ContentMap? GetMap(string mapFilename)
        {
            ContentMap? map = SupportedMaps.FirstOrDefault(m => m.Filename.ToLower() == mapFilename.ToLower());
            return map;
        }
    }
}
