using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASVPack.Models
{
    public class ContentPainting
    {
        readonly ContentPalette palette =  new ContentPalette();

        public uint version;
        public int width;
        public int height;
        public uint revision;
        public int size;

        public byte[] bits;

        public ContentPainting(string file)
        {
            if (File.Exists(file))
            {
                using (Stream fs = File.OpenRead(file))
                using (BinaryReader br = new BinaryReader(fs))
                {

                    version = br.ReadUInt32();
                    width = br.ReadInt32();
                    height = br.ReadInt32();
                    revision = br.ReadUInt32();
                    size = br.ReadInt32();
                    bits = br.ReadBytes(size);
                }

            }

        }


        public SKColor GetPixel(int x, int y)
        {
            if (x < 0 || x >= width || y < 0 || y >= height)
                return new SKColor();

            return palette.Get(bits[x + y * width]);
        }


        public SKBitmap GenerateBitmap()
        {
            if (bits == null)
            {
                //file not loaded, return "Not Found" image.
                var blankBmp = new SKBitmap(256, 256, true);
                var blankCanvas = new SKCanvas(blankBmp);
                blankCanvas.DrawRect(0,0,256,256,new SKPaint() { Color = new SKColor(100,100,100) });

                blankCanvas.DrawText("File Not Found", 128, 128, new SKPaint(new SKFont() {  Size = 16f }) { Color = new SKColor(250,250,250), TextAlign = SKTextAlign.Center, IsAntialias=true});
                return blankBmp;
            }


            SKBitmap bmp = new SKBitmap(width, height,true);

            var backColor = GetPixel(0, 0);

            //Parallel.For(0, height - 1, y =>
            for(int y = 0; y < height; y++)
            {
                //Parallel.For(0, width - 1, x =>
                for(int x = 0; x < width; x++)
                {
                    var pixelColor = GetPixel(x, y);
                    if (pixelColor == backColor)
                    {
                        pixelColor = new SKColor(100, 100, 100);
                    }

                    bmp.SetPixel(x, y, pixelColor);

                }//);

            }//);

            return bmp;
        }

    }
}
