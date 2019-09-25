namespace Picture
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
            this.pct = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.img = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pct)).BeginInit();
            this.SuspendLayout();
            // 
            // pct
            // 
            this.pct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pct.ErrorImage = global::Picture.Properties.Resources.images__2_;
            this.pct.Location = new System.Drawing.Point(12, 12);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(696, 391);
            this.pct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct.TabIndex = 0;
            this.pct.TabStop = false;
            this.pct.Click += new System.EventHandler(this.pct_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 423);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(381, 23);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.EnabledChanged += new System.EventHandler(this.progressBar1_EnabledChanged);
            // 
            // img
            // 
            this.img.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img.ImageStream")));
            this.img.TransparentColor = System.Drawing.Color.Transparent;
            this.img.Images.SetKeyName(0, "1533648769_ячячсчсч.png");
            this.img.Images.SetKeyName(1, "kisspng-2017-maserati-levante-s-car-sport-utility-vehicle-5b0914aa0bd3e1.16940161" +
        "15273217700485.jpg");
            this.img.Images.SetKeyName(2, "kisspng-car-rental-luxury-vehicle-maserati-grancabrio-maserati-transparent-backgr" +
        "ound-5a77cfd598b0c6.0914929515178014296254.jpg");
            this.img.Images.SetKeyName(3, "affair-anniversary-asad-1024975.jpg");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 476);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pct;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ImageList img;
        private System.Windows.Forms.Timer timer1;
    }
}

