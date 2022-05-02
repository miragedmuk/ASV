using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARKViewer.Models
{
    public class ASVAncestor
    {
        public long Generation { get; set; }
        public long Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Level { get; set; }

        public ASVAncestor(long generation, long id, string name, string gender, int lvl)
        {
            Id = id;
            Generation = generation;
            Name = name;
            Gender = gender;
            Level = lvl;
        }

        public override string ToString()
        {
            return Generation==0?"[All]":$"Generation {Generation}";
        }
    }
}
