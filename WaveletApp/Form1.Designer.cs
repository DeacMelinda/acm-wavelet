namespace WaveletApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.originalImageBox = new System.Windows.Forms.PictureBox();
            this.originalImageLabel = new System.Windows.Forms.Label();
            this.waveletImageLabel = new System.Windows.Forms.Label();
            this.waveletImageBox = new System.Windows.Forms.PictureBox();
            this.originalmageLoadButton = new System.Windows.Forms.Button();
            this.originalImageNameLabel = new System.Windows.Forms.Label();
            this.minMaxErrorButton = new System.Windows.Forms.Button();
            this.minErrorTextBox = new System.Windows.Forms.TextBox();
            this.maxErrorTextBox = new System.Windows.Forms.TextBox();
            this.minErrorLabel = new System.Windows.Forms.Label();
            this.maxErrorLabel = new System.Windows.Forms.Label();
            this.waveletImageSaveButton = new System.Windows.Forms.Button();
            this.waveletImageLoadButton = new System.Windows.Forms.Button();
            this.waveletRefreshButton = new System.Windows.Forms.Button();
            this.scaleTextBox = new System.Windows.Forms.TextBox();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.offsetLabel = new System.Windows.Forms.Label();
            this.offsetTextBox = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yLabel = new System.Windows.Forms.Label();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.AnH1Button = new System.Windows.Forms.Button();
            this.AnV1Button = new System.Windows.Forms.Button();
            this.AnH2Button = new System.Windows.Forms.Button();
            this.AnV2Button = new System.Windows.Forms.Button();
            this.AnH3Button = new System.Windows.Forms.Button();
            this.AnV3Button = new System.Windows.Forms.Button();
            this.AnV5Button = new System.Windows.Forms.Button();
            this.AnH5Button = new System.Windows.Forms.Button();
            this.AnV4Button = new System.Windows.Forms.Button();
            this.AnH4Button = new System.Windows.Forms.Button();
            this.SyV5Button = new System.Windows.Forms.Button();
            this.SyH5Button = new System.Windows.Forms.Button();
            this.SyV4Button = new System.Windows.Forms.Button();
            this.SyH4Button = new System.Windows.Forms.Button();
            this.SyV3Button = new System.Windows.Forms.Button();
            this.SyH3Button = new System.Windows.Forms.Button();
            this.SyV2Button = new System.Windows.Forms.Button();
            this.SyH2Button = new System.Windows.Forms.Button();
            this.SyV1Button = new System.Windows.Forms.Button();
            this.SyH1Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.originalImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveletImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // originalImageBox
            // 
            this.originalImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalImageBox.Location = new System.Drawing.Point(15, 38);
            this.originalImageBox.Name = "originalImageBox";
            this.originalImageBox.Size = new System.Drawing.Size(512, 512);
            this.originalImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.originalImageBox.TabIndex = 0;
            this.originalImageBox.TabStop = false;
            // 
            // originalImageLabel
            // 
            this.originalImageLabel.AutoSize = true;
            this.originalImageLabel.Location = new System.Drawing.Point(12, 19);
            this.originalImageLabel.Name = "originalImageLabel";
            this.originalImageLabel.Size = new System.Drawing.Size(94, 16);
            this.originalImageLabel.TabIndex = 1;
            this.originalImageLabel.Text = "Original Image";
            // 
            // waveletImageLabel
            // 
            this.waveletImageLabel.AutoSize = true;
            this.waveletImageLabel.Location = new System.Drawing.Point(558, 19);
            this.waveletImageLabel.Name = "waveletImageLabel";
            this.waveletImageLabel.Size = new System.Drawing.Size(98, 16);
            this.waveletImageLabel.TabIndex = 3;
            this.waveletImageLabel.Text = "Wavelet Image";
            // 
            // waveletImageBox
            // 
            this.waveletImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.waveletImageBox.Location = new System.Drawing.Point(561, 38);
            this.waveletImageBox.Name = "waveletImageBox";
            this.waveletImageBox.Size = new System.Drawing.Size(512, 512);
            this.waveletImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.waveletImageBox.TabIndex = 2;
            this.waveletImageBox.TabStop = false;
            // 
            // originalmageLoadButton
            // 
            this.originalmageLoadButton.Location = new System.Drawing.Point(15, 567);
            this.originalmageLoadButton.Name = "originalmageLoadButton";
            this.originalmageLoadButton.Size = new System.Drawing.Size(75, 23);
            this.originalmageLoadButton.TabIndex = 4;
            this.originalmageLoadButton.Text = "Load";
            this.originalmageLoadButton.UseVisualStyleBackColor = true;
            this.originalmageLoadButton.Click += new System.EventHandler(this.originalmageLoadButton_Click);
            // 
            // originalImageNameLabel
            // 
            this.originalImageNameLabel.AutoSize = true;
            this.originalImageNameLabel.Location = new System.Drawing.Point(149, 574);
            this.originalImageNameLabel.Name = "originalImageNameLabel";
            this.originalImageNameLabel.Size = new System.Drawing.Size(0, 16);
            this.originalImageNameLabel.TabIndex = 5;
            // 
            // minMaxErrorButton
            // 
            this.minMaxErrorButton.Location = new System.Drawing.Point(12, 638);
            this.minMaxErrorButton.Name = "minMaxErrorButton";
            this.minMaxErrorButton.Size = new System.Drawing.Size(78, 47);
            this.minMaxErrorButton.TabIndex = 6;
            this.minMaxErrorButton.Text = "Min Max Error";
            this.minMaxErrorButton.UseVisualStyleBackColor = true;
            this.minMaxErrorButton.Click += new System.EventHandler(this.minMaxErrorButton_Click);
            // 
            // minErrorTextBox
            // 
            this.minErrorTextBox.Location = new System.Drawing.Point(152, 638);
            this.minErrorTextBox.Name = "minErrorTextBox";
            this.minErrorTextBox.Size = new System.Drawing.Size(100, 22);
            this.minErrorTextBox.TabIndex = 7;
            // 
            // maxErrorTextBox
            // 
            this.maxErrorTextBox.Location = new System.Drawing.Point(152, 666);
            this.maxErrorTextBox.Name = "maxErrorTextBox";
            this.maxErrorTextBox.Size = new System.Drawing.Size(100, 22);
            this.maxErrorTextBox.TabIndex = 8;
            // 
            // minErrorLabel
            // 
            this.minErrorLabel.AutoSize = true;
            this.minErrorLabel.Location = new System.Drawing.Point(115, 641);
            this.minErrorLabel.Name = "minErrorLabel";
            this.minErrorLabel.Size = new System.Drawing.Size(31, 16);
            this.minErrorLabel.TabIndex = 9;
            this.minErrorLabel.Text = "Min:";
            // 
            // maxErrorLabel
            // 
            this.maxErrorLabel.AutoSize = true;
            this.maxErrorLabel.Location = new System.Drawing.Point(115, 666);
            this.maxErrorLabel.Name = "maxErrorLabel";
            this.maxErrorLabel.Size = new System.Drawing.Size(35, 16);
            this.maxErrorLabel.TabIndex = 10;
            this.maxErrorLabel.Text = "Max:";
            // 
            // waveletImageSaveButton
            // 
            this.waveletImageSaveButton.Location = new System.Drawing.Point(561, 567);
            this.waveletImageSaveButton.Name = "waveletImageSaveButton";
            this.waveletImageSaveButton.Size = new System.Drawing.Size(75, 23);
            this.waveletImageSaveButton.TabIndex = 11;
            this.waveletImageSaveButton.Text = "Save";
            this.waveletImageSaveButton.UseVisualStyleBackColor = true;
            // 
            // waveletImageLoadButton
            // 
            this.waveletImageLoadButton.Location = new System.Drawing.Point(561, 596);
            this.waveletImageLoadButton.Name = "waveletImageLoadButton";
            this.waveletImageLoadButton.Size = new System.Drawing.Size(75, 23);
            this.waveletImageLoadButton.TabIndex = 12;
            this.waveletImageLoadButton.Text = "Load";
            this.waveletImageLoadButton.UseVisualStyleBackColor = true;
            // 
            // waveletRefreshButton
            // 
            this.waveletRefreshButton.Location = new System.Drawing.Point(891, 583);
            this.waveletRefreshButton.Name = "waveletRefreshButton";
            this.waveletRefreshButton.Size = new System.Drawing.Size(75, 23);
            this.waveletRefreshButton.TabIndex = 13;
            this.waveletRefreshButton.Text = "Refresh";
            this.waveletRefreshButton.UseVisualStyleBackColor = true;
            this.waveletRefreshButton.Click += new System.EventHandler(this.waveletRefreshButton_Click);
            // 
            // scaleTextBox
            // 
            this.scaleTextBox.Location = new System.Drawing.Point(1159, 59);
            this.scaleTextBox.Name = "scaleTextBox";
            this.scaleTextBox.Size = new System.Drawing.Size(100, 22);
            this.scaleTextBox.TabIndex = 14;
            // 
            // scaleLabel
            // 
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.Location = new System.Drawing.Point(1113, 62);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(40, 16);
            this.scaleLabel.TabIndex = 15;
            this.scaleLabel.Text = "scale";
            // 
            // offsetLabel
            // 
            this.offsetLabel.AutoSize = true;
            this.offsetLabel.Location = new System.Drawing.Point(1113, 90);
            this.offsetLabel.Name = "offsetLabel";
            this.offsetLabel.Size = new System.Drawing.Size(39, 16);
            this.offsetLabel.TabIndex = 17;
            this.offsetLabel.Text = "offset";
            // 
            // offsetTextBox
            // 
            this.offsetTextBox.Location = new System.Drawing.Point(1159, 87);
            this.offsetTextBox.Name = "offsetTextBox";
            this.offsetTextBox.Size = new System.Drawing.Size(100, 22);
            this.offsetTextBox.TabIndex = 16;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(1139, 118);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(13, 16);
            this.xLabel.TabIndex = 19;
            this.xLabel.Text = "x";
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(1159, 115);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(100, 22);
            this.xTextBox.TabIndex = 18;
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(1138, 146);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(14, 16);
            this.yLabel.TabIndex = 21;
            this.yLabel.Text = "y";
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(1159, 143);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(100, 22);
            this.yTextBox.TabIndex = 20;
            // 
            // AnH1Button
            // 
            this.AnH1Button.Location = new System.Drawing.Point(1093, 224);
            this.AnH1Button.Name = "AnH1Button";
            this.AnH1Button.Size = new System.Drawing.Size(75, 42);
            this.AnH1Button.TabIndex = 22;
            this.AnH1Button.Text = "AnH1";
            this.AnH1Button.UseVisualStyleBackColor = true;
            this.AnH1Button.Click += new System.EventHandler(this.AnH1Button_Click);
            // 
            // AnV1Button
            // 
            this.AnV1Button.Location = new System.Drawing.Point(1093, 272);
            this.AnV1Button.Name = "AnV1Button";
            this.AnV1Button.Size = new System.Drawing.Size(75, 42);
            this.AnV1Button.TabIndex = 23;
            this.AnV1Button.Text = "AnV1";
            this.AnV1Button.UseVisualStyleBackColor = true;
            this.AnV1Button.Click += new System.EventHandler(this.AnV1Button_Click);
            // 
            // AnH2Button
            // 
            this.AnH2Button.Location = new System.Drawing.Point(1093, 320);
            this.AnH2Button.Name = "AnH2Button";
            this.AnH2Button.Size = new System.Drawing.Size(75, 42);
            this.AnH2Button.TabIndex = 24;
            this.AnH2Button.Text = "AnH2";
            this.AnH2Button.UseVisualStyleBackColor = true;
            this.AnH2Button.Click += new System.EventHandler(this.AnH2Button_Click);
            // 
            // AnV2Button
            // 
            this.AnV2Button.Location = new System.Drawing.Point(1093, 368);
            this.AnV2Button.Name = "AnV2Button";
            this.AnV2Button.Size = new System.Drawing.Size(75, 42);
            this.AnV2Button.TabIndex = 25;
            this.AnV2Button.Text = "AnV2";
            this.AnV2Button.UseVisualStyleBackColor = true;
            this.AnV2Button.Click += new System.EventHandler(this.AnV2Button_Click);
            // 
            // AnH3Button
            // 
            this.AnH3Button.Location = new System.Drawing.Point(1093, 416);
            this.AnH3Button.Name = "AnH3Button";
            this.AnH3Button.Size = new System.Drawing.Size(75, 42);
            this.AnH3Button.TabIndex = 26;
            this.AnH3Button.Text = "AnH3";
            this.AnH3Button.UseVisualStyleBackColor = true;
            this.AnH3Button.Click += new System.EventHandler(this.AnH3Button_Click);
            // 
            // AnV3Button
            // 
            this.AnV3Button.Location = new System.Drawing.Point(1093, 464);
            this.AnV3Button.Name = "AnV3Button";
            this.AnV3Button.Size = new System.Drawing.Size(75, 42);
            this.AnV3Button.TabIndex = 27;
            this.AnV3Button.Text = "AnV3";
            this.AnV3Button.UseVisualStyleBackColor = true;
            this.AnV3Button.Click += new System.EventHandler(this.AnV3Button_Click);
            // 
            // AnV5Button
            // 
            this.AnV5Button.Location = new System.Drawing.Point(1093, 656);
            this.AnV5Button.Name = "AnV5Button";
            this.AnV5Button.Size = new System.Drawing.Size(75, 42);
            this.AnV5Button.TabIndex = 31;
            this.AnV5Button.Text = "AnV5";
            this.AnV5Button.UseVisualStyleBackColor = true;
            this.AnV5Button.Click += new System.EventHandler(this.AnV5Button_Click);
            // 
            // AnH5Button
            // 
            this.AnH5Button.Location = new System.Drawing.Point(1093, 608);
            this.AnH5Button.Name = "AnH5Button";
            this.AnH5Button.Size = new System.Drawing.Size(75, 42);
            this.AnH5Button.TabIndex = 30;
            this.AnH5Button.Text = "AnH5";
            this.AnH5Button.UseVisualStyleBackColor = true;
            this.AnH5Button.Click += new System.EventHandler(this.AnH5Button_Click);
            // 
            // AnV4Button
            // 
            this.AnV4Button.Location = new System.Drawing.Point(1093, 560);
            this.AnV4Button.Name = "AnV4Button";
            this.AnV4Button.Size = new System.Drawing.Size(75, 42);
            this.AnV4Button.TabIndex = 29;
            this.AnV4Button.Text = "AnV4";
            this.AnV4Button.UseVisualStyleBackColor = true;
            this.AnV4Button.Click += new System.EventHandler(this.AnV4Button_Click);
            // 
            // AnH4Button
            // 
            this.AnH4Button.Location = new System.Drawing.Point(1093, 512);
            this.AnH4Button.Name = "AnH4Button";
            this.AnH4Button.Size = new System.Drawing.Size(75, 42);
            this.AnH4Button.TabIndex = 28;
            this.AnH4Button.Text = "AnH4";
            this.AnH4Button.UseVisualStyleBackColor = true;
            this.AnH4Button.Click += new System.EventHandler(this.AnH4Button_Click);
            // 
            // SyV5Button
            // 
            this.SyV5Button.Location = new System.Drawing.Point(1244, 656);
            this.SyV5Button.Name = "SyV5Button";
            this.SyV5Button.Size = new System.Drawing.Size(75, 42);
            this.SyV5Button.TabIndex = 41;
            this.SyV5Button.Text = "SyV5";
            this.SyV5Button.UseVisualStyleBackColor = true;
            this.SyV5Button.Click += new System.EventHandler(this.SyV5Button_Click);
            // 
            // SyH5Button
            // 
            this.SyH5Button.Location = new System.Drawing.Point(1244, 608);
            this.SyH5Button.Name = "SyH5Button";
            this.SyH5Button.Size = new System.Drawing.Size(75, 42);
            this.SyH5Button.TabIndex = 40;
            this.SyH5Button.Text = "SyH5";
            this.SyH5Button.UseVisualStyleBackColor = true;
            this.SyH5Button.Click += new System.EventHandler(this.SyH5Button_Click);
            // 
            // SyV4Button
            // 
            this.SyV4Button.Location = new System.Drawing.Point(1244, 560);
            this.SyV4Button.Name = "SyV4Button";
            this.SyV4Button.Size = new System.Drawing.Size(75, 42);
            this.SyV4Button.TabIndex = 39;
            this.SyV4Button.Text = "SyV4";
            this.SyV4Button.UseVisualStyleBackColor = true;
            this.SyV4Button.Click += new System.EventHandler(this.SyV4Button_Click);
            // 
            // SyH4Button
            // 
            this.SyH4Button.Location = new System.Drawing.Point(1244, 512);
            this.SyH4Button.Name = "SyH4Button";
            this.SyH4Button.Size = new System.Drawing.Size(75, 42);
            this.SyH4Button.TabIndex = 38;
            this.SyH4Button.Text = "SyH4";
            this.SyH4Button.UseVisualStyleBackColor = true;
            this.SyH4Button.Click += new System.EventHandler(this.SyH4Button_Click);
            // 
            // SyV3Button
            // 
            this.SyV3Button.Location = new System.Drawing.Point(1244, 464);
            this.SyV3Button.Name = "SyV3Button";
            this.SyV3Button.Size = new System.Drawing.Size(75, 42);
            this.SyV3Button.TabIndex = 37;
            this.SyV3Button.Text = "SyV3";
            this.SyV3Button.UseVisualStyleBackColor = true;
            this.SyV3Button.Click += new System.EventHandler(this.SyV3Button_Click);
            // 
            // SyH3Button
            // 
            this.SyH3Button.Location = new System.Drawing.Point(1244, 416);
            this.SyH3Button.Name = "SyH3Button";
            this.SyH3Button.Size = new System.Drawing.Size(75, 42);
            this.SyH3Button.TabIndex = 36;
            this.SyH3Button.Text = "SyH3";
            this.SyH3Button.UseVisualStyleBackColor = true;
            this.SyH3Button.Click += new System.EventHandler(this.SyH3Button_Click);
            // 
            // SyV2Button
            // 
            this.SyV2Button.Location = new System.Drawing.Point(1244, 368);
            this.SyV2Button.Name = "SyV2Button";
            this.SyV2Button.Size = new System.Drawing.Size(75, 42);
            this.SyV2Button.TabIndex = 35;
            this.SyV2Button.Text = "SyV2";
            this.SyV2Button.UseVisualStyleBackColor = true;
            this.SyV2Button.Click += new System.EventHandler(this.SyV2Button_Click);
            // 
            // SyH2Button
            // 
            this.SyH2Button.Location = new System.Drawing.Point(1244, 320);
            this.SyH2Button.Name = "SyH2Button";
            this.SyH2Button.Size = new System.Drawing.Size(75, 42);
            this.SyH2Button.TabIndex = 34;
            this.SyH2Button.Text = "SyH2";
            this.SyH2Button.UseVisualStyleBackColor = true;
            this.SyH2Button.Click += new System.EventHandler(this.SyH2Button_Click);
            // 
            // SyV1Button
            // 
            this.SyV1Button.Location = new System.Drawing.Point(1244, 272);
            this.SyV1Button.Name = "SyV1Button";
            this.SyV1Button.Size = new System.Drawing.Size(75, 42);
            this.SyV1Button.TabIndex = 33;
            this.SyV1Button.Text = "SyV1";
            this.SyV1Button.UseVisualStyleBackColor = true;
            this.SyV1Button.Click += new System.EventHandler(this.SyV1Button_Click);
            // 
            // SyH1Button
            // 
            this.SyH1Button.Location = new System.Drawing.Point(1244, 224);
            this.SyH1Button.Name = "SyH1Button";
            this.SyH1Button.Size = new System.Drawing.Size(75, 42);
            this.SyH1Button.TabIndex = 32;
            this.SyH1Button.Text = "SyH1";
            this.SyH1Button.UseVisualStyleBackColor = true;
            this.SyH1Button.Click += new System.EventHandler(this.SyH1Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 749);
            this.Controls.Add(this.SyV5Button);
            this.Controls.Add(this.SyH5Button);
            this.Controls.Add(this.SyV4Button);
            this.Controls.Add(this.SyH4Button);
            this.Controls.Add(this.SyV3Button);
            this.Controls.Add(this.SyH3Button);
            this.Controls.Add(this.SyV2Button);
            this.Controls.Add(this.SyH2Button);
            this.Controls.Add(this.SyV1Button);
            this.Controls.Add(this.SyH1Button);
            this.Controls.Add(this.AnV5Button);
            this.Controls.Add(this.AnH5Button);
            this.Controls.Add(this.AnV4Button);
            this.Controls.Add(this.AnH4Button);
            this.Controls.Add(this.AnV3Button);
            this.Controls.Add(this.AnH3Button);
            this.Controls.Add(this.AnV2Button);
            this.Controls.Add(this.AnH2Button);
            this.Controls.Add(this.AnV1Button);
            this.Controls.Add(this.AnH1Button);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.offsetLabel);
            this.Controls.Add(this.offsetTextBox);
            this.Controls.Add(this.scaleLabel);
            this.Controls.Add(this.scaleTextBox);
            this.Controls.Add(this.waveletRefreshButton);
            this.Controls.Add(this.waveletImageLoadButton);
            this.Controls.Add(this.waveletImageSaveButton);
            this.Controls.Add(this.maxErrorLabel);
            this.Controls.Add(this.minErrorLabel);
            this.Controls.Add(this.maxErrorTextBox);
            this.Controls.Add(this.minErrorTextBox);
            this.Controls.Add(this.minMaxErrorButton);
            this.Controls.Add(this.originalImageNameLabel);
            this.Controls.Add(this.originalmageLoadButton);
            this.Controls.Add(this.waveletImageLabel);
            this.Controls.Add(this.waveletImageBox);
            this.Controls.Add(this.originalImageLabel);
            this.Controls.Add(this.originalImageBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.originalImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveletImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox originalImageBox;
        private System.Windows.Forms.Label originalImageLabel;
        private System.Windows.Forms.Label waveletImageLabel;
        private System.Windows.Forms.PictureBox waveletImageBox;
        private System.Windows.Forms.Button originalmageLoadButton;
        private System.Windows.Forms.Label originalImageNameLabel;
        private System.Windows.Forms.Button minMaxErrorButton;
        private System.Windows.Forms.TextBox minErrorTextBox;
        private System.Windows.Forms.TextBox maxErrorTextBox;
        private System.Windows.Forms.Label minErrorLabel;
        private System.Windows.Forms.Label maxErrorLabel;
        private System.Windows.Forms.Button waveletImageSaveButton;
        private System.Windows.Forms.Button waveletImageLoadButton;
        private System.Windows.Forms.Button waveletRefreshButton;
        private System.Windows.Forms.TextBox scaleTextBox;
        private System.Windows.Forms.Label scaleLabel;
        private System.Windows.Forms.Label offsetLabel;
        private System.Windows.Forms.TextBox offsetTextBox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.Button AnH1Button;
        private System.Windows.Forms.Button AnV1Button;
        private System.Windows.Forms.Button AnH2Button;
        private System.Windows.Forms.Button AnV2Button;
        private System.Windows.Forms.Button AnH3Button;
        private System.Windows.Forms.Button AnV3Button;
        private System.Windows.Forms.Button AnV5Button;
        private System.Windows.Forms.Button AnH5Button;
        private System.Windows.Forms.Button AnV4Button;
        private System.Windows.Forms.Button AnH4Button;
        private System.Windows.Forms.Button SyV5Button;
        private System.Windows.Forms.Button SyH5Button;
        private System.Windows.Forms.Button SyV4Button;
        private System.Windows.Forms.Button SyH4Button;
        private System.Windows.Forms.Button SyV3Button;
        private System.Windows.Forms.Button SyH3Button;
        private System.Windows.Forms.Button SyV2Button;
        private System.Windows.Forms.Button SyH2Button;
        private System.Windows.Forms.Button SyV1Button;
        private System.Windows.Forms.Button SyH1Button;
    }
}

