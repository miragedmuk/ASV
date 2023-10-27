using Newtonsoft.Json.Linq;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ASVPack.Models
{
    internal class ContentPalette
    {
        struct PaletteEntry
        {
            public int index;
            public string name;
            public SKColor color;

            // HSV color
            public double h, s, v;//precached for performance
        }
        List<PaletteEntry> entries = new List<PaletteEntry>();

        public ContentPalette() 
        { 
            entries = new List<PaletteEntry>();

            string coloursFilename = Path.Combine(AppContext.BaseDirectory, "colours.json");
            if(File.Exists(coloursFilename))
            {
                string jsonFileContent = File.ReadAllText(coloursFilename);

                JObject itemFile = JObject.Parse(jsonFileContent);
                JArray itemList = (JArray)itemFile.GetValue("colors");
                foreach (JObject itemObject in itemList)
                {
                    PaletteEntry pe = new PaletteEntry()
                    {
                        index = itemObject.Value<int>("id"),
                        color = SKColor.Parse(itemObject.Value<string>("hex"))
                    };

                    
                    entries.Add(pe);

                }
            }

        }

        public SKColor Get(int index)
        {
            if (index == 0)
                return new SKColor(0,0,0);

            foreach (PaletteEntry pe in entries)
                if (pe.index == index)
                    return pe.color;

            return new SKColor();
        }


        public int FindClosestIndex(SKColor clr, bool hsvCompare)
        {
            if (clr.Alpha == 0)
                return 0;

            int closestIndex = -1;
            int closestDiff = 99999;
            foreach (PaletteEntry pe in entries)
            {
                int diff;

                diff = Math.Abs(pe.color.Red - clr.Red) + Math.Abs(pe.color.Green - clr.Green) + Math.Abs(pe.color.Blue - clr.Blue);

                if (diff < closestDiff)
                {
                    closestDiff = diff;
                    closestIndex = pe.index;
                }
            }

            return closestIndex;
        }

    }
}
