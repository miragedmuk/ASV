using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ARKViewer.Models;
using ARKViewer.Models.NameMap;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using ASVPack.Models;
using System.Globalization;
using ArkViewer.Models;
using ArkViewer.Configuration;

namespace ARKViewer.Configuration
{

    public enum ViewerModes : int
    {
        Mode_SinglePlayer = 0,
        Mode_Offline = 1,
        Mode_Ftp = 2,
        Mode_ContentPack = 3
    }

    

    [DataContract]
    public class ViewerConfiguration
    {


        [DataMember] public string IV { get; set; }
        [DataMember] public string EncryptionPassword { get; set; } = "";
        [DataMember] public bool Artifacts { get; set; } = false;
        [DataMember] public bool BeaverDams { get; set; } = false;
        [DataMember] public bool WyvernNests { get; set; } = false;
        [DataMember(EmitDefaultValue = false, IsRequired = false)] public bool MagmaNests { get; set; } = false;
        [DataMember] public bool DeinoNests { get; set; } = false;
        [DataMember] public bool DrakeNests { get; set; } = false;
        [DataMember] public bool OilVeins { get; set; } = false;
        [DataMember] public bool WaterVeins { get; set; } = false;
        [DataMember] public bool GasVeins { get; set; } = false;
        [DataMember] public bool Obelisks { get; set; } = true;
        [DataMember(EmitDefaultValue = false, IsRequired = false)] public bool Glitches { get; set; } = true;
        [DataMember(EmitDefaultValue = false, IsRequired = false)] public bool BeeHives { get; set; } = true;
        [DataMember] public bool ChargeNodes { get; set; } = false;
        [DataMember] public bool PlantX { get; set; } = false;
        [DataMember] public bool PlantZ { get; set; } = false;
        [DataMember] public ViewerModes Mode { get; set; } = ViewerModes.Mode_SinglePlayer;
        [DataMember(IsRequired = false, EmitDefaultValue = false)] public bool UpdateNotificationSingle { get; set; } = true;
        [DataMember(IsRequired = false, EmitDefaultValue = false)] public bool UpdateNotificationFile { get; set; } = true;
        [DataMember] public string SelectedFile { get; set; }
        [DataMember] public string SelectedServer { get; set; } = "";
        [DataMember] public string ClusterFolder { get; set; } = "";
        [DataMember] public List<string> StructureExclusions { get; set; } = new List<string>();
        [DataMember] public List<ServerConfiguration> ServerList { get; set; } = new List<ServerConfiguration>();
        [DataMember] public List<OfflineFileConfiguration> OfflineList { get; set; } = new List<OfflineFileConfiguration>();
        [DataMember] public List<ViewerWindow> Windows { get; set; } = new List<ViewerWindow>();
        [DataMember] public int Zoom { get; set; } = 50;
        [DataMember(IsRequired = false)] public int SplitterDistance { get; set; } = 840;
        [DataMember(IsRequired = false)] public bool HideNoStructures { get; set; } = true;
        [DataMember(IsRequired = false)] public bool HideNoTames { get; set; } = true;
        [DataMember(IsRequired = false)] public bool HideNoBody { get; set; } = true;
        [DataMember(IsRequired = false)] public int CommandPrefix { get; set; } = 0;
        [DataMember(IsRequired = false, EmitDefaultValue = false)] public int FtpDownloadMode { get; set; } = 0;
        [DataMember(IsRequired = false, EmitDefaultValue = false)] public int FtpTimeout { get; set; } = 300000; //5 mins

        [DataMember] public int FtpLoadMode { get; set; } = 0; //manual

        [DataMember(IsRequired = false, EmitDefaultValue = false)] public bool SortCommandLineExport { get; set; } = false;
        [DataMember(IsRequired = false, EmitDefaultValue = false)] public bool ExportInventories { get; set; } = false;
        [DataMember(IsRequired = false, EmitDefaultValue = true)] public LogColourMap TribeLogColours { get; set; } = new LogColourMap();
        [DataMember(IsRequired = false)] public bool StoredTames { get; set; } = false;
        [DataMember] public string ArkSavedGameFolder { get; set; } = "";

