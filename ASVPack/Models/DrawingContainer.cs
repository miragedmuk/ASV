using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkiaSharp;

namespace ASVPack.Models
{
    public  class DrawingContainer
    {

        IContentContainer arkPack;
        ContentMapPack mapPack;

        public DrawingContainer(IContentContainer arkPack, ContentMapPack mapPack)
        {
            this.arkPack = arkPack;
            this.mapPack = mapPack;
        }

        public SKImage MapImage
        {
            get
            {

                SKImage image = SKImage.Create(new SKImageInfo(1024,1024));
                if (mapPack == null || mapPack.SupportedMaps == null) return image;

                SKBitmap skBitmap = new SKBitmap(1024, 1024);

                string imageFilePath = AppContext.BaseDirectory;
                string imageFilename = mapPack.SupportedMaps.First(m => m.Filename.ToLower().Contains(arkPack.MapName.ToLower())).ImageFile;

                try
                {
                    skBitmap = SKBitmap.Decode(Path.Combine(imageFilePath, "Maps\\", imageFilename));
                    image = SKImage.FromBitmap(skBitmap);
                }
                catch
                {

                }

                return image;

            }

        }

        public async Task<bool> SaveMapImageTamed(string imageFilename, long playerId, string creatureType)
        {
            SKBitmap bitmap = new SKBitmap(1024, 1024);
            SKCanvas canvas = new SKCanvas(bitmap);

            canvas.DrawImage(MapImage, new SKPoint()); //main map image


            var playerTribe = arkPack.Tribes.FirstOrDefault(t => t.Players.Any(p => p.Id == playerId));
            if (playerTribe != null)
            {
                var filteredTames = playerTribe.Tames
                .Where(w => w.ClassName.ToLower().Contains(creatureType.ToLower()))
                .OrderBy(o => o.ClassName).ThenByDescending(o => o.BaseLevel).ToList();

                foreach (var wild in filteredTames)
                {
                    var markerX = (float)(wild.Longitude.GetValueOrDefault(0)) * 1024 / 100;
                    var markerY = (float)(wild.Latitude.GetValueOrDefault(0)) * 1024 / 100;
                    var markerSize = 10f;
                    int borderSize = 1;


                    SKColor markerColor = SKColor.Parse("f5f5f5"); //off white
                    SKColor borderColour = SKColor.Parse("2986cc"); //pastel blue

                    SKPaint markerPaint = new SKPaint();
                    markerPaint.IsAntialias = true;
                    markerPaint.StrokeWidth = borderSize;
                    markerPaint.IsStroke=false;
                    markerPaint.Color = markerColor;
                    canvas.DrawCircle(markerX, markerY, markerSize, markerPaint);

                    markerPaint = new SKPaint();
                    markerPaint.IsAntialias = true;
                    markerPaint.StrokeWidth = borderSize;
                    markerPaint.IsStroke = true;
                    markerPaint.Color = borderColour;
                    canvas.DrawCircle(markerX, markerY, markerSize, markerPaint);
                }
            }

            SKImage img = SKImage.FromBitmap(bitmap);
            SKData imgData = img.Encode(SKEncodedImageFormat.Png, 100);
            if (File.Exists(imageFilename)) File.Delete(imageFilename);
            using (FileStream outStream = new FileStream(imageFilename, FileMode.CreateNew))
            {
                imgData.SaveTo(outStream);
            }

            return await Task.FromResult(true);
        }

