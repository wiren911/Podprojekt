namespace RSSReader
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.displayPod = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.playMusic = new System.Windows.Forms.Button();
            this.downloadMusic = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.Label();
            this.dtextfild = new System.Windows.Forms.TextBox();
            this.displayPodCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RssUrl = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.seePods = new System.Windows.Forms.Button();
            this.btnGetXML = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.closeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GetRss = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.displayPodCasts = new System.Windows.Forms.ListBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // displayPod
            // 
            this.displayPod.BackColor = System.Drawing.SystemColors.Window;
            this.displayPod.ForeColor = System.Drawing.Color.Black;
            this.displayPod.FormattingEnabled = true;
            this.displayPod.Location = new System.Drawing.Point(300, 165);
            this.displayPod.Name = "displayPod";
            this.displayPod.Size = new System.Drawing.Size(330, 212);
            this.displayPod.TabIndex = 2;
            this.displayPod.SelectedIndexChanged += new System.EventHandler(this.displayPodCategory_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.playMusic);
            this.panel2.Controls.Add(this.downloadMusic);
            this.panel2.Controls.Add(this.load);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.dtextfild);
            this.panel2.Controls.Add(this.displayPodCategory);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.RssUrl);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.seePods);
            this.panel2.Controls.Add(this.btnGetXML);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 446);
            this.panel2.TabIndex = 4;
            // 
            // playMusic
            // 
            this.playMusic.Location = new System.Drawing.Point(12, 295);
            this.playMusic.Name = "playMusic";
            this.playMusic.Size = new System.Drawing.Size(75, 23);
            this.playMusic.TabIndex = 15;
            this.playMusic.Text = "Play";
            this.playMusic.UseVisualStyleBackColor = true;
            this.playMusic.Click += new System.EventHandler(this.playMusic_Click);
            // 
            // downloadMusic
            // 
            this.downloadMusic.Location = new System.Drawing.Point(12, 266);
            this.downloadMusic.Name = "downloadMusic";
            this.downloadMusic.Size = new System.Drawing.Size(75, 23);
            this.downloadMusic.TabIndex = 14;
            this.downloadMusic.Text = "button2";
            this.downloadMusic.UseVisualStyleBackColor = true;
            this.downloadMusic.Click += new System.EventHandler(this.downloadMusic_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(178, 263);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 13;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(187, 245);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 15);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.Text = "Visit link";
            // 
            // dtextfild
            // 
            this.dtextfild.Location = new System.Drawing.Point(147, 179);
            this.dtextfild.Name = "dtextfild";
            this.dtextfild.Size = new System.Drawing.Size(121, 21);
            this.dtextfild.TabIndex = 11;
            // 
            // displayPodCategory
            // 
            this.displayPodCategory.FormattingEnabled = true;
            this.displayPodCategory.Location = new System.Drawing.Point(147, 208);
            this.displayPodCategory.Name = "displayPodCategory";
            this.displayPodCategory.Size = new System.Drawing.Size(121, 23);
            this.displayPodCategory.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "addList";
            // 
            // RssUrl
            // 
            this.RssUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RssUrl.Location = new System.Drawing.Point(39, 101);
            this.RssUrl.Name = "RssUrl";
            this.RssUrl.Size = new System.Drawing.Size(162, 26);
            this.RssUrl.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(12, 237);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Avsnitt";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // seePods
            // 
            this.seePods.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.seePods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seePods.Location = new System.Drawing.Point(12, 208);
            this.seePods.Name = "seePods";
            this.seePods.Size = new System.Drawing.Size(75, 23);
            this.seePods.TabIndex = 5;
            this.seePods.Text = "Program";
            this.seePods.UseVisualStyleBackColor = false;
            // 
            // btnGetXML
            // 
            this.btnGetXML.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGetXML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetXML.Location = new System.Drawing.Point(12, 179);
            this.btnGetXML.Name = "btnGetXML";
            this.btnGetXML.Size = new System.Drawing.Size(75, 23);
            this.btnGetXML.TabIndex = 4;
            this.btnGetXML.Text = "Hem";
            this.btnGetXML.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ImageIndex = 2;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(21, -2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 26);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Button-Blank-Green-icon.png");
            this.imageList1.Images.SetKeyName(1, "Button-Blank-Red-icon.png");
            this.imageList1.Images.SetKeyName(2, "Button-Blank-Yellow-icon.png");
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.ImageIndex = 1;
            this.closeButton.ImageList = this.imageList1;
            this.closeButton.Location = new System.Drawing.Point(-2, -2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(26, 26);
            this.closeButton.TabIndex = 2;
            this.closeButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(48, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 26);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::RSSReader.Properties.Resources.Orb_podcast_icon;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.GetRss);
            this.panel4.Location = new System.Drawing.Point(12, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(192, 38);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::RSSReader.Properties.Resources.search_icon;
            this.pictureBox1.Location = new System.Drawing.Point(166, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // GetRss
            // 
            this.GetRss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetRss.Location = new System.Drawing.Point(30, 3);
            this.GetRss.Name = "GetRss";
            this.GetRss.Size = new System.Drawing.Size(159, 26);
            this.GetRss.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(291, 389);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(777, 57);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RSSReader.Properties.Resources.podcast_2659526_960_720;
            this.pictureBox2.Location = new System.Drawing.Point(9, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(124, 9);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(650, 45);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BackgroundImage = global::RSSReader.Properties.Resources._2000px_Podcast_icon_svg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(291, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 164);
            this.panel1.TabIndex = 3;
            // 
            // displayPodCasts
            // 
            this.displayPodCasts.FormattingEnabled = true;
            this.displayPodCasts.Location = new System.Drawing.Point(656, 165);
            this.displayPodCasts.Name = "displayPodCasts";
            this.displayPodCasts.Size = new System.Drawing.Size(273, 212);
            this.displayPodCasts.TabIndex = 6;
            this.displayPodCasts.SelectedIndexChanged += new System.EventHandler(this.displayPodCasts_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 446);
            this.Controls.Add(this.displayPodCasts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.displayPod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox displayPod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox GetRss;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button seePods;
        private System.Windows.Forms.Button btnGetXML;
        private System.Windows.Forms.PictureBox pictureBox2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RssUrl;
        private System.Windows.Forms.TextBox dtextfild;
        private System.Windows.Forms.ComboBox displayPodCategory;
        private System.Windows.Forms.Label linkLabel1;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.ListBox displayPodCasts;
        private System.Windows.Forms.Button downloadMusic;
        private System.Windows.Forms.Button playMusic;
    }
}

