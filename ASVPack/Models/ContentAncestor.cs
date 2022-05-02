using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace ASVPack.Models
{
    [DataContract]
    public class ContentAncestor
    {
        [DataMember] public long Generation { get; set; } = 1;
        [DataMember] public long Id { get; set; } = 0;
        [DataMember] public string Name { get; set; } = "";
        [DataMember] public string Gender { get; set; } = "Male";
        [DataMember] public int Level { get; set; } = 0;

        public ContentAncestor()
        {

        }

        public ContentAncestor(long generation, long id, string name, string gender, int lvl)
        {
            Id = id;
            Generation = generation;
            Name = name;
            Gender = gender;
            Level = lvl;
        }

        public override string ToString()
        {
            return Generation == 0 ? "[All]" : $"Generation {Generation}";
        }
    }
}
