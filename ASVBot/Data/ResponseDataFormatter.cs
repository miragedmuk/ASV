using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASVBot.Data
{
    public class ResponseDataFormatter: IResponseDataFormatter
    {
        public string FormatResponseTable(string responseHeader, List<string> responseLines)
        {
            if (responseLines.Count == 0) return responseHeader.Length > 0 ? responseHeader : string.Empty;

            StringBuilder sb = new StringBuilder();

            if (responseHeader.Contains(",")) //multi-col input
            {
                //check header and first line match column count
                var headerSplit = responseHeader.Split(',');
                var firstLineSplit = responseLines.First().Split(',');

                if (headerSplit.Length != firstLineSplit.Length)
                {

                    return string.Empty;
                }

                int colCount = headerSplit.Length;
                var colSizes = new int[colCount];

                for (int col = 0; col < colCount; col++)
                {
                    var maxColHeader = headerSplit[col].Length;
                    var maxColLine = responseLines.Max(l => l.Split(',')[col].Length);
                    if (maxColHeader >= maxColLine)
                    {
                        colSizes[col] = maxColHeader;
                    }
                    else
                    {
                        colSizes[col] = maxColLine;
                    }
                }

                //now parse it out providing spacing as necessary
                for (int col = 0; col < colCount; col++)
                {
                    string colHeader = headerSplit[col];
                    sb.Append(colHeader.PadRight(colSizes[col] + 2));
                }
                sb.Append('\n');

                foreach (var line in responseLines)
                {
                    var lineSplit = line.Split(',');
                    if (lineSplit.Length != headerSplit.Length)
                    {
                        //line cols dont match header, skip this one?
                    }
                    else
                    {
                        for (int col = 0; col < colCount; col++)
                        {
                            string colText = lineSplit[col];
                            sb.Append(colText.PadRight(colSizes[col] + 2));
                        }
                        sb.Append('\n');
                    }
                }
            }
            else
            {
                //no cols so just append the header to the lines and return
                sb.AppendLine(responseHeader);
                sb.AppendJoin('\n', responseLines);
            }

            return sb.ToString();
        }

    }
}
