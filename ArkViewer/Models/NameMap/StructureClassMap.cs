using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARKViewer.Models.NameMap
{
    public class StructureClassMap : IGenericClassMap
    {
        public string ClassName { get; set; }
        public string FriendlyName { get; set; }
    }
}
