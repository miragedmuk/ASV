namespace ASVPack.Models
{
    public interface IContentContainer
    {
        List<ContentDroppedItem> DroppedItems { get; set; }
        DateTime GameSaveTime { get; set; }
        float GameSeconds { get; set; }
        List<ContentLeaderboard> Leaderboards { get; set; }
        ContentMap LoadedMap { get; set; }
        ContentLocalProfile LocalProfile { get; set; }
        string MapName { get; set; }
        List<ContentStructure> MapStructures { get; set; }
        List<ContentTribe> Tribes { get; set; }
        List<ContentWildCreature> WildCreatures { get; set; }

        DateTime? GetApproxDateTimeOf(double? objectTime);
        void LoadSaveGame(string saveFilename, string localProfileFilename, string clusterFolder);
        bool Reload();
        bool IsLoaded();
        
    }
}