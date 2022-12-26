namespace ASVApiServer.Models
{
    public class PlayerDataModel
    {
        public long Id { get; set; }    
        public long TribeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }  
        public int Level { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public int PointsHp { get;set; }
        public int PointsStamina { get;set;}
        public int PointsMelee { get;set;}
        public int PointsWeight { get; set; }
        public int PointsSpeed { get; set; }
        public int PointsWater { get; set; }
        public int PointsOxygen { get; set; }
        public int PointsCrafting { get; set; } 
        public int PointsFortitude { get; set; }
        public DateTime? LastOnline { get; set; }
        public string SteamName { get; set; }
        public string SteamId { get; set; }
        public string CCC { get; set; }

    }
}
