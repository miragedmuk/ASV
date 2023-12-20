using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsaSavegameToolkit.Structs
{
    public class AsaUnknownStruct
    {
        string structType;
        string structValue;


        public string Type => structType;
        public string Value => structValue;

        public AsaUnknownStruct(string structType, string structValue)
        {
            this.structType = structType;
            this.structValue = structValue;
        }

    }
}
