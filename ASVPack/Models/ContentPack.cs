using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace ASVPack.Models
{
    [DataContract]
    public class ContentPack
    {


        [DataMember] public string MapFilename { get; set; } = "TheIsland.ark";
        [DataMember] public DateTime ContentDate { get; set; } = DateTime.Now;
        [DataMember] public long ExportedForTribe { get; set; } = 0;
        [DataMember] public long ExportedForPlayer { get; set; } = 0;
        [DataMember] public DateTime ExportedTimestamp { get; set; } = DateTime.Now;
        [DataMember] public List<ContentStructure> TerminalMarkers { get; set; } = new List<ContentStructure>();
        [DataMember] public List<ContentStructure> GlitchMarkers { get; set; } = new List<ContentStructure>();
        [DataMember] public List<ContentStructure> ChargeNodes { get; set; } = new List<ContentStructure>();
        [DataMember] public List<ContentStructure> BeaverDams { get; set; } = new List<ContentStructure>();
        [DataMember] public List<ContentStructure> WyvernNests { get; set; } = new List<ContentStructure>();
        [DataMember] public List<ContentStructure> DrakeNests { get; set; } = new List<ContentStructure>();
        [DataMember] public List<ContentStructure> MagmaNests { get; set; } = new List<ContentStructure>();
        [DataMember] public List<ContentStructure> DeinoNests { get; set; } = new List<ContentStructure>();
        [DataMember] public List<ContentStructure> OilVeins { get; set; } = new List<ContentStructure>();
        [DataMember] public List<ContentStructure> WaterVeins { get; set; } = new List<ContentStructure>();
        [DataMember] public List<ContentStructure> GasVeins { get; set; } = new List<ContentStructure>();
        [DataMember] public List<ContentStructure> Artifacts { get; set; } = new List<ContentStructure>();
        [DataMember] public List<ContentStructure> BeeHives { get; set; } = new List<ContentStructure>();

        [DataMember] public List<ContentStructure> PlantZ { get; set; } = new List<ContentStructure>();
        [DataMember] public List<ContentDroppedItem> DroppedItems { get; set; } = new List<ContentDroppedItem>();
        [DataMember] public List<ContentWildCreature> WildCreatures { get; set; } = new List<ContentWildCreature>();
        [DataMember] public List<ContentTribe> Tribes { get; set; } = new List<ContentTribe>();
        [DataMember] public ContentLocalProfile LocalProfile { get; set; } = new ContentLocalProfile();
        [DataMember] public List<ContentLeaderboard> Leaderboards { get; set; } = new List<ContentLeaderboard>();

        public List<ContentStructure> OrphanedStructures { get; set; } = new List<ContentStructure>();
        public List<ContentTamedCreature> OrphanedTames { get; set; } = new List<ContentTamedCreature>();

        bool IncludeGameStructures { get; set; } = true;
        bool IncludeGameStructureContent { get; set; } = true;
        bool IncludeTribesPlayers { get; set; } = true;
        bool IncludeTamed { get; set; } = true;
        bool IncludeWild { get; set; } = true;
        bool IncludePlayerStructures { get; set; } = true;
        bool IncludeDroppedItems { get; set; } = true;
        decimal FilterLatitude { get; set; } = 50;
        decimal FilterLongitude { get; set; } = 50;
        decimal FilterRadius { get; set; } = 100;


        ConcurrentBag<ContentInventory> inventoryBag = new ConcurrentBag<ContentInventory>();

        public ContentPack()
        {
            //initialize defaults
            MapFilename = "TheIsland.ark";
            ExportedForTribe = 0;
            ExportedForPlayer = 0;
            FilterLatitude = 50;
            FilterLongitude = 50;
            FilterRadius = 100;

            TerminalMarkers = new List<ContentStructure>();
            GlitchMarkers = new List<ContentStructure>();
            ChargeNodes = new List<ContentStructure>();
            BeaverDams = new List<ContentStructure>();
            WyvernNests = new List<ContentStructure>();
            DrakeNests = new List<ContentStructure>();
            MagmaNests = new List<ContentStructure>();
            DeinoNests = new List<ContentStructure>();
            OilVeins = new List<ContentStructure>();
            WaterVeins = new List<ContentStructure>();
            GasVeins = new List<ContentStructure>();
            Artifacts = new List<ContentStructure>();
            BeeHives = new List<ContentStructure>();
            PlantZ = new List<ContentStructure>();
            WildCreatures = new List<ContentWildCreature>();
            Tribes = new List<ContentTribe>();
            DroppedItems = new List<ContentDroppedItem>();
        }

        public ContentPack(ContentPack sourcePack, long selectedTribeId, long selectedPlayerId, decimal lat, decimal lon, decimal rad, bool includeGameStructures, bool includeGameStructureContent, bool includeTribesPlayers, bool includeTamed, bool includeWild, bool includePlayerStructures, bool includeDropped) : this()
        {

            ExportedForTribe = selectedTribeId;
            ExportedForPlayer = selectedPlayerId;

            FilterLatitude = lat;
            FilterLongitude = lon;
            FilterRadius = rad;

            IncludeGameStructures = includeGameStructures;
            IncludeGameStructureContent = includeGameStructureContent;
            IncludeTribesPlayers = includeTribesPlayers;
            IncludeTamed = includeTamed;
            IncludeWild = includeWild;
            IncludePlayerStructures = includePlayerStructures;

            LoadPackData(sourcePack);

        }


        public ContentPack(ContentContainer container, long selectedTribeId, long selectedPlayerId, decimal lat, decimal lon, decimal rad, bool includeGameStructures, bool includeGameStructureContent, bool includeTribesPlayers, bool includeTamed, bool includeWild, bool includePlayerStructures, bool includeDropped) : this()
        {
            ExportedForTribe = selectedTribeId;
            ExportedForPlayer = selectedPlayerId;

            FilterLatitude = lat;
            FilterLongitude = lon;
            FilterRadius = rad;

            IncludeGameStructures = includeGameStructures;
            IncludeGameStructureContent = includeGameStructureContent;
            IncludeTribesPlayers = includeTribesPlayers;
            IncludeTamed = includeTamed;
            IncludeWild = includeWild;
            IncludePlayerStructures = includePlayerStructures;
            LocalProfile = container.LocalProfile;
            Leaderboards = container.Leaderboards;

            LoadGameData(container);

        }

        public ContentPack(byte[] dataPack) : this()
        {
            string jsonContent = Unzip(dataPack);
            LoadJson(jsonContent);
        }

        public void LoadJson(string jsonPack)
        {
            //load content from json
            try
            { 
                ContentPack? loaded = null;
                loaded = JsonConvert.DeserializeObject<ContentPack>(jsonPack);
                
                if(loaded != null)
                {
                    MapFilename = loaded.MapFilename;
                    ExportedTimestamp = loaded.ExportedTimestamp;
                    ExportedForTribe = loaded.ExportedForTribe;
                    ExportedForPlayer = loaded.ExportedForPlayer;
                    TerminalMarkers = loaded.TerminalMarkers;
                    GlitchMarkers = loaded.GlitchMarkers;
                    ChargeNodes = loaded.ChargeNodes;
                    BeaverDams = loaded.BeaverDams;
                    WyvernNests = loaded.WyvernNests;
                    DrakeNests = loaded.DrakeNests;
                    MagmaNests = loaded.MagmaNests;
                    OilVeins = loaded.OilVeins;
                    WaterVeins = loaded.WaterVeins;
                    GasVeins = loaded.GasVeins;
                    Artifacts = loaded.Artifacts;
                    BeeHives = loaded.BeeHives;
                    PlantZ = loaded.PlantZ;
                    WildCreatures = loaded.WildCreatures;
                    Tribes = loaded.Tribes;
                    DroppedItems = loaded.DroppedItems;
                    LocalProfile = loaded.LocalProfile;

                }

            }
            catch
            {

            }

        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }







        public void ExportJsonAll(string exportPath)
        {
            if (!Directory.Exists(exportPath)) Directory.CreateDirectory(exportPath);
            Task.WaitAll(
                Task.Run(() => ExportJsonWild(Path.Combine(exportPath, "ASV_Wild.json"))),
                Task.Run(() => ExportJsonPlayerTribes(Path.Combine(exportPath, "ASV_Tribes.json"))),
                Task.Run(() => ExportJsonPlayerTribeLogs(Path.Combine(exportPath, "ASV_TribeLogs.json"))),
                Task.Run(() => ExportJsonTamed(Path.Combine(exportPath, "ASV_Tamed.json"))),
                Task.Run(() => ExportJsonPlayers(Path.Combine(exportPath, "ASV_Players.json"))),
                Task.Run(() => ExportJsonPlayerStructures(Path.Combine(exportPath, "ASV_Structures.json"))),
                Task.Run(() => ExportJsonMapStructures(Path.Combine(exportPath, "ASV_MapStructures.json")))
                )
            ;
        }

        public void ExportJsonWild(string exportFilename)
        {

            string exportFolder = Path.GetDirectoryName(exportFilename);
            if (!Directory.Exists(exportFolder)) Directory.CreateDirectory(exportFolder);

            using (FileStream fs = File.Create(exportFilename))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    using (JsonTextWriter jw = new JsonTextWriter(sw))
                    {
                        //var creatureList = Program.ProgramConfig.SortCommandLineExport ? gd.WildCreatures.OrderBy(o => o.ClassName).Cast<ArkWildCreature>() : gd.WildCreatures;
                        var creatureList = WildCreatures.OrderBy(o => o.ClassName).ToList();
                        jw.WriteStartArray();

                        //Creature, Sex, Lvl, Lat, Lon, HP, Stam, Weight, Speed, Food, Oxygen, Craft, C0, C1, C2, C3, C4, C5              
                        foreach (var creature in creatureList)
                        {
                            jw.WriteStartObject();

                            jw.WritePropertyName("id");
                            jw.WriteValue(creature.Id);

                            jw.WritePropertyName("creature");
                            jw.WriteValue(creature.ClassName);

                            jw.WritePropertyName("sex");
                            jw.WriteValue(creature.Gender);

                            jw.WritePropertyName("lvl");
                            jw.WriteValue(creature.BaseLevel);

                            jw.WritePropertyName("lat");
                            jw.WriteValue(creature.Latitude.GetValueOrDefault(0));

                            jw.WritePropertyName("lon");
                            jw.WriteValue(creature.Longitude.GetValueOrDefault(0));

                            jw.WritePropertyName("hp");
                            jw.WriteValue(creature.BaseStats[0]);

                            jw.WritePropertyName("stam");
                            jw.WriteValue(creature.BaseStats[1]);

                            jw.WritePropertyName("melee");
                            jw.WriteValue(creature.BaseStats[8]);

                            jw.WritePropertyName("weight");
                            jw.WriteValue(creature.BaseStats[7]);

                            jw.WritePropertyName("speed");
                            jw.WriteValue(creature.BaseStats[9]);

                            jw.WritePropertyName("food");
                            jw.WriteValue(creature.BaseStats[4]);

                            jw.WritePropertyName("oxy");
                            jw.WriteValue(creature.BaseStats[3]);

                            jw.WritePropertyName("craft");
                            jw.WriteValue(creature.BaseStats[11]);

                            jw.WritePropertyName("c0");
                            jw.WriteValue(creature.Colors[0]);

                            jw.WritePropertyName("c1");
                            jw.WriteValue(creature.Colors[1]);

                            jw.WritePropertyName("c2");
                            jw.WriteValue(creature.Colors[2]);

                            jw.WritePropertyName("c3");
                            jw.WriteValue(creature.Colors[3]);

                            jw.WritePropertyName("c4");
                            jw.WriteValue(creature.Colors[4]);

                            jw.WritePropertyName("c5");
                            jw.WriteValue(creature.Colors[5]);

                            jw.WritePropertyName("ccc");
                            jw.WriteValue($"{creature.X} {creature.Y} {creature.Z}");

                            jw.WritePropertyName("dinoid");
                            jw.WriteValue(creature.DinoId);

                            jw.WritePropertyName("tameable");
                            jw.WriteValue(creature.IsTameable);


                            jw.WriteEnd();
                        }

                        jw.WriteEndArray();
                    }

                }

            }
        }

        public void ExportJsonTamed(string exportFilename)
        {
            if (exportFilename == null) return;

            string exportFolder = Path.GetDirectoryName(exportFilename) ?? "";
            if (!Directory.Exists(exportFolder)) Directory.CreateDirectory(exportFolder);


            using (FileStream fs = File.Create(exportFilename))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    using (JsonTextWriter jw = new JsonTextWriter(sw))
                    {
                        var allTames = Tribes.SelectMany(t => t.Tames).ToList();

                        //var creatureList = shouldSort ? gd.TamedCreatures.OrderBy(o => o.ClassName).Cast<ArkTamedCreature>() : gd.TamedCreatures;
                        var creatureList = allTames.OrderBy(o => o.ClassName).ToList();
                        jw.WriteStartArray();

                        foreach (var creature in creatureList)
                        {

                            jw.WriteStartObject();
                            jw.WritePropertyName("id");
                            jw.WriteValue(creature.Id);

                            jw.WritePropertyName("tribeid");
                            jw.WriteValue(creature.TargetingTeam);

                            jw.WritePropertyName("tribe");
                            jw.WriteValue(creature.TribeName);

                            jw.WritePropertyName("tamer");
                            jw.WriteValue(creature.TamerName);

                            jw.WritePropertyName("imprinter");
                            jw.WriteValue(creature.ImprinterName);


                            jw.WritePropertyName("imprint");
                            jw.WriteValue(creature.ImprintQuality);

                            jw.WritePropertyName("creature");
                            jw.WriteValue(creature.ClassName);

                            jw.WritePropertyName("name");
                            jw.WriteValue(creature.Name != null ? creature.Name : "");


                            jw.WritePropertyName("sex");
                            jw.WriteValue(creature.Gender);

                            jw.WritePropertyName("base");
                            jw.WriteValue(creature.BaseLevel);


                            jw.WritePropertyName("lvl");
                            jw.WriteValue(creature.Level);

                            jw.WritePropertyName("lat");
                            jw.WriteValue(creature.Latitude.GetValueOrDefault(0));

                            jw.WritePropertyName("lon");
                            jw.WriteValue(creature.Longitude.GetValueOrDefault(0));

                            jw.WritePropertyName("hp-w");
                            jw.WriteValue(creature.BaseStats[0]);

                            jw.WritePropertyName("stam-w");
                            jw.WriteValue(creature.BaseStats[1]);

                            jw.WritePropertyName("melee-w");
                            jw.WriteValue(creature.BaseStats[8]);

                            jw.WritePropertyName("weight-w");
                            jw.WriteValue(creature.BaseStats[7]);

                            jw.WritePropertyName("speed-w");
                            jw.WriteValue(creature.BaseStats[9]);

                            jw.WritePropertyName("food-w");
                            jw.WriteValue(creature.BaseStats[4]);

                            jw.WritePropertyName("oxy-w");
                            jw.WriteValue(creature.BaseStats[3]);

                            jw.WritePropertyName("craft-w");
                            jw.WriteValue(creature.BaseStats[11]);

                            jw.WritePropertyName("hp-t");
                            jw.WriteValue(creature.TamedStats[0]);

                            jw.WritePropertyName("stam-t");
                            jw.WriteValue(creature.TamedStats[1]);

                            jw.WritePropertyName("melee-t");
                            jw.WriteValue(creature.TamedStats[8]);

                            jw.WritePropertyName("weight-t");
                            jw.WriteValue(creature.TamedStats[7]);

                            jw.WritePropertyName("speed-t");
                            jw.WriteValue(creature.TamedStats[9]);

                            jw.WritePropertyName("food-t");
                            jw.WriteValue(creature.TamedStats[4]);

                            jw.WritePropertyName("oxy-t");
                            jw.WriteValue(creature.TamedStats[3]);

                            jw.WritePropertyName("craft-t");
                            jw.WriteValue(creature.TamedStats[11]);


                            jw.WritePropertyName("c0");
                            jw.WriteValue(creature.Colors[0]);

                            jw.WritePropertyName("c1");
                            jw.WriteValue(creature.Colors[1]);

                            jw.WritePropertyName("c2");
                            jw.WriteValue(creature.Colors[2]);

                            jw.WritePropertyName("c3");
                            jw.WriteValue(creature.Colors[3]);

                            jw.WritePropertyName("c4");
                            jw.WriteValue(creature.Colors[4]);

                            jw.WritePropertyName("c5");
                            jw.WriteValue(creature.Colors[5]);

                            jw.WritePropertyName("mut-f");
                            jw.WriteValue(creature.RandomMutationsFemale);

                            jw.WritePropertyName("mut-m");
                            jw.WriteValue(creature.RandomMutationsMale);

                            jw.WritePropertyName("cryo");
                            jw.WriteValue(creature.IsCryo || creature.IsVivarium);

                            jw.WritePropertyName("ccc");
                            jw.WriteValue($"{creature.X} {creature.Y} {creature.Z}");

                            jw.WritePropertyName("dinoid");
                            jw.WriteValue(creature.DinoId);

                            jw.WritePropertyName("isMating");
                            jw.WriteValue(creature.IsMating);

                            if(creature.UploadedTimeInGame != 0)
                            {
                                jw.WritePropertyName("uploadedTime");
                                jw.WriteValue(creature.UploadedTime);
                            }

                            bool exportInventories = true;

                            if (exportInventories)
                            {
                                jw.WritePropertyName("inventory");
                                jw.WriteStartArray();
                                if (creature.Inventory.Items.Count > 0)
                                {
                                    foreach (var invItem in creature.Inventory.Items)
                                    {
                                        if (!invItem.IsEngram)
                                        {
                                            jw.WriteStartObject();

                                            jw.WritePropertyName("itemId");
                                            jw.WriteValue(invItem.ClassName);

                                            jw.WritePropertyName("qty");
                                            jw.WriteValue(invItem.Quantity);


                                            jw.WritePropertyName("blueprint");
                                            jw.WriteValue(invItem.IsBlueprint);

                                            jw.WriteEndObject();
                                        }

                                    }
                                }



                                jw.WriteEndArray();
                            }

                            jw.WriteEnd();
                        }

                        jw.WriteEndArray();
                    }

                }

            }
        }

        public void ExportJsonMapStructures(string exportFilename)
        {
            string exportFolder = Path.GetDirectoryName(exportFilename);
            if (!Directory.Exists(exportFolder)) Directory.CreateDirectory(exportFolder);


            using (FileStream fs = File.Create(exportFilename))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    using (JsonTextWriter jw = new JsonTextWriter(sw))
                    {
                        jw.WriteStartArray();

                        foreach (var mapStructure in TerminalMarkers)
                        {
       
                            jw.WriteStartObject();

                            

                            jw.WritePropertyName("struct");
                            jw.WriteValue(mapStructure.ClassName);

                            jw.WritePropertyName("lat");
                            jw.WriteValue(mapStructure.Latitude.GetValueOrDefault(0));

                            jw.WritePropertyName("lon");
                            jw.WriteValue(mapStructure.Longitude.GetValueOrDefault(0));

                            jw.WritePropertyName("ccc");
                            jw.WriteValue($"{mapStructure.X} {mapStructure.Y} {mapStructure.Z}");


                            bool exportInventories = true;

                            if (exportInventories)
                            {
                                jw.WritePropertyName("inventory");
                                jw.WriteStartArray();
                                if (mapStructure.Inventory.Items.Count > 0)
                                {
                                    foreach (var invItem in mapStructure.Inventory.Items)
                                    {
                                        if (!invItem.IsEngram)
                                        {
                                            jw.WriteStartObject();

                                            jw.WritePropertyName("itemId");
                                            jw.WriteValue(invItem.ClassName);

                                            jw.WritePropertyName("qty");
                                            jw.WriteValue(invItem.Quantity);

                                            jw.WritePropertyName("blueprint");
                                            jw.WriteValue(invItem.IsBlueprint);


                                            jw.WriteEndObject();
                                        }

                                    }
                                }

                                jw.WriteEndArray();
                            }

                            jw.WriteEndObject();
                            
                        }

                        foreach (var mapStructure in OilVeins)
                        {

                            jw.WriteStartObject();


                            jw.WritePropertyName("struct");
                            jw.WriteValue(mapStructure.ClassName);

                            jw.WritePropertyName("lat");
                            jw.WriteValue(mapStructure.Latitude.GetValueOrDefault(0));

                            jw.WritePropertyName("lon");
                            jw.WriteValue(mapStructure.Longitude.GetValueOrDefault(0));

                            jw.WritePropertyName("ccc");
                            jw.WriteValue($"{mapStructure.X} {mapStructure.Y} {mapStructure.Z}");


                            bool exportInventories = true;

                            if (exportInventories)
                            {
                                jw.WritePropertyName("inventory");
                                jw.WriteStartArray();
                                if (mapStructure.Inventory.Items.Count > 0)
                                {
                                    foreach (var invItem in mapStructure.Inventory.Items)
                                    {
                                        if (!invItem.IsEngram)
                                        {
                                            jw.WriteStartObject();

                                            jw.WritePropertyName("itemId");
                                            jw.WriteValue(invItem.ClassName);

                                            jw.WritePropertyName("qty");
                                            jw.WriteValue(invItem.Quantity);

                                            jw.WritePropertyName("blueprint");
                                            jw.WriteValue(invItem.IsBlueprint);


                                            jw.WriteEndObject();
                                        }

                                    }
                                }

                                jw.WriteEndArray();
                            }

                            jw.WriteEndObject();

                        }

                        foreach (var mapStructure in GasVeins)
                        {

                            jw.WriteStartObject();


                            jw.WritePropertyName("struct");
                            jw.WriteValue(mapStructure.ClassName);

                            jw.WritePropertyName("lat");
                            jw.WriteValue(mapStructure.Latitude.GetValueOrDefault(0));

                            jw.WritePropertyName("lon");
                            jw.WriteValue(mapStructure.Longitude.GetValueOrDefault(0));

                            jw.WritePropertyName("ccc");
                            jw.WriteValue($"{mapStructure.X} {mapStructure.Y} {mapStructure.Z}");


                            bool exportInventories = true;

                            if (exportInventories)
                            {
                                jw.WritePropertyName("inventory");
                                jw.WriteStartArray();
                                if (mapStructure.Inventory.Items.Count > 0)
                                {
                                    foreach (var invItem in mapStructure.Inventory.Items)
                                    {
                                        if (!invItem.IsEngram)
                                        {
                                            jw.WriteStartObject();

                                            jw.WritePropertyName("itemId");
                                            jw.WriteValue(invItem.ClassName);

                                            jw.WritePropertyName("qty");
                                            jw.WriteValue(invItem.Quantity);

                                            jw.WritePropertyName("blueprint");
                                            jw.WriteValue(invItem.IsBlueprint);


                                            jw.WriteEndObject();
                                        }

                                    }
                                }

                                jw.WriteEndArray();
                            }

                            jw.WriteEndObject();

                        }




                        foreach (var mapStructure in WaterVeins)
                        {

                            jw.WriteStartObject();


                            jw.WritePropertyName("struct");
                            jw.WriteValue(mapStructure.ClassName);

                            jw.WritePropertyName("lat");
                            jw.WriteValue(mapStructure.Latitude.GetValueOrDefault(0));

                            jw.WritePropertyName("lon");
                            jw.WriteValue(mapStructure.Longitude.GetValueOrDefault(0));

                            jw.WritePropertyName("ccc");
                            jw.WriteValue($"{mapStructure.X} {mapStructure.Y} {mapStructure.Z}");


                            bool exportInventories = true;

                            if (exportInventories)
                            {
                                jw.WritePropertyName("inventory");
                                jw.WriteStartArray();
                                if (mapStructure.Inventory.Items.Count > 0)
                                {
                                    foreach (var invItem in mapStructure.Inventory.Items)
                                    {
                                        if (!invItem.IsEngram)
                                        {
                                            jw.WriteStartObject();

                                            jw.WritePropertyName("itemId");
                                            jw.WriteValue(invItem.ClassName);

                                            jw.WritePropertyName("qty");
                                            jw.WriteValue(invItem.Quantity);

                                            jw.WritePropertyName("blueprint");
                                            jw.WriteValue(invItem.IsBlueprint);


                                            jw.WriteEndObject();
                                        }

                                    }
                                }

                                jw.WriteEndArray();
                            }

                            jw.WriteEndObject();

                        }

                        foreach (var mapStructure in ChargeNodes)
                        {

                            jw.WriteStartObject();


                            jw.WritePropertyName("struct");
                            jw.WriteValue(mapStructure.ClassName);

                            jw.WritePropertyName("lat");
                            jw.WriteValue(mapStructure.Latitude.GetValueOrDefault(0));

                            jw.WritePropertyName("lon");
                            jw.WriteValue(mapStructure.Longitude.GetValueOrDefault(0));

                            jw.WritePropertyName("ccc");
                            jw.WriteValue($"{mapStructure.X} {mapStructure.Y} {mapStructure.Z}");


                            bool exportInventories = true;

                            if (exportInventories)
                            {
                                jw.WritePropertyName("inventory");
                                jw.WriteStartArray();
                                if (mapStructure.Inventory.Items.Count > 0)
                                {
                                    foreach (var invItem in mapStructure.Inventory.Items)
                                    {
                                        if (!invItem.IsEngram)
                                        {
                                            jw.WriteStartObject();

                                            jw.WritePropertyName("itemId");
                                            jw.WriteValue(invItem.ClassName);

                                            jw.WritePropertyName("qty");
                                            jw.WriteValue(invItem.Quantity);

                                            jw.WritePropertyName("blueprint");
                                            jw.WriteValue(invItem.IsBlueprint);


                                            jw.WriteEndObject();
                                        }

                                    }
                                }

                                jw.WriteEndArray();
                            }

                            jw.WriteEndObject();

                        }


                        foreach (var mapStructure in Artifacts)
                        {

                            jw.WriteStartObject();


                            jw.WritePropertyName("struct");
                            jw.WriteValue(mapStructure.ClassName);

                            jw.WritePropertyName("lat");
                            jw.WriteValue(mapStructure.Latitude.GetValueOrDefault(0));

                            jw.WritePropertyName("lon");
                            jw.WriteValue(mapStructure.Longitude.GetValueOrDefault(0));

                            jw.WritePropertyName("ccc");
                            jw.WriteValue($"{mapStructure.X} {mapStructure.Y} {mapStructure.Z}");


                            bool exportInventories = true;

                            if (exportInventories)
                            {
                                jw.WritePropertyName("inventory");
                                jw.WriteStartArray();
                                if (mapStructure.Inventory.Items.Count > 0)
                                {
                                    foreach (var invItem in mapStructure.Inventory.Items)
                                    {
                                        if (!invItem.IsEngram)
                                        {
                                            jw.WriteStartObject();

                                            jw.WritePropertyName("itemId");
                                            jw.WriteValue(invItem.ClassName);

                                            jw.WritePropertyName("qty");
                                            jw.WriteValue(invItem.Quantity);

                                            jw.WritePropertyName("blueprint");
                                            jw.WriteValue(invItem.IsBlueprint);


                                            jw.WriteEndObject();
                                        }

                                    }
                                }

                                jw.WriteEndArray();
                            }

                            jw.WriteEndObject();

                        }


                        foreach (var mapStructure in WyvernNests)
                        {

                            jw.WriteStartObject();


                            jw.WritePropertyName("struct");
                            jw.WriteValue(mapStructure.ClassName);

                            jw.WritePropertyName("lat");
                            jw.WriteValue(mapStructure.Latitude.GetValueOrDefault(0));

                            jw.WritePropertyName("lon");
                            jw.WriteValue(mapStructure.Longitude.GetValueOrDefault(0));

                            jw.WritePropertyName("ccc");
                            jw.WriteValue($"{mapStructure.X} {mapStructure.Y} {mapStructure.Z}");


                            bool exportInventories = true;

                            if (exportInventories)
                            {
                                jw.WritePropertyName("inventory");
                                jw.WriteStartArray();
                                if (mapStructure.Inventory.Items.Count > 0)
                                {
                                    foreach (var invItem in mapStructure.Inventory.Items)
                                    {
                                        if (!invItem.IsEngram)
                                        {
                                            jw.WriteStartObject();

                                            jw.WritePropertyName("itemId");
                                            jw.WriteValue(invItem.ClassName);

                                            jw.WritePropertyName("qty");
                                            jw.WriteValue(invItem.Quantity);

                                            jw.WritePropertyName("blueprint");
                                            jw.WriteValue(invItem.IsBlueprint);


                                            jw.WriteEndObject();
                                        }

                                    }
                                }

                                jw.WriteEndArray();
                            }

                            jw.WriteEndObject();

                        }


                        foreach (var mapStructure in DeinoNests)
                        {

                            jw.WriteStartObject();


                            jw.WritePropertyName("struct");
                            jw.WriteValue(mapStructure.ClassName);

                            jw.WritePropertyName("lat");
                            jw.WriteValue(mapStructure.Latitude.GetValueOrDefault(0));

                            jw.WritePropertyName("lon");
                            jw.WriteValue(mapStructure.Longitude.GetValueOrDefault(0));

                            jw.WritePropertyName("ccc");
                            jw.WriteValue($"{mapStructure.X} {mapStructure.Y} {mapStructure.Z}");


                            bool exportInventories = true;

                            if (exportInventories)
                            {
                                jw.WritePropertyName("inventory");
                                jw.WriteStartArray();
                                if (mapStructure.Inventory.Items.Count > 0)
                                {
                                    foreach (var invItem in mapStructure.Inventory.Items)
                                    {
                                        if (!invItem.IsEngram)
                                        {
                                            jw.WriteStartObject();

                                            jw.WritePropertyName("itemId");
                                            jw.WriteValue(invItem.ClassName);

                                            jw.WritePropertyName("qty");
                                            jw.WriteValue(invItem.Quantity);

                                            jw.WritePropertyName("blueprint");
                                            jw.WriteValue(invItem.IsBlueprint);


                                            jw.WriteEndObject();
                                        }

                                    }
                                }

                                jw.WriteEndArray();
                            }

                            jw.WriteEndObject();

                        }

                        foreach (var mapStructure in DrakeNests)
                        {

                            jw.WriteStartObject();


                            jw.WritePropertyName("struct");
                            jw.WriteValue(mapStructure.ClassName);

                            jw.WritePropertyName("lat");
                            jw.WriteValue(mapStructure.Latitude.GetValueOrDefault(0));

                            jw.WritePropertyName("lon");
                            jw.WriteValue(mapStructure.Longitude.GetValueOrDefault(0));

                            jw.WritePropertyName("ccc");
                            jw.WriteValue($"{mapStructure.X} {mapStructure.Y} {mapStructure.Z}");


                            bool exportInventories = true;

                            if (exportInventories)
                            {
                                jw.WritePropertyName("inventory");
                                jw.WriteStartArray();
                                if (mapStructure.Inventory.Items.Count > 0)
                                {
                                    foreach (var invItem in mapStructure.Inventory.Items)
                                    {
                                        if (!invItem.IsEngram)
                                        {
                                            jw.WriteStartObject();

                                            jw.WritePropertyName("itemId");
                                            jw.WriteValue(invItem.ClassName);

                                            jw.WritePropertyName("qty");
                                            jw.WriteValue(invItem.Quantity);

                                            jw.WritePropertyName("blueprint");
                                            jw.WriteValue(invItem.IsBlueprint);


                                            jw.WriteEndObject();
                                        }

                                    }
                                }

                                jw.WriteEndArray();
                            }

                            jw.WriteEndObject();

                        }


                        foreach (var mapStructure in MagmaNests)
                        {

                            jw.WriteStartObject();


                            jw.WritePropertyName("struct");
                            jw.WriteValue(mapStructure.ClassName);

                            jw.WritePropertyName("lat");
                            jw.WriteValue(mapStructure.Latitude.GetValueOrDefault(0));

                            jw.WritePropertyName("lon");
                            jw.WriteValue(mapStructure.Longitude.GetValueOrDefault(0));

                            jw.WritePropertyName("ccc");
                            jw.WriteValue($"{mapStructure.X} {mapStructure.Y} {mapStructure.Z}");


                            bool exportInventories = true;

                            if (exportInventories)
                            {
                                jw.WritePropertyName("inventory");
                                jw.WriteStartArray();
                                if (mapStructure.Inventory.Items.Count > 0)
                                {
                                    foreach (var invItem in mapStructure.Inventory.Items)
                                    {
                                        if (!invItem.IsEngram)
                                        {
                                            jw.WriteStartObject();

                                            jw.WritePropertyName("itemId");
                                            jw.WriteValue(invItem.ClassName);

                                            jw.WritePropertyName("qty");
                                            jw.WriteValue(invItem.Quantity);

                                            jw.WritePropertyName("blueprint");
                                            jw.WriteValue(invItem.IsBlueprint);


                                            jw.WriteEndObject();
                                        }

                                    }
                                }

                                jw.WriteEndArray();
                            }

                            jw.WriteEndObject();

                        }

                        foreach (var mapStructure in BeaverDams)
                        {

                            jw.WriteStartObject();


                            jw.WritePropertyName("struct");
                            jw.WriteValue(mapStructure.ClassName);

                            jw.WritePropertyName("lat");
                            jw.WriteValue(mapStructure.Latitude.GetValueOrDefault(0));

                            jw.WritePropertyName("lon");
                            jw.WriteValue(mapStructure.Longitude.GetValueOrDefault(0));

                            jw.WritePropertyName("ccc");
                            jw.WriteValue($"{mapStructure.X} {mapStructure.Y} {mapStructure.Z}");


                            bool exportInventories = true;

                            if (exportInventories)
                            {
                                jw.WritePropertyName("inventory");
                                jw.WriteStartArray();
                                if (mapStructure.Inventory.Items.Count > 0)
                                {
                                    foreach (var invItem in mapStructure.Inventory.Items)
                                    {
                                        if (!invItem.IsEngram)
                                        {
                                            jw.WriteStartObject();

                                            jw.WritePropertyName("itemId");
                                            jw.WriteValue(invItem.ClassName);

                                            jw.WritePropertyName("qty");
                                            jw.WriteValue(invItem.Quantity);

                                            jw.WritePropertyName("blueprint");
                                            jw.WriteValue(invItem.IsBlueprint);


                                            jw.WriteEndObject();
                                        }

                                    }
                                }

                                jw.WriteEndArray();
                            }

                            jw.WriteEndObject();

                        }

                        foreach (var mapStructure in GlitchMarkers)
                        {

                            jw.WriteStartObject();


                            jw.WritePropertyName("struct");
                            jw.WriteValue(mapStructure.ClassName);

                            jw.WritePropertyName("lat");
                            jw.WriteValue(mapStructure.Latitude.GetValueOrDefault(0));

                            jw.WritePropertyName("lon");
                            jw.WriteValue(mapStructure.Longitude.GetValueOrDefault(0));

                            jw.WritePropertyName("ccc");
                            jw.WriteValue($"{mapStructure.X} {mapStructure.Y} {mapStructure.Z}");


                            bool exportInventories = true;

                            if (exportInventories)
                            {
                                jw.WritePropertyName("inventory");
                                jw.WriteStartArray();
                                if (mapStructure.Inventory.Items.Count > 0)
                                {
                                    foreach (var invItem in mapStructure.Inventory.Items)
                                    {
                                        if (!invItem.IsEngram)
                                        {
                                            jw.WriteStartObject();

                                            jw.WritePropertyName("itemId");
                                            jw.WriteValue(invItem.ClassName);

                                            jw.WritePropertyName("qty");
                                            jw.WriteValue(invItem.Quantity);

                                            jw.WritePropertyName("blueprint");
                                            jw.WriteValue(invItem.IsBlueprint);


                                            jw.WriteEndObject();
                                        }

                                    }
                                }

                                jw.WriteEndArray();
                            }

                            jw.WriteEndObject();

                        }


                        foreach (var mapStructure in BeeHives)
                        {

                            jw.WriteStartObject();


                            jw.WritePropertyName("struct");
                            jw.WriteValue(mapStructure.ClassName);

                            jw.WritePropertyName("lat");
                            jw.WriteValue(mapStructure.Latitude.GetValueOrDefault(0));

                            jw.WritePropertyName("lon");
                            jw.WriteValue(mapStructure.Longitude.GetValueOrDefault(0));

                            jw.WritePropertyName("ccc");
                            jw.WriteValue($"{mapStructure.X} {mapStructure.Y} {mapStructure.Z}");


                            bool exportInventories = true;

                            if (exportInventories)
                            {
                                jw.WritePropertyName("inventory");
                                jw.WriteStartArray();
                                if (mapStructure.Inventory.Items.Count > 0)
                                {
                                    foreach (var invItem in mapStructure.Inventory.Items)
                                    {
                                        if (!invItem.IsEngram)
                                        {
                                            jw.WriteStartObject();

                                            jw.WritePropertyName("itemId");
                                            jw.WriteValue(invItem.ClassName);

                                            jw.WritePropertyName("qty");
                                            jw.WriteValue(invItem.Quantity);

                                            jw.WritePropertyName("blueprint");
                                            jw.WriteValue(invItem.IsBlueprint);


                                            jw.WriteEndObject();
                                        }

                                    }
                                }

                                jw.WriteEndArray();
                            }

                            jw.WriteEndObject();

                        }

                        jw.WriteEndArray();
                    }

                }

            }

        }

        public void ExportJsonPlayerStructures(string exportFilename)
        {
            string exportFolder = Path.GetDirectoryName(exportFilename);
            if (!Directory.Exists(exportFolder)) Directory.CreateDirectory(exportFolder);


            using (FileStream fs = File.Create(exportFilename))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    using (JsonTextWriter jw = new JsonTextWriter(sw))
                    {
                        jw.WriteStartArray();

                        foreach (var tribe in Tribes)
                        {
                            var playerStructures = tribe.Structures;
                            foreach (var structure in playerStructures)
                            {
                                jw.WriteStartObject();

                                jw.WritePropertyName("tribeid");
                                jw.WriteValue(tribe.TribeId);


                                jw.WritePropertyName("tribe");
                                jw.WriteValue(tribe.TribeName);


                                jw.WritePropertyName("struct");
                                jw.WriteValue(structure.ClassName);

                                jw.WritePropertyName("lat");
                                jw.WriteValue(structure.Latitude.GetValueOrDefault(0));

                                jw.WritePropertyName("lon");
                                jw.WriteValue(structure.Longitude.GetValueOrDefault(0));

                                jw.WritePropertyName("ccc");
                                jw.WriteValue($"{structure.X} {structure.Y} {structure.Z}");


                                jw.WritePropertyName("created");
                                jw.WriteValue($"{structure.CreatedDateTime}");

                                bool exportInventories = true;

                                if (exportInventories)
                                {
                                    jw.WritePropertyName("inventory");
                                    jw.WriteStartArray();
                                    if (structure.Inventory.Items.Count > 0)
                                    {
                                        foreach (var invItem in structure.Inventory.Items)
                                        {
                                            if (!invItem.IsEngram)
                                            {
                                                jw.WriteStartObject();

                                                jw.WritePropertyName("itemId");
                                                jw.WriteValue(invItem.ClassName);

                                                jw.WritePropertyName("qty");
                                                jw.WriteValue(invItem.Quantity);

                                                jw.WritePropertyName("blueprint");
                                                jw.WriteValue(invItem.IsBlueprint);


                                                jw.WriteEndObject();
                                            }

                                        }
                                    }

                                    jw.WriteEndArray();
                                }

                                jw.WriteEnd();
                            }
                        }

                        jw.WriteEndArray();
                    }

                }

            }
        }


        public void ExportJsonPlayerTribeLogs(string exportFilename)
        {
            string exportFolder = Path.GetDirectoryName(exportFilename);
            if (!Directory.Exists(exportFolder)) Directory.CreateDirectory(exportFolder);


            using (FileStream fs = File.Create(exportFilename))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    using (JsonTextWriter jw = new JsonTextWriter(sw))
                    {
                        jw.WriteStartArray();

                        foreach (var playerTribe in Tribes)
                        {
                            jw.WriteStartObject();

                            jw.WritePropertyName("tribeid");
                            jw.WriteValue(playerTribe.TribeId);

                            jw.WritePropertyName("tribe");
                            jw.WriteValue(playerTribe.TribeName);


                            if (playerTribe.Logs != null && playerTribe.Logs.Length > 0)
                            {
                                jw.WritePropertyName("logs");
                                jw.WriteStartArray();
                                foreach (var logEntry in playerTribe.Logs)
                                {

                                    jw.WriteValue(logEntry);
                                }

                                jw.WriteEndArray();
                            }

                            jw.WriteEnd();
                        }

                        jw.WriteEndArray();
                    }

                }

            }

        }


        public void ExportJsonPlayerTribes(string exportFilename)
        {
            if (File.Exists(exportFilename)) File.Delete(exportFilename);

            using (StreamWriter sw = new StreamWriter(exportFilename))
            {
                using (JsonTextWriter jw = new JsonTextWriter(sw))
                {
                    jw.WriteStartArray();

                    foreach (var playerTribe in Tribes)
                    {
                        jw.WriteStartObject();

                        jw.WritePropertyName("tribeid");
                        jw.WriteValue(playerTribe.TribeId);

                        jw.WritePropertyName("tribe");
                        jw.WriteValue(playerTribe.TribeName);

                        jw.WritePropertyName("players");
                        jw.WriteValue(playerTribe.Players.Count);

                        if (playerTribe.Players != null && playerTribe.Players.Count > 0)
                        {
                            jw.WritePropertyName("members");
                            jw.WriteStartArray();
                            foreach (var tribePlayer in playerTribe.Players)
                            {
                                jw.WriteStartObject();

                                jw.WritePropertyName("ign");
                                jw.WriteValue(tribePlayer.CharacterName);

                                jw.WritePropertyName("lvl");
                                jw.WriteValue(tribePlayer.Level.ToString());

                                jw.WritePropertyName("playerid");
                                jw.WriteValue(tribePlayer.Id.ToString());

                                jw.WritePropertyName("playername");
                                jw.WriteValue(tribePlayer.Name);

                                jw.WritePropertyName("steamid");
                                jw.WriteValue(tribePlayer.NetworkId);

                                jw.WriteEndObject();
                            }

                            jw.WriteEndArray();
                        }



                        jw.WritePropertyName("tames");
                        jw.WriteValue(playerTribe.Tames.LongCount(c=>c.UploadedTimeInGame ==0));


                        jw.WritePropertyName("uploadedTames");
                        jw.WriteValue(playerTribe.Tames.LongCount(c => c.UploadedTimeInGame != 0));

                        jw.WritePropertyName("structures");
                        jw.WriteValue(playerTribe.Structures.Count);

                        jw.WritePropertyName("active");
                        jw.WriteValue(playerTribe.LastActive);


                        jw.WriteEnd();
                    }

                    jw.WriteEndArray();
                }

            }

        }

        public void ExportJsonPlayers(string exportFilename)
        {
            string exportFolder = Path.GetDirectoryName(exportFilename)??"";
            if (!Directory.Exists(exportFolder)) Directory.CreateDirectory(exportFolder);

            using (FileStream fs = File.Create(exportFilename))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    using (JsonTextWriter jw = new JsonTextWriter(sw))
                    {
                        jw.WriteStartArray();

                        foreach (var tribe in Tribes)
                        {
                            foreach (var player in tribe.Players)
                            {
                                jw.WriteStartObject();

                                jw.WritePropertyName("playerid");
                                jw.WriteValue(player.Id);

                                jw.WritePropertyName("steam");
                                jw.WriteValue(player.Name);

                                jw.WritePropertyName("name");
                                jw.WriteValue(player.CharacterName);

                                jw.WritePropertyName("tribeid");
                                jw.WriteValue(tribe.TribeId);

                                jw.WritePropertyName("tribe");
                                jw.WriteValue(tribe.TribeName);

                                jw.WritePropertyName("sex");
                                jw.WriteValue(player.Gender);

                                jw.WritePropertyName("lvl");
                                jw.WriteValue(player.Level);

                                jw.WritePropertyName("lat");
                                jw.WriteValue(player.Latitude.GetValueOrDefault(0));

                                jw.WritePropertyName("lon");
                                jw.WriteValue(player.Longitude.GetValueOrDefault(0));



                                //0=health
                                //1=stamina
                                //2=torpor
                                //3=oxygen
                                //4=food
                                //5=water
                                //6=temperature
                                //7=weight
                                //8=melee damage
                                //9=movement speed
                                //10=fortitude
                                //11=crafting speed
                                jw.WritePropertyName("hp");
                                jw.WriteValue(player.Stats[0]);

                                jw.WritePropertyName("stam");
                                jw.WriteValue(player.Stats[1]);

                                jw.WritePropertyName("melee");
                                jw.WriteValue(player.Stats[8]);

                                jw.WritePropertyName("weight");
                                jw.WriteValue(player.Stats[7]);

                                jw.WritePropertyName("speed");
                                jw.WriteValue(player.Stats[9]);

                                jw.WritePropertyName("food");
                                jw.WriteValue(player.Stats[4]);

                                jw.WritePropertyName("water");
                                jw.WriteValue(player.Stats[5]);

                                jw.WritePropertyName("oxy");
                                jw.WriteValue(player.Stats[3]);

                                jw.WritePropertyName("craft");
                                jw.WriteValue(player.Stats[11]);

                                jw.WritePropertyName("fort");
                                jw.WriteValue(player.Stats[10]);

                                jw.WritePropertyName("active");
                                jw.WriteValue(player.LastActiveDateTime);

                                jw.WritePropertyName("ccc");
                                jw.WriteValue($"{player.X} {player.Y} {player.Z}");

                                jw.WritePropertyName("steamid");
                                jw.WriteValue(player.NetworkId);

                                bool exportInventories = true;

                                if (exportInventories)
                                {
                                    jw.WritePropertyName("inventory");
                                    jw.WriteStartArray();

                                    if (player.Inventory.Items.Count > 0)
                                    {
                                        foreach (var invItem in player.Inventory.Items)
                                        {
                                            if (!invItem.IsEngram && invItem.ClassName != "PrimalItem_StartingNote_C")
                                            {
                                                jw.WriteStartObject();

                                                jw.WritePropertyName("itemId");
                                                jw.WriteValue(invItem.ClassName);

                                                jw.WritePropertyName("qty");
                                                jw.WriteValue(invItem.Quantity);

                                                jw.WritePropertyName("blueprint");
                                                jw.WriteValue(invItem.IsBlueprint);

                                                if (invItem.UploadedTimeInGame != 0)
                                                {
                                                    jw.WritePropertyName("uploadedTime");
                                                    jw.WriteValue(invItem.UploadedTime);

                                                }

                                                jw.WriteEndObject();
                                            }

                                        }
                                    }



                                    jw.WriteEndArray();
                                }



                                jw.WriteEnd();
                            }
                        }

                        jw.WriteEndArray();
                    }

                }

            }
        }



















        public void ExportPack(string fileName)
        {

            string filePath = Path.GetDirectoryName(fileName);
            if (!Directory.Exists(filePath)) Directory.CreateDirectory(filePath);


            try
            {
                ContentPack pack = this;

                string jsonContent = JsonConvert.SerializeObject(pack);
                var compressedContent = Zip(jsonContent);

                if (File.Exists(fileName)) File.Delete(fileName);

                using (var writer = new FileStream(fileName, FileMode.CreateNew))
                {
                    writer.Write(compressedContent, 0, compressedContent.Length);
                    writer.Flush();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private void LoadGameData(ContentContainer container)
        {
            MapFilename = container.MapName;
            ContentDate = container.GameSaveTime;
            if (IncludeGameStructures)
            {

                ConcurrentBag<ContentStructure> loadedStructures = new ConcurrentBag<ContentStructure>();
                var mapDetectedTerminals = container.MapStructures.Where(s => (s.ClassName.StartsWith("TributeTerminal_") || s.ClassName.Contains("CityTerminal_")) && s.Latitude != null);
                if (mapDetectedTerminals != null)
                {
                    Parallel.ForEach(mapDetectedTerminals, terminal =>
                    {
                        loadedStructures.Add(new ContentStructure()
                        {
                            ClassName = "ASV_Terminal",
                            Latitude = terminal.Latitude.GetValueOrDefault(0),
                            Longitude = terminal.Longitude.GetValueOrDefault(0),
                            X = terminal.X,
                            Y = terminal.Y,
                            Z = terminal.Z,
                            CreatedDateTime = terminal.CreatedDateTime,
                            CreatedTimeInGame = terminal.CreatedTimeInGame,
                            Inventory = IncludeGameStructureContent ? terminal.Inventory : new ContentInventory()
                        });

                    });
                }


                //user defined terminals
                //if (Program.ProgramConfig.TerminalMarkers != null)
                //{
                //    var mapTerminals = loadedStructures.ToList();
                //    var terminals = Program.ProgramConfig.TerminalMarkers
                //        .Where(m =>
                //            m.Map.ToLower().StartsWith(MapFilename.ToLower())
                //            //exclude any that match map detected terminal location
                //            & !mapTerminals.Any(t => t.Latitude.ToString().StartsWith(m.Lat.ToString()) && t.Longitude.ToString().StartsWith(m.Lon.ToString()))
                //        ).ToList();

                //    if (terminals != null)
                //    {
                //        Parallel.ForEach(terminals, terminal =>
                //        {
                //            loadedStructures.Add(new ContentStructure()
                //            {
                //                ClassName = "ASV_Terminal",
                //                Latitude = (float)terminal.Lat,
                //                Longitude = (float)terminal.Lon,
                //                X = terminal.X,
                //                Y = terminal.Y,
                //                Z = terminal.Z
                //            });

                //        });
                //    }

                //}
                if (!loadedStructures.IsEmpty) TerminalMarkers.AddRange(loadedStructures.ToList());


                //Charge nodes
                loadedStructures = new ConcurrentBag<ContentStructure>();
                var chargeNodes = container.MapStructures
                    .Where(s =>
                        (s.ClassName.StartsWith("PrimalItem_PowerNodeCharge") || s.ClassName.StartsWith("PrimalStructurePowerNode_C"))
                        && s.Latitude != null
                        && (Math.Abs((decimal)s.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                        && (Math.Abs((decimal)s.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                    ).ToList();

                if (chargeNodes != null && chargeNodes.Count > 0)
                {
                    Parallel.ForEach(chargeNodes, chargeNode =>
                    {
                        loadedStructures.Add(new ContentStructure()
                        {
                            ClassName = "ASV_ChargeNode",
                            Latitude = chargeNode.Latitude.GetValueOrDefault(0),
                            Longitude = chargeNode.Longitude.GetValueOrDefault(0),
                            X = chargeNode.X,
                            Y = chargeNode.Y,
                            Z = chargeNode.Z,
                            CreatedDateTime = chargeNode.CreatedDateTime,
                            CreatedTimeInGame = chargeNode.CreatedTimeInGame,
                            Inventory = IncludeGameStructureContent ? chargeNode.Inventory : new ContentInventory()
                        });
                    });
                }
                if (!loadedStructures.IsEmpty) ChargeNodes.AddRange(loadedStructures.ToList());

                //GlitchMarkers
                /*
                loadedStructures = new ConcurrentBag<ContentStructure>();
                var glitches = Program.ProgramConfig.GlitchMarkers
                    .Where(
                        m => m.Map.ToLower().StartsWith(MapFilename.ToLower())
                        && (Math.Abs((decimal)m.Lat - FilterLatitude) <= FilterRadius)
                        && (Math.Abs((decimal)m.Lon - FilterLongitude) <= FilterRadius)
                    ).ToList();

                if (glitches != null && glitches.Count > 0)
                {
                    Parallel.ForEach(glitches, glitch =>
                    {
                        loadedStructures.Add(new ContentStructure()
                        {
                            ClassName = "ASV_Glitch",
                            Latitude = (float)glitch.Lat,
                            Longitude = (float)glitch.Lon,
                            X = glitch.X,
                            Y = glitch.Y,
                            Z = glitch.Z,
                            InventoryId = null
                        });

                    });
                }
                if (!loadedStructures.IsEmpty) GlitchMarkers.AddRange(loadedStructures.ToList());
                */


                //BeaverDams 
                loadedStructures = new ConcurrentBag<ContentStructure>();
                var beaverHouses = container.MapStructures
                    .Where(s =>
                        s.ClassName.StartsWith("BeaverDam_C")
                        && s.Latitude != null
                        && (Math.Abs((decimal)s.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                        && (Math.Abs((decimal)s.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                    ).ToList();

                if (beaverHouses != null && beaverHouses.Count > 0)
                {
                    Parallel.ForEach(beaverHouses, house =>
                    {
                        var loadedStructure = new ContentStructure()
                        {
                            ClassName = "ASV_BeaverDam",
                            Latitude = house.Latitude,
                            Longitude = house.Longitude,
                            X = house.X,
                            Y = house.Y,
                            Z = house.Z,
                            Inventory = IncludeGameStructureContent ? house.Inventory : new ContentInventory()
                        };

                        loadedStructures.Add(loadedStructure);

                    });
                }
                if (!loadedStructures.IsEmpty) BeaverDams.AddRange(loadedStructures.ToList());


                //WyvernNests
                loadedStructures = new ConcurrentBag<ContentStructure>();
                var wyvernNests = container.MapStructures
                    .Where(s =>
                        s.ClassName.StartsWith("WyvernNest_")
                        && s.Latitude != null
                        && (Math.Abs((decimal)s.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                        && (Math.Abs((decimal)s.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                    ).ToList();
                if (wyvernNests != null && wyvernNests.Count > 0)
                {
                    Parallel.ForEach(wyvernNests, nest =>
                    {
                        var loadedStructure = new ContentStructure()
                        {
                            ClassName = "ASV_WyvernNest",
                            Latitude = nest.Latitude,
                            Longitude = nest.Longitude,
                            X = nest.X,
                            Y = nest.Y,
                            Z = nest.Z,
                            Inventory = IncludeGameStructureContent ? nest.Inventory : new ContentInventory()
                        };

                        loadedStructures.Add(loadedStructure);

                    });
                }
                if (!loadedStructures.IsEmpty) WyvernNests.AddRange(loadedStructures.ToList());


                //DrakeNests 
                loadedStructures = new ConcurrentBag<ContentStructure>();
                var drakeNests = container.MapStructures
                    .Where(s =>
                        s.ClassName.StartsWith("RockDrakeNest_C")
                        && s.Latitude != null
                        && (Math.Abs((decimal)s.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                        && (Math.Abs((decimal)s.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                    ).ToList();

                if (drakeNests != null && drakeNests.Count > 0)
                {
                    Parallel.ForEach(drakeNests, nest =>
                    {
                        var loadedStructure = new ContentStructure()
                        {
                            ClassName = "ASV_DrakeNest",
                            Latitude = nest.Latitude,
                            Longitude = nest.Longitude,
                            X = nest.X,
                            Y = nest.Y,
                            Z = nest.Z,
                            Inventory = IncludeGameStructureContent ? nest.Inventory : new ContentInventory()
                        };

                        loadedStructures.Add(loadedStructure);

                    });
                }
                if (!loadedStructures.IsEmpty) DrakeNests.AddRange(loadedStructures.ToList());


                //Deino nests
                loadedStructures = new ConcurrentBag<ContentStructure>();
                var deinoNests = container.MapStructures
                    .Where(s =>
                        s.ClassName.StartsWith("DeinonychusNest_C")
                        && s.Latitude != null
                        && (Math.Abs((decimal)s.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                        && (Math.Abs((decimal)s.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                    ).ToList();

                if (deinoNests != null && deinoNests.Count > 0)
                {
                    Parallel.ForEach(deinoNests, nest =>
                    {
                        var loadedStructure = new ContentStructure()
                        {
                            ClassName = "ASV_DeinoNest",
                            Latitude = (float)nest.Latitude,
                            Longitude = (float)nest.Longitude,
                            X = nest.X,
                            Y = nest.Y,
                            Z = nest.Z,
                            Inventory = IncludeGameStructureContent ? nest.Inventory : new ContentInventory()
                        };

                        loadedStructures.Add(loadedStructure);

                    });
                }
                if (!loadedStructures.IsEmpty) DeinoNests.AddRange(loadedStructures.ToList());

                //MagmaNests 
                loadedStructures = new ConcurrentBag<ContentStructure>();
                var magmaNests = container.MapStructures
                    .Where(s =>
                        s.ClassName.StartsWith("CherufeNest_C")
                        && s.Latitude != null
                        && (Math.Abs((decimal)s.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                        && (Math.Abs((decimal)s.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                    ).ToList();

                if (magmaNests != null && magmaNests.Count > 0)
                {
                    Parallel.ForEach(magmaNests, nest =>
                    {

                        var loadedStructure = new ContentStructure()
                        {
                            ClassName = "ASV_MagmaNest",
                            Latitude = nest.Latitude,
                            Longitude = nest.Longitude,
                            X = nest.X,
                            Y = nest.Y,
                            Z = nest.Z,
                            Inventory = IncludeGameStructureContent ? nest.Inventory : new ContentInventory()
                        };

                        loadedStructures.Add(loadedStructure);

                    });
                }
                if (!loadedStructures.IsEmpty) MagmaNests.AddRange(loadedStructures.ToList());


                //OilVeins  
                loadedStructures = new ConcurrentBag<ContentStructure>();
                var oilVeins = container.MapStructures
                    .Where(s =>
                        s.ClassName.StartsWith("OilVein_")
                        && s.Latitude != null
                        && (Math.Abs((decimal)s.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                        && (Math.Abs((decimal)s.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                    ).ToList();

                if (oilVeins != null && oilVeins.Count > 0)
                {
                    Parallel.ForEach(oilVeins, vein =>
                    {
                        loadedStructures.Add(new ContentStructure()
                        {
                            ClassName = "ASV_OilVein",
                            Latitude = vein.Latitude,
                            Longitude = vein.Longitude,
                            X = vein.X,
                            Y = vein.Y,
                            Z = vein.Z,
                            Inventory = IncludeGameStructureContent ? vein.Inventory : new ContentInventory()
                        });
                    });
                }
                if (!loadedStructures.IsEmpty) OilVeins.AddRange(loadedStructures.ToList());

                //WaterVeins 
                loadedStructures = new ConcurrentBag<ContentStructure>();
                var waterVeins = container.MapStructures
                    .Where(s =>
                        s.ClassName.StartsWith("WaterVein_")
                        && s.Latitude != null
                        && (Math.Abs((decimal)s.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                        && (Math.Abs((decimal)s.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                    ).ToList();

                if (waterVeins != null && waterVeins.Count > 0)
                {
                    Parallel.ForEach(waterVeins, vein =>
                    {
                        loadedStructures.Add(new ContentStructure()
                        {
                            ClassName = "ASV_WaterVein",
                            Latitude = vein.Latitude,
                            Longitude = vein.Longitude,
                            X = vein.X,
                            Y = vein.Y,
                            Z = vein.Z,
                            Inventory = IncludeGameStructureContent ? vein.Inventory : new ContentInventory()
                        });
                    });
                }
                if (!loadedStructures.IsEmpty) WaterVeins.AddRange(loadedStructures.ToList());

                //GasVeins  
                loadedStructures = new ConcurrentBag<ContentStructure>();
                var gasVeins = container.MapStructures
                    .Where(s =>
                        s.ClassName.StartsWith("GasVein_")
                        && s.Latitude != null
                        && (Math.Abs((decimal)s.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                        && (Math.Abs((decimal)s.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                    ).ToList();

                if (gasVeins != null && gasVeins.Count > 0)
                {
                    Parallel.ForEach(gasVeins, vein =>
                    {
                        loadedStructures.Add(new ContentStructure()
                        {
                            ClassName = "ASV_GasVein",
                            Latitude = vein.Latitude,
                            Longitude = vein.Longitude,
                            X = vein.X,
                            Y = vein.Y,
                            Z = vein.Z,
                            Inventory = IncludeGameStructureContent ? vein.Inventory : new ContentInventory()
                        });
                    });
                }
                if (!loadedStructures.IsEmpty) GasVeins.AddRange(loadedStructures.ToList());

                //Artifacts 
                loadedStructures = new ConcurrentBag<ContentStructure>();
                var artifacts = container.MapStructures
                    .Where(s =>
                        s.ClassName.StartsWith("ArtifactCrate_")
                        && s.Latitude != null
                        && (Math.Abs((decimal)s.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                        && (Math.Abs((decimal)s.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                    ).ToList();

                if (artifacts != null && artifacts.Count > 0)
                {
                    Parallel.ForEach(artifacts, artifact =>
                    {
                        loadedStructures.Add(new ContentStructure()
                        {
                            ClassName = "ASV_Artifact",
                            Latitude = artifact.Latitude,
                            Longitude = artifact.Longitude,
                            X = artifact.X,
                            Y = artifact.Y,
                            Z = artifact.Z,
                            Inventory = IncludeGameStructureContent ? artifact.Inventory : new ContentInventory()
                        });
                    });
                }
                if (!loadedStructures.IsEmpty) Artifacts.AddRange(loadedStructures.ToList());

                //PlantZ
                //Artifacts 
                loadedStructures = new ConcurrentBag<ContentStructure>();
                var plants = container.MapStructures
                    .Where(s =>
                        s.ClassName.StartsWith("Structure_PlantSpeciesZ")
                        && s.Latitude != null
                        && (Math.Abs((decimal)s.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                        && (Math.Abs((decimal)s.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                    ).ToList();

                if (plants != null && plants.Count > 0)
                {
                    Parallel.ForEach(plants, plant =>
                    {
                        loadedStructures.Add(new ContentStructure()
                        {
                            ClassName = "ASV_PlantZ",
                            Latitude = plant.Latitude,
                            Longitude = plant.Longitude,
                            X = plant.X,
                            Y = plant.Y,
                            Z = plant.Z,
                            Inventory = IncludeGameStructureContent ? plant.Inventory : new ContentInventory()
                        });
                    });
                }
                if (!loadedStructures.IsEmpty) PlantZ.AddRange(loadedStructures.ToList());


                loadedStructures = new ConcurrentBag<ContentStructure>();
                var beeHives = container.MapStructures
                    .Where(s =>
                        s.ClassName.StartsWith("BeeHive_C")
                        && s.Latitude != null
                        && (Math.Abs((decimal)s.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                        && (Math.Abs((decimal)s.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                    ).ToList();
                if (beeHives != null && beeHives.Count > 0)
                {
                    Parallel.ForEach(beeHives, hive =>
                    {
                        var loadedStructure = new ContentStructure()
                        {
                            ClassName = "ASV_BeeHive",
                            Latitude = (float)hive.Latitude,
                            Longitude = (float)hive.Longitude,
                            X = hive.X,
                            Y = hive.Y,
                            Z = hive.Z,
                            Inventory = IncludeGameStructureContent ? hive.Inventory : new ContentInventory()
                        };

                        loadedStructures.Add(loadedStructure);

                    });
                }
                if (!loadedStructures.IsEmpty) BeeHives.AddRange(loadedStructures.ToList());

            }






            if (IncludeWild)
            {

                //WildCreatures
                WildCreatures = container.WildCreatures
                .Where(w =>
                    (w.Latitude.HasValue & !float.IsNaN(w.Latitude.Value))
                    && (w.Longitude.HasValue & !float.IsNaN(w.Longitude.Value))
                    && (Math.Abs((decimal)w.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                    && (Math.Abs((decimal)w.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                ).ToList();
            }

            if (IncludeTribesPlayers)
            {
                Tribes = container.Tribes;

                //remove players not in range or not selected filter player
                if (Tribes.Count > 0)
                {
                    Tribes.ForEach(t =>
                    {
                        var playerCheck = t.Players.Where(p =>
                            (Math.Abs((decimal)p.Latitude.GetValueOrDefault(0) - FilterLatitude) > FilterRadius)
                            && (Math.Abs((decimal)p.Longitude.GetValueOrDefault(0) - FilterLongitude) > FilterRadius)
                            && (ExportedForPlayer == 0 || (ExportedForPlayer != 0 && p.Id != ExportedForPlayer))
                        );

                        if (!IncludeTamed)
                        {
                            t.Tames = new ConcurrentBag<ContentTamedCreature>(); ;
                        }

                        if (!IncludePlayerStructures)
                        {
                            t.Structures = new ConcurrentBag<ContentStructure>();
                        }
                    });
                }
            }

            if (IncludeDroppedItems)
            {
                //Dropped items
                ConcurrentBag<ContentDroppedItem> loadedDroppedItems = new ConcurrentBag<ContentDroppedItem>();
                DroppedItems = new List<ContentDroppedItem>();
                DroppedItems.AddRange(container.DroppedItems
                    .Where(i =>
                        (i.DroppedByPlayerId == 0 || i.DroppedByPlayerId == ExportedForPlayer || ExportedForPlayer == 0)
                        && i.Latitude != null
                        && (Math.Abs((decimal)i.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                        && (Math.Abs((decimal)i.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                    ).ToList());

            }
        }


        private void LoadPackData(ContentPack pack)
        {
            //load content pack from Ark savegame 
            MapFilename = pack.MapFilename;
            ContentDate = pack.ContentDate;
            LocalProfile = pack.LocalProfile;

            if (IncludeGameStructures)
            {
                //all locations
                TerminalMarkers = pack.TerminalMarkers;



                //possibly location restricted
                ChargeNodes = pack.ChargeNodes.Where(w =>
                                                            (Math.Abs((decimal)w.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                                                            && (Math.Abs((decimal)w.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                                                        ).ToList();
                GlitchMarkers = pack.GlitchMarkers.Where(w =>
                                                            (Math.Abs((decimal)w.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                                                            && (Math.Abs((decimal)w.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                                                            
                                                        ).ToList();
                BeaverDams = pack.BeaverDams.Where(w =>
                                                            (Math.Abs((decimal)w.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                                                            && (Math.Abs((decimal)w.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                                                        ).ToList();
                WyvernNests = pack.WyvernNests.Where(w =>
                                                            (Math.Abs((decimal)w.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                                                            && (Math.Abs((decimal)w.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                                                        ).ToList();
                DrakeNests = pack.DrakeNests.Where(w =>
                                                            (Math.Abs((decimal)w.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                                                            && (Math.Abs((decimal)w.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                                                        ).ToList();
                DeinoNests = pack.DeinoNests.Where(w =>
                                                            (Math.Abs((decimal)w.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                                                            && (Math.Abs((decimal)w.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                                                        ).ToList();
                MagmaNests = pack.MagmaNests.Where(w =>
                                                            (Math.Abs((decimal)w.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                                                            && (Math.Abs((decimal)w.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                                                        ).ToList();
                OilVeins = pack.OilVeins.Where(w =>
                                                            (Math.Abs((decimal)w.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                                                            && (Math.Abs((decimal)w.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                                                        ).ToList();
                WaterVeins = pack.WaterVeins.Where(w =>
                                                            (Math.Abs((decimal)w.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                                                            && (Math.Abs((decimal)w.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                                                        ).ToList();
                GasVeins = pack.GasVeins.Where(w =>
                                                            (Math.Abs((decimal)w.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                                                            && (Math.Abs((decimal)w.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                                                        ).ToList();
                Artifacts = pack.Artifacts.Where(w =>
                                                            (Math.Abs((decimal)w.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                                                            && (Math.Abs((decimal)w.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                                                        ).ToList();
                PlantZ = pack.PlantZ.Where(w =>
                                                            (Math.Abs((decimal)w.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                                                            && (Math.Abs((decimal)w.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                                                        ).ToList();

                if (!IncludeGameStructureContent)
                {
                    //remove linked inventory, and then unassign
                    BeaverDams.ForEach(x =>
                    {
                        x.Inventory.Items.Clear();

                    });
                    WyvernNests.ForEach(x =>
                    {
                        x.Inventory.Items.Clear();

                    });
                    DrakeNests.ForEach(x =>
                    {
                        x.Inventory.Items.Clear();

                    });
                    DeinoNests.ForEach(x =>
                    {
                        x.Inventory.Items.Clear();

                    });
                    MagmaNests.ForEach(x =>
                    {
                        x.Inventory.Items.Clear();

                    });


                }

            }


            if (IncludeWild)
            {
                //WildCreatures
                WildCreatures = pack.WildCreatures.Where(w =>
                                                            (Math.Abs((decimal)w.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                                                            && (Math.Abs((decimal)w.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                                                        ).ToList();
            }

            if (IncludeTribesPlayers)
            {
                //Tribes 
                Tribes = pack.Tribes.Where(t => (t.TribeId == ExportedForTribe || ExportedForTribe == 0) || (t.Players.Any(p => p.Id == ExportedForPlayer && ExportedForPlayer != 0))).ToList();
            }

            //player structures
            if (Tribes != null && Tribes.Count > 0)
            {
                if (!IncludePlayerStructures)
                {
                    //remove structures, not included in the filter
                    Tribes.ForEach(t => {
                        t.Structures = new ConcurrentBag<ContentStructure>();
                    });
                }
                if (!IncludeTamed)
                {
                    Tribes.ForEach(t => {
                        t.Tames = new ConcurrentBag<ContentTamedCreature>();
                    });
                }

                if (ExportedForPlayer != 0)
                {
                    //specific player, dont give data for all tribe members
                    Tribes.ForEach(t =>
                    {

                        t.Players.ToList().RemoveAll(p => p.Id != ExportedForPlayer);

                    });
                }
            }

            if (IncludeDroppedItems)
            {
                DroppedItems = pack.DroppedItems.Where(i =>
                                                            (i.DroppedByPlayerId == ExportedForPlayer || ExportedForPlayer == 0)
                                                            && (Math.Abs((decimal)i.Latitude.GetValueOrDefault(0) - FilterLatitude) <= FilterRadius)
                                                            && (Math.Abs((decimal)i.Longitude.GetValueOrDefault(0) - FilterLongitude) <= FilterRadius)
                                                      ).ToList();
            }
        }



        private void CopyTo(Stream src, Stream dest)
        {
            byte[] bytes = new byte[4096];

            int cnt;

            while ((cnt = src.Read(bytes, 0, bytes.Length)) != 0)
            {
                dest.Write(bytes, 0, cnt);
            }
        }

        private byte[] Zip(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);

            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(mso, CompressionMode.Compress))
                {
                    //msi.CopyTo(gs);
                    CopyTo(msi, gs);
                }

                return mso.ToArray();
            }
        }

        private string Unzip(byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                {
                    CopyTo(gs, mso);
                }

                return Encoding.UTF8.GetString(mso.ToArray());
            }
        }


    }
}
