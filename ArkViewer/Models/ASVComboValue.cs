using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARKViewer.Models
{
    public class ASVComboValue
    {
        public ASVComboValue()
        {

        }
        public ASVComboValue(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }

        public string Key { get; set; }
        public string Value { get; set; }
        public override string ToString()
        {
            return Value;
        }

    }
}