        public async Task<bool> SaveMapImageItems(string imageFilename, long playerId, string itemType)
        {

            SKBitmap bitmap = new SKBitmap(1024, 1024);
            SKCanvas canvas = new SKCanvas(bitmap);
           
            canvas.DrawImage(MapImage, new SKPoint()); //main map image

            var playerTribe = arkPack.Tribes.FirstOrDefault(t => t.Players.Any(p => p.Id == playerId));
            if (playerTribe != null)
            {


                var tribeStructures = arkPack.Tribes
                                            .Where(t => t.Players.Any(p => p.Id == playerId))
                                            .SelectMany(s => s.Structures)
                                            .Where(t =>
                                                        (t.Inventory != null && t.Inventory.Items != null && t.Inventory.Items.LongCount(i => !i.IsEngram & !i.IsBlueprint && i.ClassName.ToLower().Contains(itemType)) > 0)
                                            ).ToList();



                List<Tuple<string, string, string, string, float, int>> itemList = new List<Tuple<string, string, string, string, float, int>>();


                if (tribeStructures != null && tribeStructures.Count > 0)
                {
                    foreach (var tribeStructure in tribeStructures)
                    {

                        var markerX = (float)(tribeStructure.Longitude.GetValueOrDefault(0)) * 1024 / 100;
                        var markerY = (float)(tribeStructure.Latitude.GetValueOrDefault(0)) * 1024 / 100;
                        var markerSize = 5f;
                        int borderSize = 1;


                        SKColor markerColor = SKColor.Parse("f5f5f5"); //off white
                        SKColor borderColour = SKColor.Parse("2986cc"); //pastel blue

                        SKPaint markerPaint = new SKPaint();
                        markerPaint.IsAntialias = true;
                        markerPaint.StrokeWidth = borderSize;
                        markerPaint.IsStroke = false;
                        markerPaint.Color = markerColor;
                        canvas.DrawCircle(markerX, markerY, markerSize, markerPaint);

                        markerPaint = new SKPaint();
                        markerPaint.IsAntialias = true;
                        markerPaint.StrokeWidth = borderSize;
                        markerPaint.IsStroke = true;
                        markerPaint.Color = borderColour;
                        canvas.DrawCircle(markerX, markerY, markerSize, markerPaint);

                    }
                }



                var tribePlayers = arkPack.Tribes
                                                .Where(t => t.Players.Any(p => p.Id == playerId))
                                                .SelectMany(s => s.Players)
                                                .Where(t =>
                                                            (t.Inventory != null && t.Inventory.Items != null && t.Inventory.Items.LongCount(i => !i.IsEngram & !i.IsBlueprint && i.ClassName.ToLower().Contains(itemType)) > 0)
                                                ).ToList();


                if (tribePlayers != null && tribePlayers.Count > 0)
                {
                    foreach (var tribePlayer in tribePlayers)
                    {
                        var markerX = (float)(tribePlayer.Longitude.GetValueOrDefault(0)) * 1024 / 100;
                        var markerY = (float)(tribePlayer.Latitude.GetValueOrDefault(0)) * 1024 / 100;
                        var markerSize = 5f;
                        int borderSize = 1;


                        SKColor markerColor = SKColor.Parse("f5f5f5"); //off white
                        SKColor borderColour = SKColor.Parse("2986cc"); //pastel blue

                        SKPaint markerPaint = new SKPaint();
                        markerPaint.IsAntialias=true;
                        markerPaint.StrokeWidth = borderSize;
                        markerPaint.IsStroke = false;
                        markerPaint.Color = markerColor;
                        canvas.DrawCircle(markerX, markerY, markerSize, markerPaint);

                        markerPaint = new SKPaint();
                        markerPaint.IsAntialias = true;
                        markerPaint.StrokeWidth = borderSize;
                        markerPaint.IsStroke = true;
                        markerPaint.Color = borderColour;
                        canvas.DrawCircle(markerX, markerY, markerSize, markerPaint);

                    }
                }

            }

            SKImage img = SKImage.FromBitmap(bitmap);
            SKData imgData = img.Encode(SKEncodedImageFormat.Png, 100);
            if (File.Exists(imageFilename)) File.Delete(imageFilename);
            using (FileStream outStream = new FileStream(imageFilename, FileMode.CreateNew))
            {
                imgData.SaveTo(outStream);
            }

            return await Task.FromResult(true);
            

        }


