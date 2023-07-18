using ASVBot.Commands;
using ASVBot.Config;
using ASVBot.Data;
using ASVPack;
using ASVPack.Models;
using DSharpPlus;
using DSharpPlus.SlashCommands;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection.Metadata;

namespace ASVBot
{
    internal class Program
    {
        public static ContentContainer arkPack = new ContentContainer();
        private static BotConfig config = new BotConfig();
        private static List<ICreatureMap> creatureMap = new List<ICreatureMap>();
        private static ContentContainerGraphics graphicsContainer = null;

        static async Task Main(string[] args)
        {
            var configFilename = Path.Combine(AppContext.BaseDirectory, "botconfig.json");
            if(!File.Exists(configFilename))
            {

                return;
            }


            var creatureMapConfigFilename = Path.Combine(AppContext.BaseDirectory, "creaturemap.json");
            if (File.Exists(creatureMapConfigFilename))
            {
                creatureMap = new List<ICreatureMap>();

                string jsonFileContent = File.ReadAllText(creatureMapConfigFilename);

                JObject dinoFile = JObject.Parse(jsonFileContent);
                JArray dinoList = (JArray)dinoFile.GetValue("creatures");
                if(dinoList!= null)
                {
                    foreach (JObject dinoObject in dinoList)
                    {
                        if (dinoObject != null)
                        {
                            ICreatureMap dino = new CreatureMap();
                            dino.ClassName = dinoObject.Value<string>("ClassName")??"";
                            dino.FriendlyName = dinoObject.Value<string>("FriendlyName")??"";
                            creatureMap.Add(dino);
                        }
                    }
                }               

            }

            var configFileData = File.ReadAllText(configFilename);
            config = JsonConvert.DeserializeObject<BotConfig>(configFileData)??new BotConfig();

            if(!File.Exists(config.ArkSaveFile))
            {
                return;
            }

            arkPack.LoadSaveGame(config.ArkSaveFile, string.Empty, config.ArkClusterFolder);

            var discord = new DiscordClient(new DiscordConfiguration()
            {
                Token = config.DiscordBotToken,
                TokenType = TokenType.Bot,
                Intents = DiscordIntents.All
            });

            graphicsContainer = new ContentContainerGraphics(arkPack, new ContentMapPack());

            var slash = discord.UseSlashCommands(new SlashCommandsConfiguration()
            {
                

                Services = new ServiceCollection()
                            .AddSingleton<BotConfig>(config)
                            .AddSingleton<ContentContainerGraphics>(graphicsContainer)
                            .AddSingleton<IContentContainer>(arkPack)         
                            .AddSingleton<IDiscordPlayerManager>(new DiscordPlayerManager())                            
                            .AddSingleton<List<ICreatureMap>>(creatureMap)

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
            }
            else
            {
                slash.RegisterCommands<AdminCommands>();
                slash.RegisterCommands<PlayerCommands>();
            }
        }
    }
}