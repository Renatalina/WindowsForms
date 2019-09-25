namespace CarControlLibrary
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.currentImage = new System.Windows.Forms.PictureBox();
            this.carImages = new System.Windows.Forms.ImageList(this.components);
            this.imageTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.currentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // currentImage
            // 
            this.currentImage.Location = new System.Drawing.Point(44, 18);
            this.currentImage.Name = "currentImage";
            this.currentImage.Size = new System.Drawing.Size(150, 77);
            this.currentImage.TabIndex = 0;
            this.currentImage.TabStop = false;
            // 
            // carImages
            // 
            this.carImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("carImages.ImageStream")));
            this.carImages.TransparentColor = System.Drawing.Color.Transparent;
            this.carImages.Images.SetKeyName(0, "Lemon0.bmp");
            this.carImages.Images.SetKeyName(1, "Lemon1.bmp");
            this.carImages.Images.SetKeyName(2, "Lemon2.bmp");
            this.carImages.Images.SetKeyName(3, "Lemon3.bmp");
            this.carImages.Images.SetKeyName(4, "AboutToBlow.bmp");
            this.carImages.Images.SetKeyName(5, "EngineBlown.bmp");
            // 
            // imageTimer
            // 
            this.imageTimer.Interval = 300;
            this.imageTimer.Tick += new System.EventHandler(this.imageTimer_Tick);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.currentImage);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(345, 237);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControl1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.currentImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox currentImage;
        private System.Windows.Forms.ImageList carImages;
        private System.Windows.Forms.Timer imageTimer;
    }
}
