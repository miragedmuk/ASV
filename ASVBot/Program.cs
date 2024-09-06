using ASVBot.Commands;
using ASVBot.Config;
using ASVBot.Data;
using ASVPack;
using ASVPack.Models;
using DSharpPlus;
using DSharpPlus.SlashCommands;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ASVBot
{
    internal class Program
    {
        public static ContentContainer arkPack = new ContentContainer();
        private static BotConfig config = new BotConfig();
        private static List<IClassMap> classMaps = new List<IClassMap>();
        private static DrawingContainer graphicsContainer = null;

        static async Task Main(string[] args)
        {
            var configFilename = Path.Combine(AppContext.BaseDirectory, "botconfig.json");
            if(!File.Exists(configFilename))
            {
                Console.WriteLine("Unable to locate botconfig.json.");
                Console.WriteLine("Would you like to specify settings now? (Y/N)");
                var keyEntered = Console.ReadKey();
                if(keyEntered.KeyChar.ToString().Equals("y", StringComparison.InvariantCultureIgnoreCase))
                {
                    BotConfig newConfig = new BotConfig();

                    Console.WriteLine("Please provide ARK filename:");
                    var filenameProvided = Console.ReadLine();
                    
                    //check main save file exists
                    if(!File.Exists(filenameProvided))
                    {
                        Console.WriteLine("Unable to continue.  No config settings available.");
                        Environment.Exit(-1);
                        return;
                    }

                    newConfig.ArkSaveFile = filenameProvided;

                    string clusterFolder = string.Empty;
                    Console.WriteLine("Is this save part of a cluster? (Y/N)");
                    if(keyEntered.KeyChar.ToString().Equals("y", StringComparison.InvariantCultureIgnoreCase))
                    {
                        bool tryAgain = true;
                        while(tryAgain)
                        {
                            Console.WriteLine("Please provide shared Cluster folder location:");
                            var clusterFolderProvided = Console.ReadLine();
                            //check cluster folder exists
                            if (Directory.Exists(clusterFolderProvided))
                            {
                                clusterFolder = clusterFolderProvided;
                                tryAgain = false;
                            }
                            else
                            {
                                Console.WriteLine("Unable to locate cluster folder. Try again? (Y/N)");
                                tryAgain = keyEntered.KeyChar.ToString().Equals("y", StringComparison.InvariantCultureIgnoreCase);
                            }
                        }
                    }
                    newConfig.ArkClusterFolder = clusterFolder;

                    Console.WriteLine("Please provide your Discord bot token:");
                    var botTokenProvided = Console.ReadLine();
                    newConfig.DiscordBotToken = botTokenProvided;


                    bool getServerId = true;

                    while (getServerId)
                    {
                        Console.WriteLine("Please provide your Discord server channel id:");
                        var serverIdProvided = Console.ReadLine();
                        if (!long.TryParse(serverIdProvided, out var serverId))
                        {
                            Console.WriteLine("Unable to parse channel id as a number. Try again? (Y/N)");
                            getServerId = keyEntered.KeyChar.ToString().Equals("y", StringComparison.InvariantCultureIgnoreCase);
                        }
                        else
                        {
                            newConfig.DiscordServerId = serverId;
                            getServerId = false;
                        }

                    }

                    if (newConfig.DiscordServerId != 0)
                    {
                        newConfig.Save();
                    }
                    else
                    {
                        Console.WriteLine("Unable to continue. One or more values were not provided to create a new config file.");
                        Environment.Exit(-1);
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Unable to continue.  No config settings available.");
                    Environment.Exit(-1);
                    return;
                }
            }

            classMaps = new List<IClassMap>();
            var creatureMapConfigFilename = Path.Combine(AppContext.BaseDirectory, "creaturemap.json");
            if (File.Exists(creatureMapConfigFilename))
            {
                string jsonFileContent = File.ReadAllText(creatureMapConfigFilename);

                JObject dinoFile = JObject.Parse(jsonFileContent);
                JArray dinoList = (JArray)dinoFile.GetValue("creatures");
                if(dinoList!= null)
                {
                    foreach (JObject dinoObject in dinoList)
                    {
                        if (dinoObject != null)
                        {
                            IClassMap dino = new ClassMap();
                            dino.ClassName = dinoObject.Value<string>("ClassName")??"";
                            dino.FriendlyName = dinoObject.Value<string>("FriendlyName")??"";
                            classMaps.Add(dino);
                        }
                    }
                }               

            }

            var structureMapConfigFilename = Path.Combine(AppContext.BaseDirectory, "structuremap.json");
            if (File.Exists(structureMapConfigFilename))
            {

                string jsonFileContent = File.ReadAllText(structureMapConfigFilename);

                JObject structureFile = JObject.Parse(jsonFileContent);
                JArray structureList = (JArray)structureFile.GetValue("structures");
                if (structureList != null)
                {
                    foreach (JObject structureObject in structureList)
                    {
                        if (structureObject != null)
                        {
                            IClassMap structureMap = new ClassMap();
                            structureMap.ClassName = structureObject.Value<string>("ClassName") ?? "";
                            structureMap.FriendlyName = structureObject.Value<string>("FriendlyName") ?? "";
                            classMaps.Add(structureMap);
                        }
                    }
                }

            }

            var itemMapConfigFilename = Path.Combine(AppContext.BaseDirectory, "itemmap.json");
            if (File.Exists(itemMapConfigFilename))
            {

                string jsonFileContent = File.ReadAllText(itemMapConfigFilename);

                JObject itemFile = JObject.Parse(jsonFileContent);
                JArray itemList = (JArray)itemFile.GetValue("items");
                if (itemList != null)
                {
                    foreach (JObject itemObject in itemList)
                    {
                        if (itemObject != null)
                        {
                            IClassMap itemMap = new ClassMap();
                            itemMap.ClassName = itemObject.Value<string>("ClassName") ?? "";
                            itemMap.FriendlyName = itemObject.Value<string>("FriendlyName") ?? "";
                            classMaps.Add(itemMap);
                        }
                    }
                }

            }

            config.Load();

            if(!File.Exists(config.ArkSaveFile))
            {
                Console.WriteLine("No arkSaveFile specified in botconfig.json.");
                Console.Read();
                Environment.Exit(-1);

            }

            arkPack.LoadSaveGame(config.ArkSaveFile, string.Empty, config.ArkClusterFolder, 30);
            System.Timers.Timer reloadTimer = new System.Timers.Timer(60 * config.AutoReloadTimeMinutes);
            reloadTimer.Elapsed += (sender,args) =>
            {
                if (config.AutoReloadTimeMinutes != 0)
                {
                    arkPack.Reload();
                }

                if(reloadTimer.Interval != (60 * config.AutoReloadTimeMinutes))
                {
                    //config changed, update interval
                    reloadTimer.Interval = (60 * config.AutoReloadTimeMinutes);
                }
            };

            if (config.DiscordBotToken.Length == 0)
            {
                Console.WriteLine("No discordBotToken specified in botconfig.json.");
                Console.Read();
                Environment.Exit(-1);
            }

            var discord = new DiscordClient(new DiscordConfiguration()
            {
                Token = config.DiscordBotToken,
                TokenType = TokenType.Bot,
                Intents = DiscordIntents.AllUnprivileged
            });

            graphicsContainer = new DrawingContainer(arkPack, new ContentMapPack());

            var slash = discord.UseSlashCommands(new SlashCommandsConfiguration()
            {
                

                Services = new ServiceCollection()
                            .AddSingleton<BotConfig>(config)
                            .AddSingleton<DrawingContainer>(graphicsContainer)
                            .AddSingleton<IContentContainer>(arkPack)         
                            .AddSingleton<IDiscordPlayerManager>(new DiscordPlayerManager())                            
                            .AddSingleton<List<IClassMap>>(classMaps)
                            .AddSingleton<IResponseDataFormatter>(new ResponseDataFormatter())

                            .BuildServiceProvider()
            });

            RegisterCommands(slash);
            
            await discord.ConnectAsync();
          
            await Task.Delay(-1);

        }


        private static void RegisterCommands(SlashCommandsExtension slash)
        {
            if (config.DiscordServerId != 0)
            {
                slash.RegisterCommands<AdminCommands>((ulong)config.DiscordServerId);               
                slash.RegisterCommands<PlayerCommands>((ulong)config.DiscordServerId);
                slash.RegisterCommands<GeneralCommands>((ulong)config.DiscordServerId);

            }
            else
            {
                slash.RegisterCommands<AdminCommands>();
                slash.RegisterCommands<PlayerCommands>();
                slash.RegisterCommands<GeneralCommands>();
            }
        }
    }
}