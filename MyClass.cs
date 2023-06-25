using BCnEncoder.Encoder;
using BCnEncoder.ImageSharp;
using BCnEncoder.Shared;
using Microsoft.Toolkit.HighPerformance;
using SixLabors.ImageSharp.Processing.Processors.Drawing;
using System.Windows.Forms;
using Image = SixLabors.ImageSharp.Image;
using Point = SixLabors.ImageSharp.Point;

namespace BakeTool
{
    internal class MyClass
    {
        internal static void DoStuff(string paint_ao_path, string paint_dirt_path, string paint_wear_path, string png_file_name)
        {
            Image paint_ao = Image.Load(paint_ao_path);
            var height = paint_ao.Height;
            var width = paint_ao.Width;
            using (Image green = Image.Load(@"images\green.png"))
            {
                green.Mutate(x => x.Resize(width, height));

                var processorCreator = new DrawImageProcessor(
                    green,
                    Point.Empty,
                    PixelColorBlendingMode.Multiply,
                    PixelAlphaCompositionMode.DestAtop,
                    1f
                );

                paint_ao.Mutate(x => x.ApplyProcessor(processorCreator));
            }

            Image paint_wear = Image.Load(paint_wear_path);
            paint_wear.Mutate(x => x.Resize(width, height));
            using (Image red = Image.Load(@"images\red.png"))
            {
                red.Mutate(x => x.Resize(width, height));

                var processorCreator = new DrawImageProcessor(
                    red,
                    Point.Empty,
                    PixelColorBlendingMode.Multiply,
                    PixelAlphaCompositionMode.DestAtop,
                    1f
                );

                paint_wear.Mutate(x => x.ApplyProcessor(processorCreator));
            }

            Image paint_dirt = Image.Load(paint_dirt_path);
            paint_dirt.Mutate(x => x.Resize(width, height));
            using (Image blue = Image.Load(@"images\blue.png"))
            {
                blue.Mutate(x => x.Resize(width, height));

                var processorCreator = new DrawImageProcessor(
                    blue,
                    Point.Empty,
                    PixelColorBlendingMode.Multiply,
                    PixelAlphaCompositionMode.DestAtop,
                    1f
                );

                paint_dirt.Mutate(x => x.ApplyProcessor(processorCreator));
            }

            var processorCreator2 = new DrawImageProcessor(
                paint_wear,
                Point.Empty,
                PixelColorBlendingMode.Add,
                PixelAlphaCompositionMode.DestAtop,
                1f
            );

            var processorCreator3 = new DrawImageProcessor(
                paint_dirt,
                Point.Empty,
                PixelColorBlendingMode.Add,
                PixelAlphaCompositionMode.DestAtop,
                1f
            );

            paint_ao.Mutate(x => x.ApplyProcessor(processorCreator2));
            paint_ao.Mutate(x => x.ApplyProcessor(processorCreator3));
            paint_ao.Save(png_file_name);

            // jetzt als dds machen
            using Image<Rgba32> image = Image.Load<Rgba32>(png_file_name);

            BcEncoder encoder = new BcEncoder();

            encoder.OutputOptions.GenerateMipMaps = true;
            encoder.OutputOptions.Quality = CompressionQuality.Balanced;
            encoder.OutputOptions.Format = CompressionFormat.Bc1;
            encoder.OutputOptions.FileFormat = OutputFileFormat.Dds; //Change to Dds for a dds file.

            using FileStream fs = File.OpenWrite(png_file_name.Replace(".png", ".dds"));
            encoder.EncodeToStream(image, fs);
        }
    }
}