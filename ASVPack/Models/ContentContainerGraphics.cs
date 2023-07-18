using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ASVPack.Models
{
    public class ContentContainerGraphics
    {
        IContentContainer arkPack;
        ContentMapPack mapPack;

        public ContentContainerGraphics(IContentContainer content,ContentMapPack maps) 
        {
            this.arkPack = content;
            this.mapPack = maps;
        
        }

        public System.Drawing.Image MapImage
        {
            get
            {


                string imageFilePath = AppContext.BaseDirectory;
                string imageFilename =   mapPack.SupportedMaps.FirstOrDefault(m => m.Filename.ToLower().Contains(arkPack.MapName.ToLower()))?.ImageFile;

                try
                {
                    return System.Drawing.Image.FromFile(Path.Combine(imageFilePath, "Maps\\", imageFilename));
                }
                catch
                {
                    return new Bitmap(1024, 1024);
                }

            }

        }


        /**** Map & Overlays ****/
        public Bitmap GetMapImageWild(string className, float filterLat, float filterLon, float filterRadius)
        {
            Bitmap bitmap = new Bitmap(1024, 1024);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;



            graphics.DrawImage(MapImage, new Rectangle(0, 0, 1024, 1024));
    
            var filteredWilds = arkPack.WildCreatures
                .Where(w =>
                            (
                                (Math.Abs(w.Latitude.GetValueOrDefault(0) - filterLat) <= filterRadius)
                                && (Math.Abs(w.Longitude.GetValueOrDefault(0) - filterLon) <= filterRadius)
                            )
                            && w.ClassName.ToLower().Contains(className.ToLower()))
                .OrderBy(o => o.ClassName).ThenByDescending(o => o.BaseLevel).ToList();
            
            foreach (var wild in filteredWilds)
            {
                var markerX = (decimal)(wild.Longitude.GetValueOrDefault(0)) * 1024 / 100;
                var markerY = (decimal)(wild.Latitude.GetValueOrDefault(0)) * 1024 / 100;
                var markerSize = 10f;


                Color markerColor = Color.WhiteSmoke;
                graphics.FillEllipse(new SolidBrush(markerColor), (float)markerX - (markerSize / 2), (float)markerY - (markerSize / 2), markerSize, markerSize);

                Color borderColour = Color.Blue;
                int borderSize = 1;
                graphics.DrawEllipse(new Pen(borderColour, borderSize), (float)markerX - (markerSize / 2), (float)markerY - (markerSize / 2), markerSize, markerSize);
            }


        
            return bitmap;
        }

    }
}
