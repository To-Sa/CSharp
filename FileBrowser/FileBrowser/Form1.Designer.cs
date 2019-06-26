namespace FileBrowser
{
    partial class FileBrowser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileBrowser));
            this.mynotifyicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMaximizeBox = new System.Windows.Forms.Button();
            this.btnMinimizeBox = new System.Windows.Forms.Button();
            this.myWebBrowser = new System.Windows.Forms.WebBrowser();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rBtnPdf = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rBtnDoc = new System.Windows.Forms.RadioButton();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblDirName = new System.Windows.Forms.Label();
            this.rBtnAllFiles = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mynotifyicon
            // 
            this.mynotifyicon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.mynotifyicon.BalloonTipText = "Az alkalmazás a háttérben fut tovább!";
            this.mynotifyicon.BalloonTipTitle = "Fájlböngésző";
            this.mynotifyicon.Icon = ((System.Drawing.Icon)(resources.GetObject("mynotifyicon.Icon")));
            this.mynotifyicon.Text = "Fájlböngésző";
            this.mynotifyicon.Visible = true;
            this.mynotifyicon.Click += new System.EventHandler(this.mynotifyicon_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Location = new System.Drawing.Point(1171, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 27);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMaximizeBox
            // 
            this.btnMaximizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizeBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMaximizeBox.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizeBox.FlatAppearance.BorderSize = 0;
            this.btnMaximizeBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnMaximizeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMaximizeBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMaximizeBox.Location = new System.Drawing.Point(1140, 0);
            this.btnMaximizeBox.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximizeBox.Name = "btnMaximizeBox";
            this.btnMaximizeBox.Size = new System.Drawing.Size(31, 27);
            this.btnMaximizeBox.TabIndex = 2;
            this.btnMaximizeBox.Text = "[ ]";
            this.btnMaximizeBox.UseVisualStyleBackColor = false;
            this.btnMaximizeBox.Click += new System.EventHandler(this.btnMaximizeBox_Click);
            // 
            // btnMinimizeBox
            // 
            this.btnMinimizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizeBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMinimizeBox.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizeBox.FlatAppearance.BorderSize = 0;
            this.btnMinimizeBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnMinimizeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMinimizeBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinimizeBox.Location = new System.Drawing.Point(1109, 0);
            this.btnMinimizeBox.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizeBox.Name = "btnMinimizeBox";
            this.btnMinimizeBox.Size = new System.Drawing.Size(31, 27);
            this.btnMinimizeBox.TabIndex = 3;
            this.btnMinimizeBox.Text = "_";
            this.btnMinimizeBox.UseVisualStyleBackColor = false;
            this.btnMinimizeBox.Click += new System.EventHandler(this.btnMinimizeBox_Click);
            // 
            // myWebBrowser
            // 
            this.myWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myWebBrowser.Location = new System.Drawing.Point(5, 58);
            this.myWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.myWebBrowser.Name = "myWebBrowser";
            this.myWebBrowser.Size = new System.Drawing.Size(926, 657);
            this.myWebBrowser.TabIndex = 4;
            this.myWebBrowser.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(937, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(258, 598);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 5;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.listBox1.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.listBox1_MeasureItem);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // rBtnPdf
            // 
            this.rBtnPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rBtnPdf.AutoSize = true;
            this.rBtnPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rBtnPdf.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rBtnPdf.Location = new System.Drawing.Point(1016, 35);
            this.rBtnPdf.Name = "rBtnPdf";
            this.rBtnPdf.Size = new System.Drawing.Size(53, 17);
            this.rBtnPdf.TabIndex = 6;
            this.rBtnPdf.Text = ".PDF";
            this.rBtnPdf.UseVisualStyleBackColor = true;
            this.rBtnPdf.Click += new System.EventHandler(this.rBtnPdf_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(35, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(112, 17);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "File Browser v1.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // rBtnDoc
            // 
            this.rBtnDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rBtnDoc.AutoSize = true;
            this.rBtnDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rBtnDoc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rBtnDoc.Location = new System.Drawing.Point(1075, 35);
            this.rBtnDoc.Name = "rBtnDoc";
            this.rBtnDoc.Size = new System.Drawing.Size(55, 17);
            this.rBtnDoc.TabIndex = 9;
            this.rBtnDoc.Text = ".DOC";
            this.rBtnDoc.UseVisualStyleBackColor = true;
            this.rBtnDoc.Click += new System.EventHandler(this.rBtnDoc_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLocation.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLocation.Location = new System.Drawing.Point(5, 35);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(926, 20);
            this.lblLocation.TabIndex = 10;
            // 
            // lblDirName
            // 
            this.lblDirName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDirName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDirName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDirName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDirName.Location = new System.Drawing.Point(937, 58);
            this.lblDirName.Name = "lblDirName";
            this.lblDirName.Size = new System.Drawing.Size(258, 19);
            this.lblDirName.TabIndex = 11;
            this.lblDirName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDirName.DoubleClick += new System.EventHandler(this.lblDirName_DoubleClick);
            // 
            // rBtnAllFiles
            // 
            this.rBtnAllFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rBtnAllFiles.AutoSize = true;
            this.rBtnAllFiles.Checked = true;
            this.rBtnAllFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rBtnAllFiles.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rBtnAllFiles.Location = new System.Drawing.Point(937, 35);
            this.rBtnAllFiles.Name = "rBtnAllFiles";
            this.rBtnAllFiles.Size = new System.Drawing.Size(73, 17);
            this.rBtnAllFiles.TabIndex = 12;
            this.rBtnAllFiles.TabStop = true;
            this.rBtnAllFiles.Text = ".All Files";
            this.rBtnAllFiles.UseVisualStyleBackColor = true;
            this.rBtnAllFiles.Click += new System.EventHandler(this.rBtnAllFiles_Click);
            // 
            // FileBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.rBtnAllFiles);
            this.Controls.Add(this.lblDirName);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.rBtnDoc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.rBtnPdf);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.myWebBrowser);
            this.Controls.Add(this.btnMinimizeBox);
            this.Controls.Add(this.btnMaximizeBox);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "FileBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Browser";
            this.Load += new System.EventHandler(this.FileBrowser_Load);
            this.Resize += new System.EventHandler(this.FileBrowser_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon mynotifyicon;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMaximizeBox;
        private System.Windows.Forms.Button btnMinimizeBox;
        private System.Windows.Forms.WebBrowser myWebBrowser;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rBtnPdf;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rBtnDoc;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblDirName;
        private System.Windows.Forms.RadioButton rBtnAllFiles;
    }
}

