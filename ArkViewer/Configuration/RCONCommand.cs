using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ArkViewer.Configuration
{
    [DataContract]
    public class RCONCommand
    {
        [DataMember(Name ="text")] public string CommandText { get; set; }
        [DataMember(Name = "params")] public List<RCONParameter> Parameters { get; set; } = new List<RCONParameter>();
        [DataMember(Name = "inputs")] public List<RCONParameter> UserInputs { get; set; } = new List<RCONParameter>();

        public override string ToString()
        {
            return CommandText;
        }

        public string GetTemplate()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{CommandText} ");

            List<RCONParameter> allParams = new List<RCONParameter>();
            allParams.AddRange(Parameters.ToArray());
            allParams.AddRange(UserInputs.ToArray());

            var sortedParams = allParams.OrderBy(x => x.Order);
            foreach ( RCONParameter param in sortedParams)
            {
                if (param.Quoted) sb.Append("\"");
                sb.Append($"<{param.Key}>");
                if (param.Quoted) sb.Append("\"");
                sb.Append(" ");
            }

            return sb.ToString();
        }


    }
}
