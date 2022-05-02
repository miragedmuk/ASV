using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARKViewer.Models
{
    public class ASVCreatureSummary
    {
        public string ClassName { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public int MaxLevel { get; set; }
        public int MinLevel { get; set; }
        public int MaxLength { get; set; } = 100;

        public override string ToString()
        {
            return Name;
        }
    }
}