        [DataMember(IsRequired = false, EmitDefaultValue = false)] public int HighlightColorVivarium { get; set; } = System.Drawing.Color.LightGreen.ToArgb();
        [DataMember(IsRequired = false, EmitDefaultValue = false)] public int HighlightColorCryopod { get; set; } = System.Drawing.Color.LightSkyBlue.ToArgb();
        [DataMember(IsRequired = false, EmitDefaultValue = false)] public int HighlightColorUploaded { get; set; } = System.Drawing.Color.WhiteSmoke.ToArgb();

        [DataMember(IsRequired = false, EmitDefaultValue = false)] public int ProfileDayLimit { get; set; } = 30;

        [DataMember(IsRequired = false, EmitDefaultValue = false)] public bool LoadSaveOnStartup{ get; set; } = true;

        [DataMember(IsRequired = false, EmitDefaultValue = true)] public int MaxCores{ get; set; } = Environment.ProcessorCount;

        public List<DinoClassMap> DinoMap = new List<DinoClassMap>();
        public List<ContentMarker> MapMarkerList { get; set; } = new List<ContentMarker>();
        public List<ItemClassMap> ItemMap { get; set; } = new List<ItemClassMap>();
        public List<StructureClassMap> StructureMap { get; set; } = new List<StructureClassMap>();
        public List<ColourMap> ColourMap { get; set; } = new List<ColourMap>();
        public List<ASVStructureMarker> TerminalMarkers { get; set; } = new List<ASVStructureMarker>();
        public List<ASVStructureMarker> GlitchMarkers { get; set; } = new List<ASVStructureMarker>();

        public List<ASVBreedingSearch> BreedingSearchOptions { get; set; } = new List<ASVBreedingSearch>();

        public List<MissionMap> MissionMaps { get; set; } = new List<MissionMap>();


        

        public ViewerConfiguration()
        {
            Load();
        }

        public void Save()
        {
            var savePath = AppContext.BaseDirectory;
            var saveFilename = Path.Combine(savePath, "config.json");


            //encrypt server passwords prior to saving to disk
            if (ServerList.Count > 0)
            {
                foreach (var server in ServerList)
                {

                    server.Username = EncryptString(server.Username, Convert.FromBase64String(this.IV), this.EncryptionPassword);
                    server.Password = EncryptString(server.Password, Convert.FromBase64String(this.IV), this.EncryptionPassword);

                    if (!string.IsNullOrEmpty(server.RCONPassword))
                    {
                        server.RCONPassword = EncryptString(server.RCONPassword, Convert.FromBase64String(this.IV), this.EncryptionPassword);
                    }

                }
            }


            //base64 the password to save
            this.EncryptionPassword = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(this.EncryptionPassword));
            string jsonFileContent = configToJson();
            File.WriteAllText(saveFilename, jsonFileContent);

            //save dinomap
            var dinoMapFilename = Path.Combine(savePath, "creaturemap.json");
            JArray dinoArray = new JArray();
            if (DinoMap.Count > 0)
            {
                foreach (var dino in DinoMap)
                {
                    JObject dinoObject = new JObject();
                    dinoObject.Add(new JProperty("ClassName", dino.ClassName));
                    dinoObject.Add(new JProperty("FriendlyName", dino.FriendlyName));
                    dinoObject.Add(new JProperty("BlueprintPath", dino.BlueprintPath));

                    dinoArray.Add(dinoObject);
                }
            }
            JObject dinoSaves = new JObject();
            dinoSaves.Add(new JProperty("creatures", dinoArray));
            File.WriteAllText(dinoMapFilename, dinoSaves.ToString(Formatting.None));


            //save structuremap
            var structureMapFilename = Path.Combine(savePath, "structuremap.json");
            JArray structureArray = new JArray();
            if (StructureMap.Count > 0)
            {
                foreach (var structure in StructureMap)
                {
                    JObject structureObject = new JObject();
                    structureObject.Add(new JProperty("ClassName", structure.ClassName));
                    structureObject.Add(new JProperty("FriendlyName", structure.FriendlyName));
                    structureArray.Add(structureObject);
                }
            }
            JObject structureSaved = new JObject();
            structureSaved.Add(new JProperty("structures", structureArray));
            File.WriteAllText(structureMapFilename, structureSaved.ToString(Formatting.None));


