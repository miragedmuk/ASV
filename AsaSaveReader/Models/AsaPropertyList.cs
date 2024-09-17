using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsaSaveReader.Models
{
    internal class AsaPropertyList<T> : IAsaPropertyList<T>
    {
        public string Name { get; set; }
        public List<AsaPropertyObject<T>> Value { get; set; }
        public AsaPropertyList(string name, List<AsaPropertyObject<T>> properties)
        {
            Name = name;
            Value = properties;
        }
    }
}
