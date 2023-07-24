using ASVBot.Data;
using ASVPack.Models;
using DSharpPlus.Entities;
using DSharpPlus;
using DSharpPlus.SlashCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASVBot.Commands
{
    public class GeneralCommands: ApplicationCommandModule
    {

        IContentContainer arkPack;
        IDiscordPlayerManager playerManager;

        public GeneralCommands(IContentContainer content, IDiscordPlayerManager manager) 
        {
            this.arkPack = content;
            this.playerManager = manager;
        }

        public override Task<bool> BeforeSlashExecutionAsync(InteractionContext ctx)
        {
            if (!arkPack.IsLoaded())
            {
                ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent("No ARK currently loaded. Please try again later."));
                return Task.FromResult(false);
            }

            return base.BeforeSlashExecutionAsync(ctx);
        }

        [SlashCommand("asv-link", "Link your discord handle to your game handle.")]
        public async Task LinkPlayer(InteractionContext ctx, [Option("gamerTag", "Steam Id / Epic Id / Gamertag")] string playerId)
        {
            if(playerManager.GetDeniedPlayers().Any(d=>d.DiscordUsername.ToLower() == ctx.Member.Username.ToLower()))
            {
                await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent("You are not allowed to use ASVBot. Please raise this with a moderator or admin if you believe this to be in error."));
                return;
            }

            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);
            string responseString = string.Empty;

            //attempt to find match in game data of user detail provided

            //first by playerId
            long.TryParse(playerId, out long playerIdLong);
            ContentPlayer arkPlayer = arkPack.Tribes.SelectMany(t => t.Players.Where(p => p.Id == playerIdLong && playerIdLong != 0)).FirstOrDefault();
            if (arkPlayer == null)
            {
                arkPlayer = arkPack.Tribes.SelectMany(t => t.Players.Where(p => p.NetworkId == playerId)).FirstOrDefault();
            }
            if (arkPlayer == null)
            {
                arkPlayer = arkPack.Tribes.SelectMany(t => t.Players.Where(p => p.Name == playerId)).FirstOrDefault();
            }
            if (arkPlayer == null)
            {
                arkPlayer = arkPack.Tribes.SelectMany(t => t.Players.Where(p => p.CharacterName == playerId)).FirstOrDefault();
            }

            if (arkPlayer != null)
            {
                var existingLink = playerManager.GetPlayers().FirstOrDefault(p => p.DiscordUsername == ctx.Member.Username);
                if (existingLink != null)
                {
                    var otherAssociate = playerManager.GetPlayers().FirstOrDefault(p => p.ArkPlayerId == arkPlayer.Id);
                    if (otherAssociate != null && otherAssociate.DiscordUsername != ctx.Member.Username)
                    {
                        //already associated with another discord user
                        responseString = $"ARK player is already associated with another discord user: {otherAssociate.DiscordUsername}";
                    }
                    else
                    {
                        playerManager.LinkPlayer(ctx.Member.Username, arkPlayer.Id, arkPlayer.CharacterName, 1);
                        responseString = $"{ctx.Member.DisplayName} successfully re-linked to {arkPlayer.Name} - ({arkPlayer.Id})";

                    }


                }
                else
                {
                    playerManager.LinkPlayer(ctx.Member.Username, arkPlayer.Id, arkPlayer.CharacterName, 1);
                    responseString = $"{ctx.Member.DisplayName} successfully linked to {arkPlayer.Name} - ({arkPlayer.Id})";
                }

            }
            else
            {
                responseString = $"Failed to link player.  No player found on this ARK matching id/tag provided.";
            }

            //Some time consuming task like a database call or a complex operation
            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent(responseString));
        }



        [SlashCommand("asv-unlink", "Unlink your discord handle from your game handle.")]
        public async Task UnlinkPlayer(InteractionContext ctx)
        {


            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);

            var responseString = "";
            var discordUser = playerManager.GetPlayers().FirstOrDefault(p => p.DiscordUsername == ctx.Member.Username);
            if (discordUser != null)
            {
                responseString = $"{ctx.Member.DisplayName} unlinked from {discordUser.ArkCharacterName}.";
                playerManager.RemovePlayer(ctx.Member.Username);
            }
            else
            {
                responseString = $"{ctx.Member.DisplayName} has no linked gamer tag.";
            }

            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent(responseString));
        }


    }
}