            //save itemmap
            var itemMapFilename = Path.Combine(savePath, "itemmap.json");
            JArray itemArray = new JArray();
            if (ItemMap.Count > 0)
            {
                foreach (var item in ItemMap)
                {
                    JObject itemObject = new JObject();
                    itemObject.Add(new JProperty("ClassName", item.ClassName));
                    itemObject.Add(new JProperty("Category", item.Category));
                    itemObject.Add(new JProperty("FriendlyName", item.DisplayName));
                    itemObject.Add(new JProperty("Image", item.Image));

                    itemArray.Add(itemObject);
                }
            }

            JObject itemSaves = new JObject();
            itemSaves.Add(new JProperty("items", itemArray));
            File.WriteAllText(itemMapFilename, itemSaves.ToString(Formatting.None));

            //save mapmarkers
            var mapMarkerFilename = Path.Combine(savePath, "mapmarkers.json");
            JArray markerArray = new JArray();
            if (MapMarkerList.Count > 0)
            {
                foreach (var marker in MapMarkerList.Where(x => x.InGameMarker == false))
                {
                    JObject markerObject = new JObject();
                    markerObject.Add(new JProperty("Map", marker.Map));
                    markerObject.Add(new JProperty("Category", marker.Category));
                    markerObject.Add(new JProperty("Name", marker.Name));
                    markerObject.Add(new JProperty("Image", marker.Image));
                    markerObject.Add(new JProperty("Colour", marker.Colour));
                    markerObject.Add(new JProperty("BorderColour", marker.BorderColour));
                    markerObject.Add(new JProperty("BorderWidth", marker.BorderWidth));
                    markerObject.Add(new JProperty("Lat", marker.Lat));
                    markerObject.Add(new JProperty("Lon", marker.Lon));
                    markerObject.Add(new JProperty("Visible", marker.Displayed));


                    markerArray.Add(markerObject);
                }
            }
            JObject markerFile = new JObject();
            markerFile.Add(new JProperty("markers", markerArray));
            File.WriteAllText(mapMarkerFilename, markerFile.ToString(Formatting.None));

            //save breeding search options
            if (BreedingSearchOptions != null && BreedingSearchOptions.Count > 0)
            {
                string breedingOptionFilename = Path.Combine(AppContext.BaseDirectory, "breedingoptions.json");
                string jsonOptions = JsonConvert.SerializeObject(BreedingSearchOptions);
                File.WriteAllText(breedingOptionFilename, jsonOptions);
            }

            //save missionmaps
            if (MissionMaps != null && MissionMaps.Count > 0)
            {
                string missionMapFilename = Path.Combine(AppContext.BaseDirectory, "missionmap.json");
                string jsonOptions = JsonConvert.SerializeObject(MissionMaps);
                File.WriteAllText(missionMapFilename, jsonOptions);
            }

            //re-load config now saved
            Load();
        }

