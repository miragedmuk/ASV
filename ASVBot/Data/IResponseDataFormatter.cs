using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASVBot.Data
{
    public interface IResponseDataFormatter
    {
        string FormatResponseTable(string responseHeader, List<string> responseLines);
    }
}
