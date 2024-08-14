using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASVPack.Models
{
    public class ContentAchievement
    {
        public string Description { get; set; } = string.Empty;
        public string Level { get; set;} = string.Empty;    

        public ContentAchievement(string description, string level)
        {
            this.Description = description;
            this.Level = level;
        }
        public ContentAchievement() { }

    }
}