        public void Load()
        {
            var savePath = AppDomain.CurrentDomain.BaseDirectory;
            var saveFilename = Path.Combine(savePath, "config.json");

            Mode = ViewerModes.Mode_SinglePlayer;
            SelectedFile = "TheIsland.ark";
            SelectedServer = "";
            ClusterFolder = "";

            //load colours

            ColourMap = new List<ColourMap>();
            string colourMapFilename = Path.Combine(savePath, "colours.json");
            if (File.Exists(colourMapFilename))
            {
                string jsonFileContent = File.ReadAllText(colourMapFilename);

                JObject itemFile = JObject.Parse(jsonFileContent);
                JArray itemList = (JArray)itemFile.GetValue("colors");
                foreach (JObject itemObject in itemList)
                {
                    ColourMap item = new ColourMap();
                    item.Id = itemObject.Value<int>("id");
                    item.Hex = itemObject.Value<string>("hex");
                    ColourMap.Add(item);
                }
            }

            //load markers
            MapMarkerList = new List<ContentMarker>();
            string markerFilename = Path.Combine(savePath, "mapmarkers.json");
            if (File.Exists(markerFilename))
            {
                string jsonFileContent = File.ReadAllText(markerFilename);

                JObject markerFile = JObject.Parse(jsonFileContent);
                JArray markerList = (JArray)markerFile.GetValue("markers");
                foreach (JObject markerObject in markerList)
                {
                    ContentMarker mapMarker = new ContentMarker();

                    mapMarker.Map = markerObject.Value<string>("Map");
                    mapMarker.Name = markerObject.Value<string>("Category");
                    mapMarker.Name = markerObject.Value<string>("Name");
                    mapMarker.Colour = markerObject.Value<int>("Colour");
                    mapMarker.BorderColour = markerObject.Value<int>("BorderColour");
                    mapMarker.BorderWidth = markerObject.Value<int>("BorderWidth");
                    mapMarker.Image = markerObject.Value<string>("Image");
                    mapMarker.Lat = markerObject.Value<double>("Lat");
                    mapMarker.Lon = markerObject.Value<double>("Lon");
                    mapMarker.Displayed= markerObject.Value<bool>("Visible");



                    MapMarkerList.Add(mapMarker);
                }
            }


            //load terminal markers
            string structureMarkerFilename = Path.Combine(savePath, "structuremarkers.json");
            if (File.Exists(structureMarkerFilename))
            {
                string jsonFileContent = File.ReadAllText(structureMarkerFilename);

                TerminalMarkers = new List<ASVStructureMarker>();
                JObject markerFile = JObject.Parse(jsonFileContent);
                JArray terminalList = (JArray)markerFile.GetValue("terminals");

                foreach (JObject markerObject in terminalList)
                {
                    ASVStructureMarker mapMarker = new ASVStructureMarker();

                    mapMarker.Map = markerObject.Value<string>("Map");
                    mapMarker.Lat = markerObject.Value<double>("Lat");
                    mapMarker.Lon = markerObject.Value<double>("Lon");
                    mapMarker.X = (float)Math.Round(markerObject.Value<float>("X"), 2);
                    mapMarker.Y = (float)Math.Round(markerObject.Value<float>("Y"), 2);
                    mapMarker.Z = (float)Math.Round(markerObject.Value<float>("Z"), 2);

                    mapMarker.Colour = markerObject.Value<string>("Colour");

                    TerminalMarkers.Add(mapMarker);
                }


                GlitchMarkers = new List<ASVStructureMarker>();
                JArray glitchList = (JArray)markerFile.GetValue("glitches");

                foreach (JObject markerObject in glitchList)
                {
                    ASVStructureMarker mapMarker = new ASVStructureMarker();

                    mapMarker.Map = markerObject.Value<string>("Map");
                    mapMarker.Lat = markerObject.Value<double>("Lat");
                    mapMarker.Lon = markerObject.Value<double>("Lon");
                    mapMarker.X = markerObject.Value<float>("X");
                    mapMarker.Y = markerObject.Value<float>("Y");
                    mapMarker.Z = markerObject.Value<float>("Z");

                    mapMarker.Colour = markerObject.Value<string>("Colour");

                    GlitchMarkers.Add(mapMarker);
                }


            }


            //load item map
            ItemMap = new List<ItemClassMap>();
            string itemMapFilename = Path.Combine(savePath, "itemmap.json");
            if (File.Exists(itemMapFilename))
            {
                string jsonFileContent = File.ReadAllText(itemMapFilename);

                JObject itemFile = JObject.Parse(jsonFileContent);
                JArray itemList = (JArray)itemFile.GetValue("items");
                foreach (JObject itemObject in itemList)
                {
                    ItemClassMap item = new ItemClassMap();
                    item.ClassName = itemObject.Value<string>("ClassName");
                    item.DisplayName = itemObject.Value<string>("FriendlyName");
                    item.Category = itemObject.Value<string>("Category");
                    item.Image = itemObject.Value<string>("Image");
                    ItemMap.Add(item);
                }
            }

            //load structure map
            StructureMap = new List<StructureClassMap>();
            string structureMapFilename = Path.Combine(savePath, "structuremap.json");
            if (File.Exists(structureMapFilename))
            {
                string jsonFileContent = File.ReadAllText(structureMapFilename);

                JObject itemFile = JObject.Parse(jsonFileContent);
                JArray itemList = (JArray)itemFile.GetValue("structures");
                foreach (JObject itemObject in itemList)
                {
                    StructureClassMap item = new StructureClassMap();
                    item.ClassName = itemObject.Value<string>("ClassName");
                    item.FriendlyName = itemObject.Value<string>("FriendlyName");
                    StructureMap.Add(item);
                }
            }

            //load dino map
            DinoMap = new List<DinoClassMap>();
            string dinoMapFilename = Path.Combine(savePath, "creaturemap.json");
            if (File.Exists(dinoMapFilename))
            {
                string jsonFileContent = File.ReadAllText(dinoMapFilename);

                JObject dinoFile = JObject.Parse(jsonFileContent);
                JArray dinoList = (JArray)dinoFile.GetValue("creatures");
                foreach (JObject dinoObject in dinoList)
                {
                    DinoClassMap dino = new DinoClassMap();
                    dino.ClassName = dinoObject.Value<string>("ClassName");
                    dino.FriendlyName = dinoObject.Value<string>("FriendlyName");
                    dino.BlueprintPath = dinoObject.Value<string>("BlueprintPath");

                    DinoMap.Add(dino);
                }
            }

            //load mission maps
            MissionMaps = new List<MissionMap>();
            string missionMapFilename = Path.Combine(savePath, "missionmap.json");
            if (File.Exists(missionMapFilename))
            {
                string jsonFileContent = File.ReadAllText(missionMapFilename);
                MissionMaps = JsonConvert.DeserializeObject<List<MissionMap>>(jsonFileContent); ;
            }

            //load breeding search options
            BreedingSearchOptions = new List<ASVBreedingSearch>();
            string breedingOptionsFilename = Path.Combine(savePath, "breedingoptions.json");
            if (File.Exists(breedingOptionsFilename))
            {
                string jsonFileContent = File.ReadAllText(breedingOptionsFilename);
                BreedingSearchOptions = JsonConvert.DeserializeObject<List<ASVBreedingSearch>>(jsonFileContent);
            }



            ServerList = new List<ServerConfiguration>();
            if (File.Exists(saveFilename))
            {
                //found, load the saved state
                string jsonFileContent = File.ReadAllText(saveFilename);
                configFromJson(jsonFileContent);

                //decrypt server password after reading from disk
                if (EncryptionPassword != null && EncryptionPassword.Length > 0)
                {
                    //decode from base64
                    byte[] passwordBytes = Convert.FromBase64String(EncryptionPassword);
                    this.EncryptionPassword = ASCIIEncoding.ASCII.GetString(passwordBytes);

                    if (ServerList.Count > 0)
                    {
                        foreach (var server in ServerList)
                        {

                            string mapFilename = "theisland.ark";
                            if (server.SaveGamePath.ToLower().EndsWith(".ark"))
                            {

                                if (server.SaveGamePath.Contains("/"))
                                {
                                    mapFilename = server.SaveGamePath.Substring(server.SaveGamePath.LastIndexOf("/") + 1).ToLower();
                                    server.SaveGamePath = server.SaveGamePath.Substring(0, server.SaveGamePath.LastIndexOf("/") + 1);
                                }

                            }
                            else
                            {
                                mapFilename = server.Map;
                            }
                            server.Map = mapFilename.ToLower();
                            if (server.Address.ToLower().Contains("ftp://"))
                            {
                                server.Address = server.Address.Substring(server.Address.IndexOf("ftp://") + 6);
                            }

                            server.Username = DecryptString(server.Username, Convert.FromBase64String(this.IV), this.EncryptionPassword);
                            server.Password = DecryptString(server.Password, Convert.FromBase64String(this.IV), this.EncryptionPassword);
                            if (!string.IsNullOrEmpty(server.RCONPassword))
                            {
                                server.RCONPassword = DecryptString(server.RCONPassword, Convert.FromBase64String(this.IV), this.EncryptionPassword);
                            }
                        }
                    }


                }
                else
                {
                    //create random initial password for this installation
                    Random rnd = new Random();

                    string randomPasswordString = "";
                    for (int charIndex = 0; charIndex < 16; charIndex++)
                    {
                        int nextRand = rnd.Next(32, 126);
                        randomPasswordString += (char)nextRand;
                    }

                    this.EncryptionPassword = randomPasswordString;

                }


            }
            else
            {

                Aes aes = Aes.Create();
                this.IV = Convert.ToBase64String(aes.IV);

                Save();

            }
        }

