namespace ASVApiServer.Models
{
    public class WildSummaryModel
    {
        public string ClassName { get; set; }
        public string Description { get; set; }
        public long Count { get; set; } = 0;
        public int MinLevel { get; set; } = 1;
        public int MaxLevel { get; set; } = 1;
    }
}
