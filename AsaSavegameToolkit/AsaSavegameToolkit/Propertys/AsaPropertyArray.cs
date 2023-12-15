using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsaSavegameToolkit.Propertys
{
    public class AsaPropertyArray
    {
        public List<dynamic> Value { get; private set; } = new List<dynamic>();
        public string Name { get; private set; } = string.Empty;

        public AsaPropertyArray(string name, List<dynamic> items)
        {
            Name = name;
            Value = items;
        }
    }
}
