using ArkViewer.Configuration;
using ARKViewer.Configuration;
using ARKViewer.Models;
using ARKViewer.Models.NameMap;
using ASVPack;
using ASVPack.Models;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NLog;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace ARKViewer
{
    static class Program
    {


        static Dictionary<string, int> ItemImageKeyMap = new Dictionary<string, int>();
        static Dictionary<string, int> MarkerImageKeyMap = new Dictionary<string, int>();

        public static ContentMapPack MapPack = new ContentMapPack();
        public static ImageList ItemImageList { get; set; } = new ImageList();
        public static ImageList MarkerImageList { get; set; } = new ImageList();
        public static string ItemImageFolder { get; set; } = "";
        public static string MarkerImageFolder { get; set; } = "";
        public static string LastLoadedSaveFilename { get; set; } = "";
        public static ContentPack LoadedPack { get; set; } = null;
        public static ViewerConfiguration ProgramConfig { get; set; }
        public static ApiConfiguration ApiConfig { get; set; }
        public static List<RCONTabCommands> TabCommands { get; set; } = new List<RCONTabCommands>();

        public static string GetSteamFolder()
        {
            string directoryCheck = Program.ProgramConfig.ArkSavedGameFolder;

            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Valve\Steam");
                if (key == null) return "";

                string steamRoot = key.GetValue("SteamPath", "").ToString();

                if (steamRoot != null && steamRoot.Length > 0)
                {
                    steamRoot = steamRoot.Replace(@"/", @"\");
                    steamRoot = Path.Combine(steamRoot, @"steamapps\libraryfolders.vdf");
                    if (File.Exists(steamRoot))
                    {
                        string fileText = File.ReadAllText(steamRoot).Replace("\"LibraryFolders\"", "");

                        foreach (string line in fileText.Split('\n'))
                        {
                            if (line.Contains("\"path\""))
                            {
                                string lineContent = line.Substring(line.IndexOf("path") + 4).Trim().Replace("\t", "");
                                

                                directoryCheck = lineContent.Replace("\"", "").Replace(@"\\", @"\") + @"\SteamApps\Common\ARK\ShooterGame\Saved\";
                                if (Directory.Exists(directoryCheck))
                                {
                                    Program.ProgramConfig.ArkSavedGameFolder = directoryCheck;
                                    break;
                                }

                            }
                        }
                    }
                }
            }
            catch
            {
                //permission access to registry or unavailable?

            }

            return directoryCheck;
        }

        public static ILogger LogWriter { get; internal set; } = LogManager.GetCurrentClassLogger();


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.DpiUnawareGdiScaled);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            LogWriter.Trace("BEGIN Main()");

            //param setup
            string appFolder = AppContext.BaseDirectory;
            string logFilename = Path.Combine(appFolder, @"ASV.log");

            ItemImageFolder = Path.Combine(appFolder, @"images\icons\");
            MarkerImageFolder = Path.Combine(appFolder, @"images\");

            if (!Directory.Exists(MarkerImageFolder)) Directory.CreateDirectory(MarkerImageFolder);
            if (!Directory.Exists(ItemImageFolder)) Directory.CreateDirectory(ItemImageFolder);

            //load config
            ProgramConfig = new ViewerConfiguration();

            //support quoted command line arguments which doesn't seem to be supported with Environment.GetCommandLineArgs() 
            string[] commandArguments = Environment.CommandLine.Trim().Split('"')
                                .Select((element, index) => index % 2 == 0  // If even index
                                                      ? element.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)  // Split the item
                                                      : new string[] { element })  // Keep the entire item
                                .SelectMany(element => element).ToArray();


            commandArguments = commandArguments.Where(a => string.IsNullOrEmpty(a) == false).ToArray();

            if (commandArguments != null && commandArguments.Length > 1)
            {
                LogWriter.Info($"Running in command line mode (v{Application.ProductVersion}).");
                ExportWithCommandLineOptions(commandArguments);
            }
            else
            {
                LogWriter.Info($"Running in visual mode (v{Application.ProductVersion}).");
                Application.EnableVisualStyles();
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.SetCompatibleTextRenderingDefault(false);

                if (!File.Exists(ProgramConfig.SelectedFile))
                {
                    using (frmSettings settings = new frmSettings())
                    {
                        if (settings.ShowDialog() != DialogResult.OK)
                        {
                            LogWriter.Info("No game file selected, aborting.");
                            return;
                        }
                    }
                }

                string rconCommandListFilename = Path.Combine(AppContext.BaseDirectory, "commands.json");
                if(File.Exists(rconCommandListFilename))
                {
                    TabCommands = new List<RCONTabCommands>();

                    string fileContent = File.ReadAllText(rconCommandListFilename);
                    JObject jsonTabContainer = JObject.Parse(fileContent);

                    JArray tabList = (JArray)jsonTabContainer.GetValue("tabs");
                    foreach (JObject tabObject in tabList)
                    {
                        var tabCommands = JsonConvert.DeserializeObject<RCONTabCommands>(tabObject.ToString());
                        TabCommands.Add(tabCommands);
                    }
                }

                frmViewer mainForm = new frmViewer();
                if (ProgramConfig.LoadSaveOnStartup)
                {
                    mainForm.UpdateProgress("Loading content pack...");
                }
            
                mainForm.Show();
                mainForm.BringToFront();
                Application.DoEvents();
                if (ProgramConfig.LoadSaveOnStartup)
                {
                    mainForm.LoadContent(ProgramConfig.SelectedFile, false);
                }                

                Application.Run(mainForm);
            }

            LogWriter.Trace("END Main()");
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;

            LogWriter.Error(ex, "UnhandledException");

            string traceLog = ex.StackTrace;
            string errorMessage = ex.Message;

            frmErrorReport report = new frmErrorReport(errorMessage, traceLog);

            report.ShowDialog();
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            LogWriter.Error(e.Exception, "ThreadException");

            Exception ex = e.Exception;
            string traceLog = ex.StackTrace;
            string errorMessage = ex.Message;

            frmErrorReport report = new frmErrorReport(errorMessage, traceLog);
            report.ShowDialog();
        }

        private static void ExportWithCommandLineOptions(string[] commandArguments)
        {
            LogWriter.Trace("BEGIN ExportWithCommandLineOptions()");

            string logFilename = Path.Combine(AppContext.BaseDirectory, @"ASV.log");

            //used when exporting ASV pack data
            string commandOptionCheck = commandArguments[1].ToString().Trim().ToLower();
            string exportFilePath = Path.Combine(AppContext.BaseDirectory, @"Export\");
            string exportFilename = Path.Combine(exportFilePath, "");

            //arguments provided, export and exit
            LogWriter.Info($"ASV Command Line Started with {commandArguments.Length} parameters.");

            int argIndex = 0;
            foreach (string arg in commandArguments)
            {
                LogWriter.Debug($"CommandLineArg-{argIndex} = {arg}");
                argIndex++;
            }

            //command line, load save game data for export
            string inputFilename = "";
            if (commandArguments.Length > 2)
            {
                //config specified
                inputFilename = commandArguments[2].ToString().Trim().Replace("\"", "");
            }

            if (commandArguments.Length > 3)
            {
                exportFilename = commandArguments[3].ToString().Trim().Replace("\"", "");
                exportFilePath = Path.GetDirectoryName(exportFilename);
            }

            string clusterFolder = "";
            if (commandArguments.Length > 4)
            {
                clusterFolder = commandArguments[3].ToString().Trim().Replace("\"", "");
                exportFilename = commandArguments[4].ToString().Trim().Replace("\"", "");
                exportFilePath = Path.GetDirectoryName(exportFilename);
            }

            try
            {
                switch (commandOptionCheck)
                {
                    case "pack":
                        LogWriter.Info($"Exporting ASV pack for coniguration: {inputFilename}");
                        
                        ExportCommandLinePack(inputFilename);

                        break;

                    case "json":
                        LogWriter.Info($"Exporting JSON for configuration: {inputFilename}");

                        ExportCommandLine(inputFilename);

                        break;
                    default:
                        //direct command line export
                        if (!File.Exists(inputFilename))
                        {
                            LogWriter.Info($"File Not Found for: {inputFilename}");
                            
                            Environment.ExitCode = -1;
                            break;
                        }

                        ContentContainer container = new ContentContainer();

                        container.LoadSaveGame(inputFilename, "", clusterFolder,30, ProgramConfig.MaxCores);
                        ASVDataManager exportManger = new ASVDataManager(container);

                        switch (commandOptionCheck)
                        {
                            case "all":
                                LogWriter.Info($"Exporting JSON (all) for: {inputFilename}");

                                exportManger.ExportAll(exportFilePath);
                                break;
                            case "map":
                                LogWriter.Info($"Exporting JSON (map) for: {inputFilename}");

                                exportManger.ExportMapStructures(exportFilePath);
                                break;

                            case "structures":
                                LogWriter.Info($"Exporting JSON (structures) for: {inputFilename}");

                                exportManger.ExportPlayerStructures(exportFilename);
                                break;
                            case "logs":
                                LogWriter.Info($"Exporting JSON (tribe logs) for: {inputFilename}");
                                exportManger.ExportPlayerTribeLogs(exportFilename);

                                break;
                            case "tribes":
                                LogWriter.Info($"Exporting JSON (tribes) for: {inputFilename}");

                                exportManger.ExportPlayerTribes(exportFilename);
                                break;
                            case "players":
                                LogWriter.Info($"Exporting JSON (players) for: {inputFilename}");

                                exportManger.ExportPlayers(exportFilename);
                                break;
                            case "wild":
                                LogWriter.Info($"Exporting JSON (wild) for: {inputFilename}");

                                exportManger.ExportWild(exportFilename);
                                break;
                            case "tamed":
                                LogWriter.Info($"Exporting JSON (tamed) for: {inputFilename}");

                                exportManger.ExportTamed(exportFilename);
                                break;
                        }
                        exportManger = null;

                        LogWriter.Info($"Completed export for: {inputFilename}");



                        break;
                }

                Environment.ExitCode = 0;
            }
            catch (Exception ex)
            {

                LogWriter.Error(ex,"ExportWithCommandLineOptions failed");

                Environment.ExitCode = -1;
            }


            LogWriter.Trace("END ExportWithCommandLineOptions()");

            Application.Exit();

        }

        private static void ExportCommandLinePack(string configFilename)
        {
            LogWriter.Trace("BEGIN ExportCommandLinePack()");
            //defaults
            string mapFilename = "";
            string exportFilename = Path.Combine(AppContext.BaseDirectory, @"Export\ASV_ContentPack.asv");
            string clusterFolder = "";
            long tribeId = 0;
            long playerId = 0;
            decimal filterLat = 50;
            decimal filterLon = 50;
            decimal filterRad = 250;
            bool packStructureLocations = true;
            bool packStructureContent = true;
            bool packDroppedItems = true;
            bool packTribesPlayers = true;
            bool packTamed = true;
            bool packWild = true;
            bool packPlayerStructures = true;


            if (File.Exists(configFilename))
            {
                //config found, load settings from file.
                LogWriter.Debug($"Reading pack export configuation.");
                string packConfigText = File.ReadAllText(configFilename);
                try
                {
                    JObject packConfig = JObject.Parse(packConfigText);

                    mapFilename = packConfig.Property("mapFilename") == null ? "" : packConfig.Property("mapFilename").Value.ToString();

                    exportFilename = packConfig.Property("tribeId") == null ? "" : packConfig.Property("exportFilename").Value.ToString();
                    tribeId = packConfig.Property("exportFilename") == null ? 0 : (long)packConfig.Property("tribeId").Value;
                    playerId = packConfig.Property("playerId") == null ? 0 : (long)packConfig.Property("playerId").Value;
                    filterLat = packConfig.Property("filterLat") == null ? 50 : (decimal)packConfig.Property("filterLat").Value;
                    filterLon = packConfig.Property("filterLon") == null ? 50 : (decimal)packConfig.Property("filterLon").Value;
                    filterRad = packConfig.Property("filterRad") == null ? 250 : (decimal)packConfig.Property("filterRad").Value;
                    packStructureLocations = packConfig.Property("packStructureLocations") == null ? true : (bool)packConfig.Property("packStructureLocations").Value;
                    packStructureContent = packConfig.Property("packStructureContent") == null ? true : (bool)packConfig.Property("packStructureContent").Value;
                    packDroppedItems = packConfig.Property("packDroppedItems") == null ? true : (bool)packConfig.Property("packDroppedItems").Value;
                    packTribesPlayers = packConfig.Property("packTribesPlayers") == null ? true : (bool)packConfig.Property("packTribesPlayers").Value;
                    packTamed = packConfig.Property("packTamed") == null ? true : (bool)packConfig.Property("packTamed").Value;
                    packWild = packConfig.Property("packWild") == null ? true : (bool)packConfig.Property("packWild").Value;
                    packPlayerStructures = packConfig.Property("packPlayerStructures") == null ? true : (bool)packConfig.Property("packPlayerStructures").Value;

                    clusterFolder = packConfig.Property("clusterFolder") == null ? "" : packConfig.Property("clusterFolder").Value.ToString();

                }
                catch
                {
                    LogWriter.Debug($"Unable to parse pack export configuration.");

                    //bad file data, ignore
                }
            }


            //ensure folder exists
            string exportFolder = Path.GetDirectoryName(exportFilename);
            if (exportFolder.Length == 0) exportFolder = Path.Combine(AppContext.BaseDirectory, @"Export\");
            if (!Directory.Exists(exportFolder)) Directory.CreateDirectory(exportFolder);

            //ensure filename set, and ends with .asv
            if (exportFilename.Length == 0) exportFilename = Path.Combine(exportFolder, "ASV_ContentPack.asv");
            if (!exportFilename.ToLower().EndsWith("asv")) exportFilename += ".asv";

            //create pack and export
            ContentContainer exportPack = new ContentContainer();

            LogWriter.Debug($"Loading .ark save file: {mapFilename}");
            
            exportPack.LoadSaveGame( mapFilename, "", clusterFolder,30);

            LogWriter.Debug($"Creating ContentPack");
            ContentPack pack = new ContentPack(exportPack, tribeId, playerId, filterLat, filterLon, filterRad, packStructureLocations, packStructureContent, packTribesPlayers, packTamed, packWild, packPlayerStructures, packDroppedItems);

            LogWriter.Debug($"Exporting ContentPack");
            pack.ExportPack(exportFilename);


            LogWriter.Trace("END ExportCommandLinePack()");
        }

        private static void ExportCommandLine(string configFilename)
        {
            LogWriter.Trace("BEGIN ExportCommandLine()");

            long tribeId = 0;
            long playerId = 0;
            decimal filterLat = 50;
            decimal filterLon = 50;
            decimal filterRad = 250;

            string tribeExportFilename = Path.Combine(AppContext.BaseDirectory, @"Export\ASV_Export_Tribes.json");
            string tribeImageFilename = Path.Combine(AppContext.BaseDirectory, @"Export\ASV_Export_Tribes.png");
            bool tribeStructures = true;
            bool mapStructureContent = true;
            bool tribePlayers = true;
            bool tribeTames = true;

            string structureExportFilename = Path.Combine(AppContext.BaseDirectory, @"Export\ASV_Export_Structures.json");
            string structureImageFilename = Path.Combine(AppContext.BaseDirectory, @"Export\ASV_Export_Structures.png");
            string structureClassName = "";

            string playerExportFilename = Path.Combine(AppContext.BaseDirectory, @"Export\ASV_Export_Players.json");
            string playerImageFilename = Path.Combine(AppContext.BaseDirectory, @"Export\ASV_Export_Players.png");

            string wildExportFilename = Path.Combine(AppContext.BaseDirectory, @"Export\ASV_Export_Wild.json");
            string wildImageFilename = Path.Combine(AppContext.BaseDirectory, @"Export\ASV_Export_Wild.png");
            string wildClassName = "";
            int wildMinLevel = 0;
            int wildMaxLevel = 999;


            string tamedExportFilename = Path.Combine(AppContext.BaseDirectory, @"Export\ASV_Export_Tamed.json");
            string tamedImageFilename = Path.Combine(AppContext.BaseDirectory, @"Export\ASV_Export_Tamed.png");
            string tamedClassName = "";

            string mapFilename = Program.ProgramConfig.SelectedFile;
            string clusterFolder = Program.ProgramConfig.ClusterFolder;

            if (File.Exists(configFilename))
            {
                LogWriter.Debug($"Reading export configuation.");
                string configText = File.ReadAllText(configFilename);
                try
                {
                    JObject packConfig = JObject.Parse(configText);

                    mapFilename = packConfig.Property("mapFilename") == null ? "" : packConfig.Property("mapFilename").Value.ToString();

                    //if no save file provided, use ProgramConfig
                    if (mapFilename.Length == 0) mapFilename = Program.ProgramConfig.SelectedFile;


                    // parse filters for export options
                    tribeId = packConfig.Property("tribeId") == null ? 0 : (long)packConfig.Property("tribeId").Value;
                    playerId = packConfig.Property("playerId") == null ? 0 : (long)packConfig.Property("playerId").Value;
                    filterLat = packConfig.Property("filterLat") == null ? 50 : (decimal)packConfig.Property("filterLat").Value;
                    filterLon = packConfig.Property("filterLon") == null ? 50 : (decimal)packConfig.Property("filterLon").Value;
                    filterRad = packConfig.Property("filterRad") == null ? 250 : (decimal)packConfig.Property("filterRad").Value;
                    mapStructureContent = packConfig.Property("structureContent") == null ? false : (bool)packConfig.Property("structureContent").Value;

                    //Tribes
                    JObject exportTribes = (JObject)packConfig["exportTribes"];
                    if (exportTribes != null)
                    {
                        tribeExportFilename = exportTribes.Property("jsonFilename") == null ? "" : (string)exportTribes.Property("jsonFilename").Value;
                        tribeImageFilename = exportTribes.Property("imageFilename") == null ? "" : (string)exportTribes.Property("imageFilename").Value;
                        tribeStructures = exportTribes.Property("addStructures") == null ? true : (bool)exportTribes.Property("addStructures").Value;
                        tribePlayers = exportTribes.Property("addPlayers") == null ? true : (bool)exportTribes.Property("addPlayers").Value;
                        tribeTames = exportTribes.Property("addTames") == null ? true : (bool)exportTribes.Property("addTames").Value;
                    }

                    //Structures
                    JObject exportStructures = (JObject)packConfig["exportStructures"];
                    if (exportStructures != null)
                    {
                        structureExportFilename = exportStructures.Property("jsonFilename") == null ? "" : exportStructures.Property("jsonFilename").Value.ToString();
                        structureImageFilename = exportStructures.Property("imageFilename") == null ? "" : exportStructures.Property("imageFilename").Value.ToString();
                        structureClassName = exportStructures.Property("className") == null ? "" : exportStructures.Property("className").Value.ToString();
                    }

                    //Players
                    JObject exportPlayers = (JObject)packConfig["exportPlayers"];
                    if (exportPlayers != null)
                    {
                        playerExportFilename = exportPlayers.Property("jsonFilename") == null ? "" : exportPlayers.Property("jsonFilename").Value.ToString();
                        playerImageFilename = exportPlayers.Property("imageFilename") == null ? "" : exportPlayers.Property("imageFilename").Value.ToString();

                    }

                    //Wilds
                    JObject exportWild = (JObject)packConfig["exportWild"];
                    if (exportWild != null)
                    {
                        wildExportFilename = exportWild.Property("jsonFilename") == null ? "" : exportWild.Property("jsonFilename").Value.ToString();
                        wildImageFilename = exportWild.Property("imageFilename") == null ? "" : exportWild.Property("imageFilename").Value.ToString();
                        wildClassName = exportWild.Property("className") == null ? "" : exportWild.Property("className").Value.ToString();
                        wildMinLevel = exportWild.Property("minLevel") == null ? 0 : (int)exportWild.Property("minLevel").Value;
                        wildMaxLevel = exportWild.Property("maxLevel") == null ? 0 : (int)exportWild.Property("maxLevel").Value;

                    }

                    //Tamed
                    JObject exportTamed = (JObject)packConfig["exportTamed"];
                    if (exportTamed != null)
                    {
                        tamedExportFilename = exportTamed.Property("jsonFilename") == null ? "" : exportTamed.Property("jsonFilename").Value.ToString();
                        tamedImageFilename = exportTamed.Property("imageFilename") == null ? "" : exportTamed.Property("imageFilename").Value.ToString();
                        tamedClassName = exportTamed.Property("className") == null ? "" : exportTamed.Property("className").Value.ToString();
                    }

                }
                catch
                {
                    //bad file data, ignore
                }
            }

            //load game data
            if (!File.Exists(mapFilename))
            {
                return;
            }

            //load everything
            ContentContainer exportContainer = new ContentContainer();
            LogWriter.Debug($"Loading .ark save file.");
            
            exportContainer.LoadSaveGame(mapFilename, "", clusterFolder,30);

            //filter a pack for export
            LogWriter.Debug($"Loading ContentPack.");
            ContentPack filteredPack = new ContentPack(exportContainer, tribeId, playerId, filterLat, filterLon, filterRad, true, mapStructureContent, tribePlayers, tribeTames, true, tribeStructures, false);

            //load manager from filtered pack
            LogWriter.Debug($"Creating filtered ContentPack.");
            ASVDataManager exportManger = new ASVDataManager(filteredPack);

            //Export tribes
            if (tribeExportFilename.Length > 0)
            {
                string exportFolder = Path.GetDirectoryName(tribeExportFilename);
                if (!Directory.Exists(exportFolder)) Directory.CreateDirectory(exportFolder);

                LogWriter.Info($"Exporting Tribes.");
                exportManger.ExportPlayerTribes(tribeExportFilename);
            }
            if (tribeImageFilename.Length > 0)
            {
                string exportFolder = Path.GetDirectoryName(tribeImageFilename);
                if (!Directory.Exists(exportFolder)) Directory.CreateDirectory(exportFolder);
                LogWriter.Info($"Exporting Tribes Image.");

                var image = exportManger.GetMapImageTribes(tribeId, tribeStructures, tribePlayers, tribeTames, new List<Tuple<float, float>>(), new ASVStructureOptions(), new List<ContentMarker>());
                if (image != null)
                {
                    image.Save(tribeImageFilename);
                }
            }




            //Structures
            if (structureExportFilename.Length > 0)
            {
                string exportFolder = Path.GetDirectoryName(structureExportFilename);
                if (!Directory.Exists(exportFolder)) Directory.CreateDirectory(exportFolder);
                LogWriter.Info($"Exporting Structures.");
                exportManger.ExportPlayerStructures(structureExportFilename);
            }

            if (structureImageFilename.Length > 0)
            {
                string exportFolder = Path.GetDirectoryName(structureImageFilename);
                if (!Directory.Exists(exportFolder)) Directory.CreateDirectory(exportFolder);
                LogWriter.Info($"Exporting Structures Image.");
                var image = exportManger.GetMapImagePlayerStructures(structureImageFilename, tribeId, playerId, new List<Tuple<float, float>>(), new ASVStructureOptions(), new List<ContentMarker>(), "");
                if (image != null)
                {
                    image.Save(structureImageFilename);
                }
            }



            //Export Players
            if (playerExportFilename.Length > 0)
            {
                string exportFolder = Path.GetDirectoryName(playerExportFilename);
                if (!Directory.Exists(exportFolder)) Directory.CreateDirectory(exportFolder);
                LogWriter.Info($"Exporting Players.");
                exportManger.ExportPlayers(playerExportFilename);
            }

            if (playerImageFilename.Length > 0)
            {
                string exportFolder = Path.GetDirectoryName(playerImageFilename);
                if (!Directory.Exists(exportFolder)) Directory.CreateDirectory(exportFolder);
                LogWriter.Info($"Exporting Players Image.");
                var image = exportManger.GetMapImagePlayers(tribeId, playerId, new List<Tuple<float, float>>(), new ASVStructureOptions(), new List<ContentMarker>(), "");
                if (image != null)
                {
                    image.Save(playerImageFilename);
                }
            }

            //Export Wild
            if (wildExportFilename.Length > 0)
            {
                string exportFolder = Path.GetDirectoryName(wildExportFilename);
                if (!Directory.Exists(exportFolder)) Directory.CreateDirectory(exportFolder);
                LogWriter.Info($"Exporting Wilds.");
                exportManger.ExportWild(wildExportFilename);
            }
            if (wildImageFilename.Length > 0)
            {
                string exportFolder = Path.GetDirectoryName(wildImageFilename);
                if (!Directory.Exists(exportFolder)) Directory.CreateDirectory(exportFolder);
                LogWriter.Info($"Exporting Wilds Image.");
                var image = exportManger.GetMapImageWild(wildClassName, "", wildMinLevel, wildMaxLevel, (float)filterLat, (float)filterLon, (float)filterRad,new List<Tuple<float, float>>(), new ASVStructureOptions(), new List<ContentMarker>(), "");
                if (image != null)
                {
                    image.Save(tamedImageFilename);
                }
            }

            //Export tamed
            if (tamedExportFilename.Length > 0)
            {
                string exportFolder = Path.GetDirectoryName(tamedExportFilename);
                if (!Directory.Exists(exportFolder)) Directory.CreateDirectory(exportFolder);
                LogWriter.Info($"Exporting Tames.");
                exportManger.ExportTamed(tamedExportFilename);
            }
            if (tamedImageFilename.Length > 0)
            {
                string exportFolder = Path.GetDirectoryName(tamedImageFilename);
                if (!Directory.Exists(exportFolder)) Directory.CreateDirectory(exportFolder);
                LogWriter.Info($"Exporting Tames Image.");
                var image = exportManger.GetMapImageTamed(tamedClassName, "", 0, tribeId, playerId, new List<Tuple<float, float>>(), new ASVStructureOptions(), new List<ContentMarker>(), "");
                if (image != null)
                {
                    image.Save(tamedImageFilename);
                }
            }
            
            LogWriter.Trace("END ExportCommandLine()");
        }


        public static int GetItemImageIndex(string itemImageFilename)
        {
            ItemImageKeyMap.TryGetValue(itemImageFilename, out int imageIndex);
            return imageIndex;
        }

        public static int GetMarkerImageIndex(string markerImageFilename)
        {
            MarkerImageKeyMap.TryGetValue(markerImageFilename, out int imageIndex);
            return imageIndex;
        }
        
        public static Color IdealTextColor(Color bg)
        {
            int nThreshold = 105;
            int bgDelta = Convert.ToInt32((bg.R * 0.299) + (bg.G * 0.587) +
                                          (bg.B * 0.114));

            Color foreColor = (255 - bgDelta < nThreshold) ? Color.Black : Color.White;
            return foreColor;
        }


        public class ArkItemQuality
        {
            public Color QualityColor;
            public string QualityName;
            public float QualityRandomMultiplierThreshold;
            public float CraftingXPMultiplier;
            public float RepairingXPMultiplier;
            public float CraftingResourceRequirementsMultiplier;
        };

        static List<ArkItemQuality> ItemQualityDefinitions { get; set; } = new List<ArkItemQuality>()
        {
            new ArkItemQuality()
            {
                QualityColor = ControlPaint.LightLight(Color.FromArgb(179, 179, 179)),
                QualityName = "Primitive",
                QualityRandomMultiplierThreshold = 1,
                CraftingXPMultiplier = 1,
                RepairingXPMultiplier = 1,
                CraftingResourceRequirementsMultiplier = 1
            },
            new ArkItemQuality()
            {
                QualityColor = ControlPaint.LightLight(Color.FromArgb(51, 255, 51)),
                QualityName = "Ramshackle",
                QualityRandomMultiplierThreshold = 1.25f,
                CraftingXPMultiplier = 2.0f,
                RepairingXPMultiplier = 2.0f,
                CraftingResourceRequirementsMultiplier = 1.333333f
            },
            new ArkItemQuality()
            {
                QualityColor = ControlPaint.Light(Color.FromArgb(51, 76, 255)),
                QualityName = "Apprentice",
                QualityRandomMultiplierThreshold = 2.5f,
                CraftingXPMultiplier = 3.0f,
                RepairingXPMultiplier = 3.0f,
                CraftingResourceRequirementsMultiplier = 1.666667f
            },
            new ArkItemQuality()
            {
                QualityColor = ControlPaint.LightLight(Color.FromArgb(127, 51, 255)),
                QualityName = "Journeyman",
                QualityRandomMultiplierThreshold = 4.5f,
                CraftingXPMultiplier = 4.0f,
                RepairingXPMultiplier = 4.0f,
                CraftingResourceRequirementsMultiplier = 2.0f
            },
            new ArkItemQuality()
            {
                QualityColor = ControlPaint.LightLight(Color.FromArgb(255, 243, 25)),
                QualityName = "Mastercraft",
                QualityRandomMultiplierThreshold = 7f,
                CraftingXPMultiplier = 5.0f,
                RepairingXPMultiplier = 5.0f,
                CraftingResourceRequirementsMultiplier = 2.5f
            },
            new ArkItemQuality()
            {
                QualityColor = ControlPaint.LightLight(Color.FromArgb( 0, 255, 255)),
                QualityName = "Ascendant",
                QualityRandomMultiplierThreshold = 10f,
                CraftingXPMultiplier = 6.0f,
                RepairingXPMultiplier = 6.0f,
                CraftingResourceRequirementsMultiplier = 3.5f
            }

        };
        public static ArkItemQuality GetQualityByRating(float itemRating)
        {
            foreach (var quality in ItemQualityDefinitions.OrderByDescending(o => o.QualityRandomMultiplierThreshold))
            {
                if (itemRating >= quality.QualityRandomMultiplierThreshold)
                {
                    return quality;
                }
            }

            return ItemQualityDefinitions.OrderBy(o=>o.CraftingResourceRequirementsMultiplier).First();
        }


    }
}