        public async Task<bool> SaveMapImageStructures(string imageFilename, long playerId, string structureType)
        {

            SKBitmap bitmap = new SKBitmap(1024, 1024);
            SKCanvas canvas = new SKCanvas(bitmap);
            canvas.DrawImage(MapImage, new SKPoint()); //main map image


            var playerTribe = arkPack.Tribes.FirstOrDefault(t => t.Players.Any(p => p.Id == playerId));
            if (playerTribe != null)
            {
                var playerStructures = playerTribe.Structures
                .Where(w => w.ClassName.ToLower().Contains(structureType.ToLower()))
                .OrderBy(o => o.ClassName).ToList();

                foreach (var wild in playerStructures)
                {
                    var markerX = (float)(wild.Longitude.GetValueOrDefault(0)) * 1024 / 100;
                    var markerY = (float)(wild.Latitude.GetValueOrDefault(0)) * 1024 / 100;
                    var markerSize = 5f;
                    int borderSize = 1;


                    SKColor markerColor = SKColor.Parse("f5f5f5"); //off white
                    SKColor borderColour = SKColor.Parse("2986cc"); //pastel blue

                    SKPaint markerPaint = new SKPaint();
                    markerPaint.IsAntialias = true;
                    markerPaint.StrokeWidth = borderSize;
                    markerPaint.IsStroke = false;
                    markerPaint.Color = markerColor;
                    canvas.DrawCircle(markerX, markerY, markerSize, markerPaint);

                    markerPaint = new SKPaint();
                    markerPaint.IsAntialias = true;
                    markerPaint.StrokeWidth = borderSize;
                    markerPaint.IsStroke = true;
                    markerPaint.Color = borderColour;
                    canvas.DrawCircle(markerX, markerY, markerSize, markerPaint);
                }
            }


            SKImage img = SKImage.FromBitmap(bitmap);
            SKData imgData = img.Encode(SKEncodedImageFormat.Png, 100);
            if (File.Exists(imageFilename)) File.Delete(imageFilename);
            using (FileStream outStream = new FileStream(imageFilename, FileMode.CreateNew))
            {
                imgData.SaveTo(outStream);
            }

            return await Task.FromResult(true);

        }

        public async Task<bool> SaveMapImageWild(string imageFilename, string className, float filterLat, float filterLon, float filterRadius)
        {
            SKBitmap bitmap = new SKBitmap(1024, 1024);
            SKCanvas canvas = new SKCanvas(bitmap);
            canvas.DrawImage(MapImage, new SKPoint()); //main map image

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
                var markerX = (float)(wild.Longitude.GetValueOrDefault(0)) * 1024 / 100;
                var markerY = (float)(wild.Latitude.GetValueOrDefault(0)) * 1024 / 100;
                var markerSize = 5f;
                int borderSize = 1;


                SKColor markerColor = SKColor.Parse("f5f5f5"); //off white
                SKColor borderColour = SKColor.Parse("2986cc"); //pastel blue

                SKPaint markerPaint = new SKPaint();
                markerPaint.IsAntialias = true;
                markerPaint.StrokeWidth = borderSize;
                markerPaint.IsStroke = false;
                markerPaint.Color = markerColor;
                canvas.DrawCircle(markerX, markerY, markerSize, markerPaint);

                markerPaint = new SKPaint();
                markerPaint.IsAntialias = true;
                markerPaint.StrokeWidth = borderSize;
                markerPaint.IsStroke = true;
                markerPaint.Color = borderColour;
                canvas.DrawCircle(markerX, markerY, markerSize, markerPaint);
            }

            SKImage img = SKImage.FromBitmap(bitmap);
            SKData imgData = img.Encode(SKEncodedImageFormat.Png, 100);

            if (File.Exists(imageFilename)) File.Delete(imageFilename);
            using (FileStream outStream = new FileStream(imageFilename, FileMode.CreateNew))
            {
                imgData.SaveTo(outStream);
            }

            return await Task.FromResult(true);

        }


    }
}
