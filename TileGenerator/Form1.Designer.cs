namespace TileGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.inputImageTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.outputImageTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.imageMagickPathTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.pngRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.jpgRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.gifRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.tileSizeTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tileNameTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.logTextView = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.sameNameCheckbox = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 447);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(518, 36);
            this.progressBar1.TabIndex = 2;
            // 
            // inputImageTextField
            // 
            this.inputImageTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputImageTextField.Depth = 0;
            this.inputImageTextField.Hint = "";
            this.inputImageTextField.Location = new System.Drawing.Point(219, 117);
            this.inputImageTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputImageTextField.Name = "inputImageTextField";
            this.inputImageTextField.PasswordChar = '\0';
            this.inputImageTextField.SelectedText = "";
            this.inputImageTextField.SelectionLength = 0;
            this.inputImageTextField.SelectionStart = 0;
            this.inputImageTextField.Size = new System.Drawing.Size(418, 28);
            this.inputImageTextField.TabIndex = 4;
            this.inputImageTextField.UseSystemPasswordChar = false;
            this.inputImageTextField.Click += new System.EventHandler(this.inputImageTextField_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(88, 117);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(155, 24);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Input image file*:";
            // 
            // outputImageTextField
            // 
            this.outputImageTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputImageTextField.Depth = 0;
            this.outputImageTextField.Hint = "C:/Tiles";
            this.outputImageTextField.Location = new System.Drawing.Point(219, 151);
            this.outputImageTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.outputImageTextField.Name = "outputImageTextField";
            this.outputImageTextField.PasswordChar = '\0';
            this.outputImageTextField.SelectedText = "";
            this.outputImageTextField.SelectionLength = 0;
            this.outputImageTextField.SelectionStart = 0;
            this.outputImageTextField.Size = new System.Drawing.Size(418, 28);
            this.outputImageTextField.TabIndex = 4;
            this.outputImageTextField.UseSystemPasswordChar = false;
            this.outputImageTextField.Click += new System.EventHandler(this.outputImageTextField_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(46, 151);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(208, 24);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Output image directory:";
            // 
            // imageMagickPathTextField
            // 
            this.imageMagickPathTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageMagickPathTextField.Depth = 0;
            this.imageMagickPathTextField.Hint = "%programFiles%/ImageMagick-6.9.3-Q16";
            this.imageMagickPathTextField.Location = new System.Drawing.Point(219, 83);
            this.imageMagickPathTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.imageMagickPathTextField.Name = "imageMagickPathTextField";
            this.imageMagickPathTextField.PasswordChar = '\0';
            this.imageMagickPathTextField.SelectedText = "";
            this.imageMagickPathTextField.SelectionLength = 0;
            this.imageMagickPathTextField.SelectionStart = 0;
            this.imageMagickPathTextField.Size = new System.Drawing.Size(418, 28);
            this.imageMagickPathTextField.TabIndex = 4;
            this.imageMagickPathTextField.UseSystemPasswordChar = false;
            this.imageMagickPathTextField.Click += new System.EventHandler(this.imageMagickPathTextField_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(50, 83);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(204, 24);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Path to ImageMagick*:";
            // 
            // pngRadioButton
            // 
            this.pngRadioButton.AutoSize = true;
            this.pngRadioButton.Checked = true;
            this.pngRadioButton.Depth = 0;
            this.pngRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.pngRadioButton.Location = new System.Drawing.Point(220, 250);
            this.pngRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.pngRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.pngRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.pngRadioButton.Name = "pngRadioButton";
            this.pngRadioButton.Ripple = true;
            this.pngRadioButton.Size = new System.Drawing.Size(65, 30);
            this.pngRadioButton.TabIndex = 6;
            this.pngRadioButton.TabStop = true;
            this.pngRadioButton.Text = "PNG";
            this.pngRadioButton.UseVisualStyleBackColor = true;
            // 
            // jpgRadioButton
            // 
            this.jpgRadioButton.AutoSize = true;
            this.jpgRadioButton.Depth = 0;
            this.jpgRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.jpgRadioButton.Location = new System.Drawing.Point(294, 250);
            this.jpgRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.jpgRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.jpgRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.jpgRadioButton.Name = "jpgRadioButton";
            this.jpgRadioButton.Ripple = true;
            this.jpgRadioButton.Size = new System.Drawing.Size(62, 30);
            this.jpgRadioButton.TabIndex = 6;
            this.jpgRadioButton.Text = "JPG";
            this.jpgRadioButton.UseVisualStyleBackColor = true;
            // 
            // gifRadioButton
            // 
            this.gifRadioButton.AutoSize = true;
            this.gifRadioButton.Depth = 0;
            this.gifRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.gifRadioButton.Location = new System.Drawing.Point(365, 250);
            this.gifRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.gifRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.gifRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.gifRadioButton.Name = "gifRadioButton";
            this.gifRadioButton.Ripple = true;
            this.gifRadioButton.Size = new System.Drawing.Size(56, 30);
            this.gifRadioButton.TabIndex = 6;
            this.gifRadioButton.Text = "GIF";
            this.gifRadioButton.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(58, 250);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(191, 24);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Output image format:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(141, 185);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(85, 24);
            this.materialLabel5.TabIndex = 5;
            this.materialLabel5.Text = "Tile size:";
            // 
            // tileSizeTextField
            // 
            this.tileSizeTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileSizeTextField.Depth = 0;
            this.tileSizeTextField.Hint = "512";
            this.tileSizeTextField.Location = new System.Drawing.Point(220, 185);
            this.tileSizeTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.tileSizeTextField.Name = "tileSizeTextField";
            this.tileSizeTextField.PasswordChar = '\0';
            this.tileSizeTextField.SelectedText = "";
            this.tileSizeTextField.SelectionLength = 0;
            this.tileSizeTextField.SelectionStart = 0;
            this.tileSizeTextField.Size = new System.Drawing.Size(418, 28);
            this.tileSizeTextField.TabIndex = 4;
            this.tileSizeTextField.UseSystemPasswordChar = false;
            // 
            // tileNameTextField
            // 
            this.tileNameTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileNameTextField.Depth = 0;
            this.tileNameTextField.Hint = "Same as the filename";
            this.tileNameTextField.Location = new System.Drawing.Point(220, 219);
            this.tileNameTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.tileNameTextField.Name = "tileNameTextField";
            this.tileNameTextField.PasswordChar = '\0';
            this.tileNameTextField.SelectedText = "";
            this.tileNameTextField.SelectionLength = 0;
            this.tileNameTextField.SelectionStart = 0;
            this.tileNameTextField.Size = new System.Drawing.Size(418, 28);
            this.tileNameTextField.TabIndex = 4;
            this.tileNameTextField.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(109, 219);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(130, 24);
            this.materialLabel6.TabIndex = 5;
            this.materialLabel6.Text = "Tile file name:";
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-2, 296);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(652, 12);
            this.materialDivider1.TabIndex = 8;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // logTextView
            // 
            this.logTextView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextView.Depth = 0;
            this.logTextView.Font = new System.Drawing.Font("Roboto", 11F);
            this.logTextView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logTextView.Location = new System.Drawing.Point(12, 318);
            this.logTextView.MouseState = MaterialSkin.MouseState.HOVER;
            this.logTextView.Name = "logTextView";
            this.logTextView.Size = new System.Drawing.Size(625, 117);
            this.logTextView.TabIndex = 5;
            this.logTextView.Text = "Click on the text fields to specify path to imageMagick and input image file";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(537, 447);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(99, 36);
            this.materialFlatButton1.TabIndex = 9;
            this.materialFlatButton1.Text = "GENERATE";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // sameNameCheckbox
            // 
            this.sameNameCheckbox.AutoSize = true;
            this.sameNameCheckbox.Depth = 0;
            this.sameNameCheckbox.Font = new System.Drawing.Font("Roboto", 10F);
            this.sameNameCheckbox.Location = new System.Drawing.Point(450, 251);
            this.sameNameCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.sameNameCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.sameNameCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.sameNameCheckbox.Name = "sameNameCheckbox";
            this.sameNameCheckbox.Ripple = true;
            this.sameNameCheckbox.Size = new System.Drawing.Size(217, 30);
            this.sameNameCheckbox.TabIndex = 10;
            this.sameNameCheckbox.Text = "Put all files in one folder";
            this.sameNameCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 492);
            this.Controls.Add(this.sameNameCheckbox);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.gifRadioButton);
            this.Controls.Add(this.jpgRadioButton);
            this.Controls.Add(this.pngRadioButton);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.imageMagickPathTextField);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.logTextView);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.tileNameTextField);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.tileSizeTextField);
            this.Controls.Add(this.outputImageTextField);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.inputImageTextField);
            this.Controls.Add(this.progressBar1);
            this.Font = new System.Drawing.Font("Roboto", 8F);
            this.Name = "Form1";
            this.Text = "Tile generator v0.4.4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ProgressBar progressBar1;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputImageTextField;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField outputImageTextField;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField imageMagickPathTextField;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRadioButton pngRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton jpgRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton gifRadioButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField tileSizeTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField tileNameTextField;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel logTextView;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialCheckBox sameNameCheckbox;
    }
}

