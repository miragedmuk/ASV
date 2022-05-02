using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace ASVPack.Models
{
    [DataContract]
    public class ContentInventory
    {
        [DataMember] public List<ContentItem> Items { get; set; } = new List<ContentItem>();

        public ContentInventory()
        {
            Items = new List<ContentItem>();
        }
    }
}