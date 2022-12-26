namespace ASVApiServer.Models
{
    public class TribeSummaryModel
    {
        public long TribeId { get; set; }   
        public string TribeName { get; set; }
        public int PlayerCount { get; set; } = 1;
        public int StructureCount { get; set; } = 0;
        public int TameCount { get; set; } = 0;

    }
}
