using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsaSavegameToolkit.Propertys
{
    public class AsaProperty<T>
    {
        private readonly string name;
        private readonly string type;
        private readonly int position;
        private readonly byte unknownByte;
        private readonly T value;
        public AsaProperty(string name, string type, int position, byte unknownByte, T value)
        {
            this.name = name;
            this.type = type;
            this.position = position;
            this.unknownByte = unknownByte;
            this.value = value;
        }

        public string Name => name;
        public string Type => type;
        public int Position => position;
        public byte UnknownByte => unknownByte;
        public T Value => value;
        public override string ToString()
        {
            return string.Concat("Type: ", type, ", Name: ", name, ", Value: ", value.ToString());
        }
    }
}
