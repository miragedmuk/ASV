using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsaSaveReader.Models
{
    internal class AsaGameObject
    {

        public Guid Guid { get; set; } = Guid.Empty;
        public string Blueprint { get; private set; } = string.Empty;
        public AsaName ClassName { get; private set; } = AsaName.NameNone;
        public string ClassString
        {
            get
            {
                return ClassName?.ToString() ?? "";
            }
        }
        public bool IsItem { get; private set; } = false;
        public readonly List<AsaName> Names = new List<AsaName>();
        public AsaLocation? Location { get; set; } = null;
        public List<IAsaPropertyObject> Properties { get; private set; } = new List<IAsaPropertyObject>();
        public List<AsaName> ParentNames => Names.Skip(1).ToList();
        public int DataFileIndex { get; private set; } = 0;
        public long PropertyOffset { get; private set; } = 0;
    }
}