        private string configToJson()
        {
            JsonSerializer js = new JsonSerializer();
            TextWriter output = new StringWriter();


            using (JsonWriter writer = new JsonTextWriter(output))
            {
                js.Serialize(writer, this);

            }

            return output.ToString();
        }

        private void configFromJson(string jsonMessage)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(ViewerConfiguration));

            using (MemoryStream m = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage)))
            {
                var fileState = ser.ReadObject(m);
                ViewerConfiguration savedState = (ViewerConfiguration)fileState;

                this.EncryptionPassword = savedState.EncryptionPassword;
                if (savedState.IV != null)
                {
                    this.IV = savedState.IV;
                }
                else
                {
                    Aes aes = Aes.Create();
                    this.IV = Convert.ToBase64String(aes.IV);
                }


                this.Mode = savedState.Mode;
                this.SelectedFile = savedState.SelectedFile;
                this.ClusterFolder = savedState.ClusterFolder ?? "";
                this.SelectedServer = savedState.SelectedServer;
                this.Artifacts = savedState.Artifacts;
                this.BeaverDams = savedState.BeaverDams;
                this.DeinoNests = savedState.DeinoNests;
                this.GasVeins = savedState.GasVeins;
                this.OilVeins = savedState.OilVeins;
                this.Obelisks = savedState.Obelisks;
                this.WaterVeins = savedState.WaterVeins;
                this.WyvernNests = savedState.WyvernNests;
                this.DrakeNests = savedState.DrakeNests;
                this.ChargeNodes = savedState.ChargeNodes;
                this.BeeHives = savedState.BeeHives;
                this.PlantZ = savedState.PlantZ;
                this.PlantX = savedState.PlantX;
                this.Glitches = savedState.Glitches;
                this.MagmaNests = savedState.MagmaNests;
                this.UpdateNotificationFile = savedState.UpdateNotificationFile;
                this.UpdateNotificationSingle = savedState.UpdateNotificationSingle;
                this.SortCommandLineExport = savedState.SortCommandLineExport;
                this.ExportInventories = savedState.ExportInventories;
                this.TribeLogColours = new LogColourMap();
                if (savedState.TribeLogColours != null) this.TribeLogColours = savedState.TribeLogColours;
                if (this.TribeLogColours.TextColourMap == null) this.TribeLogColours.TextColourMap = new List<LogTextColourMap>();
                if (savedState.StructureExclusions != null) this.StructureExclusions = savedState.StructureExclusions;

                if(savedState.HighlightColorCryopod !=0) this.HighlightColorCryopod = savedState.HighlightColorCryopod;
                if (savedState.HighlightColorVivarium != 0) this.HighlightColorVivarium= savedState.HighlightColorVivarium;
                if (savedState.HighlightColorUploaded != 0) this.HighlightColorUploaded= savedState.HighlightColorUploaded;


                this.LoadSaveOnStartup = savedState.LoadSaveOnStartup;

                this.HideNoBody = savedState.HideNoBody;
                this.HideNoStructures = savedState.HideNoStructures;
                this.HideNoTames = savedState.HideNoTames;
                this.CommandPrefix = savedState.CommandPrefix;
                this.FtpDownloadMode = savedState.FtpDownloadMode;

                if(savedState.FtpTimeout > 0)
                {
                    this.FtpTimeout = savedState.FtpTimeout;
                }               

                this.FtpLoadMode = savedState.FtpLoadMode;
                if (savedState.Windows != null) this.Windows = savedState.Windows;
                this.StoredTames = savedState.StoredTames;
                this.Zoom = savedState.Zoom;
                this.SplitterDistance = savedState.SplitterDistance;
                this.ServerList = savedState.ServerList;
                this.OfflineList = savedState.OfflineList?? new List<OfflineFileConfiguration>();
                if(savedState.ProfileDayLimit!=0) this.ProfileDayLimit = savedState.ProfileDayLimit;
                if (savedState.MaxCores != 0) this.MaxCores = savedState.MaxCores;
                savedState = null;
            }

        }



        private string EncryptString(string plainText, byte[] currentIV, string password)
        {

            byte[] passBytes = Encoding.UTF8.GetBytes(password);

            return ViewerEncryption.Encrypt(plainText, Convert.ToBase64String(currentIV), Convert.ToBase64String(passBytes));
            
        }

        private string DecryptString(string encryptedText, byte[] currentIV, string password)
        {
            ViewerEncryption enc = new ViewerEncryption();

            byte[] passBytes = Encoding.UTF8.GetBytes(password);

            return ViewerEncryption.Decrypt(encryptedText, Convert.ToBase64String(currentIV), Convert.ToBase64String(passBytes));
        }



    }



}
