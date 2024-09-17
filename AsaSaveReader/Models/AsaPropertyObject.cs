using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsaSaveReader.Models
{
    internal class AsaPropertyObject<T> : IAsaPropertyObject<T>
    {
        public string Name { get; set; }
        public T Value { get; set; }

        public AsaPropertyObject(string name, T value)
        {
            Name = name;
            Value = value;
        }
    }
}
