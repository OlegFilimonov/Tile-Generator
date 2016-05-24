using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO.Compression;
using static System.Math;

namespace TileGenerator
{
    public partial class Form1 : MaterialForm
    {

        private TileGenerator _tileGenerator;
        private Image img;

        public Form1()
        {
            InitializeComponent();

            _tileGenerator = new TileGenerator();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue800, Primary.Blue300, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            var outputFileType = "";
            if (pngRadioButton.Checked) outputFileType = ".png";
            else if (jpgRadioButton.Checked) outputFileType = ".jpg";
            else if (gifRadioButton.Checked) outputFileType = ".gif";

            _tileGenerator.InitBackgroundWorker(ProgressChanged);
            try
            {
                if(img == null) throw new Exception("Image is null");
                _tileGenerator.RunAsync(inputImageTextField.Text, outputImageTextField.Text,
                imageMagickPathTextField.Text, tileSizeTextField.Text, tileNameTextField.Text, outputFileType,img);
                materialFlatButton1.Text = "Generating...";
                materialFlatButton1.Enabled = false;
            }
            catch (Exception exception)
            {
                ProgressChanged(null,new ProgressChangedEventArgs(100,null));
                MessageBox.Show($"Exeption while preparing for generation:{Environment.NewLine}" +
                 $"Exception message: {exception.Message}");
            }
            

        }

        private void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            if (progressBar1.Value != 100) return;
            materialFlatButton1.Enabled = true;
            materialFlatButton1.Text = "GENERATE";
            progressBar1.Value = 0;
        }

        private void imageMagickPathTextField_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                imageMagickPathTextField.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void inputImageTextField_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            inputImageTextField.Text = openFileDialog.FileName;

            img = null;
            GC.Collect();
            img = Image.FromFile(inputImageTextField.Text);

            var tileSize = tileSizeTextField.Text.Equals("")
                ? 512
                : int.Parse(tileSizeTextField.Text);

            var maxZoomLevel = (int)Ceiling(Log(Max(img.Width, img.Height), 2)) - Log(tileSize,2);

            var divisibleBy = tileSize * Pow(2, maxZoomLevel - 2);

            var width = (int)(divisibleBy * Ceiling(img.Width / divisibleBy));
            var height = (int)(divisibleBy * Ceiling(img.Height / divisibleBy));

            var size = Max(width, height);

            logTextView.Text =
                $"The image size is {img.Width}x{img.Height}. This means there will be {maxZoomLevel} zoom levels. " +
                $"{Environment.NewLine}Image will be resized to a {size}x{size}";
        }

        private void outputImageTextField_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                outputImageTextField.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}