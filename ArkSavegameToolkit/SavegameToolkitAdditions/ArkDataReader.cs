using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SavegameToolkitAdditions {

    public static class ArkDataReader {
        public static ArkData ReadFromFile(string filename) {
            using (StreamReader reader = File.OpenText(filename)) {
                return JsonSerializer.CreateDefault(new JsonSerializerSettings {
                                ContractResolver = new CamelCasePropertyNamesContractResolver()
                        })
                        .Deserialize<ArkData>(new JsonTextReader(reader));
            }
        }
    }

    public class ArkData {
        private Dictionary<string, ArkDataEntry> items;
        private Dictionary<string, ArkDataEntry> creatures;
        private Dictionary<string, ArkDataEntry> structures;

        public List<ArkDataEntry> Items { get; set; }
        public List<ArkDataEntry> Creatures { get; set; }
        public List<ArkDataEntry> Structures { get; set; }

        public ArkDataEntry GetItemForClass(string classString) {
            if (items == null) {
                items = Items?.ToDictionary(entry => entry.Class);
            }

            return items != null && items.TryGetValue(classString, out ArkDataEntry arkDataEntry) ? arkDataEntry : null;
        }

        public ArkDataEntry GetCreatureForClass(string classString) {
            if (creatures == null) {
                creatures = Creatures?.ToDictionary(entry => entry.Class);
            }

            return creatures != null && creatures.TryGetValue(classString, out ArkDataEntry arkDataEntry) ? arkDataEntry : null;
        }

        public ArkDataEntry GetStructureForClass(string classString) {
            if (structures == null) {
                structures = Structures?.ToDictionary(entry => entry.Class);
            }

            return structures != null && structures.TryGetValue(classString, out ArkDataEntry arkDataEntry) ? arkDataEntry : null;
        }
    }

    public class ArkDataEntry {
        public string Package { get; set; }
        public string Blueprint { get; set; }
        public string Class { get; set; }
        public string Name { get; set; }
    }

}
