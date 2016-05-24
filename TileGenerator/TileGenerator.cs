using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace TileGenerator
{
    class TileGenerator
    {
        private BackgroundWorker _bw;
        private Image _img;

        public string InputFileName { get; set; }

        public string OutputDirectory { get; set; }

        public string ImageMagickDir { get; set; }

        public string OutputFileType { get; set; }

        public int TileSize { get; set; }

        public string TileName { get; set; }

        public bool SameFolder { get; set; }

        public static byte[] HashImage(Bitmap image)
        {
            var sha256 = SHA256.Create();

            var rect = new Rectangle(0, 0, image.Width, image.Height);
            var data = image.LockBits(rect, ImageLockMode.ReadOnly, image.PixelFormat);

            var dataPtr = data.Scan0;

            var totalBytes = Abs(data.Stride) * data.Height;
            var rawData = new byte[totalBytes];
            Marshal.Copy(dataPtr, rawData, 0, totalBytes);

            image.UnlockBits(data);

            return sha256.ComputeHash(rawData);
        }

        public void InitBackgroundWorker(ProgressChangedEventHandler progressChanged)
        {
            _bw = new BackgroundWorker
            {
                WorkerSupportsCancellation = false,
                WorkerReportsProgress = true
            };
            _bw.DoWork += GenerateTiles;
            _bw.ProgressChanged += progressChanged;
        }

        public void RunAsync(string inputImagePath, string outputImagePath, string imageMagickPath, string tileSize, string tileName,
            string outputFileType, Image img)
        {
            try
            {
                _img = img;
                InputFileName = inputImagePath;

                if (!File.Exists(InputFileName))
                {
                    throw new Exception("Input image file does not exist");
                }

                OutputDirectory = outputImagePath.Equals("")
                        ? "C:/Tiles"
                        : outputImagePath;

                if (!Directory.Exists(OutputDirectory))
                {
                    Directory.CreateDirectory(OutputDirectory);
                }

                ImageMagickDir = imageMagickPath.Equals("")
                    ? "C:/Program Files/ImageMagick-6.9.3-Q16"
                    : imageMagickPath;

                if (!File.Exists(ImageMagickDir + "/convert.exe"))
                {
                    throw new Exception("Convert.exe is not found in the " + ImageMagickDir);
                }

                TileSize = tileSize.Equals("")
                    ? 512
                    : int.Parse(tileSize);

                TileName = tileName.Equals("")
                    ? Path.GetFileNameWithoutExtension(InputFileName)
                    : tileName;

                OutputFileType = outputFileType;
            }
            catch (Exception e)
            {
                HandleException("preparing for generation", e.Message);
            }

            _bw.RunWorkerAsync();

        }

        private void GenerateTiles(object sender, DoWorkEventArgs e)
        {
            double progress = 0;

            var fileNameOnly = Path.GetFileNameWithoutExtension(InputFileName);

            var maxZoomLevel = (int)Ceiling(Log(Max(_img.Width, _img.Height), 2)) - Log(TileSize, 2);
            var divisibleBy = TileSize * Pow(2, maxZoomLevel - 2);

            var width = (int)(divisibleBy * Ceiling(_img.Width / divisibleBy));
            var height = (int)(divisibleBy * Ceiling(_img.Height / divisibleBy));

            var size = Max(width, height);

            _bw.ReportProgress(10);

            //scaling the image

            try
            {
                if (SameFolder)
                    Directory.CreateDirectory($"{OutputDirectory}/{fileNameOnly}/tiles");
                else
                {
                    Directory.CreateDirectory($"{OutputDirectory}/{fileNameOnly}");
                    for (var i = 0; i < maxZoomLevel; i++)
                    {
                        Directory.CreateDirectory($"{OutputDirectory}/{fileNameOnly}/{i}");
                    }
                }

                var scaler = new ProcessStartInfo
                {
                    Arguments = $"{InputFileName} -gravity center -extent {size}x{size} {Path.GetDirectoryName(InputFileName)}/{fileNameOnly}-resised.png",
                    FileName = $"{ImageMagickDir}/convert.exe",
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true
                };

                using (var proc = Process.Start(scaler))
                {
                    if (proc == null) return;
                    proc.WaitForExit();
                }
            }
            catch (Exception exception)
            {
                HandleException("scaling the image", exception.Message);
            }

            _bw.ReportProgress(30);

            for (var scale = 1.0; scale >= 1 / Pow(2, maxZoomLevel - 1); scale /= 2)
            {
                int scaleNum = (int)(maxZoomLevel - 1 - Log(scale, 0.5));

                //CONVERTING THE IMAGE
                try
                {
                    var generator = new ProcessStartInfo
                    {
                        Arguments = $"{Path.GetDirectoryName(InputFileName)}/{fileNameOnly}-resised.png -resize {scale * 100}% {OutputDirectory}/{fileNameOnly}/{TileName}_scale_{maxZoomLevel - 1 - Log(scale, 0.5)}{OutputFileType}",
                        FileName = $"{ImageMagickDir}/convert.exe",
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true
                    };
                    // Run the external process & wait for it to finish
                    using (var proc = Process.Start(generator))
                    {
                        if (proc == null) return;
                        proc.WaitForExit();
                    }


                    progress += (int)(scale * 500);
                    _bw.ReportProgress((int)(progress / 2000d * 100d));
                    generator.Arguments = !SameFolder
                        ? $"{OutputDirectory}/{fileNameOnly}/{TileName}_scale_{scaleNum}{OutputFileType} -crop {TileSize}x{TileSize} -set filename:tile %[fx:page.x/{TileSize}]_%[fx:page.y/{TileSize}] {OutputDirectory}/{fileNameOnly}/{scaleNum}/{TileName}_%[filename:tile]{OutputFileType}"
                        : $"{OutputDirectory}/{fileNameOnly}/{TileName}_scale_{scaleNum}{OutputFileType} -crop {TileSize}x{TileSize} -set filename:tile %[fx:page.x/{TileSize}]_%[fx:page.y/{TileSize}] {OutputDirectory}/{fileNameOnly}/tiles/{scaleNum}_{TileName}_%[filename:tile]{OutputFileType}";

                    //GENERATING TILES

                    using (var proc = Process.Start(generator))
                    {
                        if (proc == null) return;
                        proc.WaitForExit();
                    }
                }
                catch (Exception exception)
                {
                    HandleException("generating tiles", exception.Message);
                }

                progress += (int)(scale * 500);
                _bw.ReportProgress((int)(progress / 2000d * 100d));
            }

            //DELETING THE WHITE TILES

            try
            {
                var whiteHash = getHash();

                // var whiteHash = HashImage((Bitmap)Image.FromFile("white.png"));

                if (SameFolder)
                    foreach (var file in Directory.GetFiles($"{OutputDirectory}/{fileNameOnly}/tiles"))
                    {
                        byte[] hash;
                        using (var bmpTemp = new Bitmap(file))
                        {
                            hash = HashImage(bmpTemp);
                        }
                        if (whiteHash.SequenceEqual(hash)) File.Delete(file);
                    }
                else
                    foreach (var file
                        in Directory.GetDirectories($"{OutputDirectory}/{fileNameOnly}")
                        .SelectMany(Directory.GetFiles))
                    {
                        byte[] hash;
                        using (var bmpTemp = new Bitmap(file))
                        {
                            hash = HashImage(bmpTemp);
                        }
                        if (whiteHash.SequenceEqual(hash)) File.Delete(file);
                    }
            }
            catch (Exception exception)
            {
                HandleException("deleting the white tiles", exception.Message);
            }

            //DELETING NOT USED FILES
            try
            {
                File.Delete($"{OutputDirectory}/{fileNameOnly}/{TileName}_background{OutputFileType}");
                File.Move($"{OutputDirectory}/{fileNameOnly}/{TileName}_scale_1{OutputFileType}", $"{OutputDirectory}/{fileNameOnly}/{TileName}_background{OutputFileType}");
                foreach (var file in Directory.GetFiles($"{OutputDirectory}/{fileNameOnly}", $"{TileName}_scale_*{OutputFileType}"))
                {
                    File.Delete(file);
                }
            }
            catch (Exception exception)
            {
                HandleException("Renaming", exception.Message);
                throw;
            }

            //ZIPPING TILES

            try
            {
                if (!SameFolder)
                {
                    File.Delete($"{OutputDirectory}/{fileNameOnly}-{TileSize}.zip");
                    ZipFile.CreateFromDirectory($"{OutputDirectory}/{fileNameOnly}", $"{OutputDirectory}/{fileNameOnly}-{TileSize}.zip");
                }

            }
            catch (Exception exception)
            {
                HandleException("zipping", exception.Message);
            }

            Process.Start(OutputDirectory);

            _bw.ReportProgress(100);
        }

        private byte[] getHash()
        {
            switch (TileSize)
            {

                case 256:
                    return new byte[] { 125, 44, 122, 196, 136, 139, 253, 117, 205, 95,
                        86, 232, 214, 31, 105, 89, 81, 33, 24, 58,
                        252, 129, 85, 108, 135, 103, 50, 253, 55, 130, 198, 47};
                case 512:
                    return new byte[]
                    {
                        45, 134, 76, 11, 120, 154, 67, 33, 78, 238,
                        133, 36, 211, 24, 32, 117, 18, 94, 92, 162,
                        205, 82, 127, 53, 130, 236, 135, 255, 217, 64,
                        118, 188
                    };
                default:
                    throw new Exception("cannot get the hash for an image with tilesize " + TileSize);
            }
        }


        public static void HandleException(string work, string message)
        {
            MessageBox.Show($"Exeption while {work}:{Environment.NewLine}" +
                            $"Exception message: {message}");
        }
    }
}