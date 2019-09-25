namespace WindowsFormsGDI
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
            this.btnHatchStyle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHatchStyle
            // 
            this.btnHatchStyle.Location = new System.Drawing.Point(110, 12);
            this.btnHatchStyle.Name = "btnHatchStyle";
            this.btnHatchStyle.Size = new System.Drawing.Size(75, 23);
            this.btnHatchStyle.TabIndex = 0;
            this.btnHatchStyle.Text = "HatchStyles";
            this.btnHatchStyle.UseVisualStyleBackColor = true;
            this.btnHatchStyle.Click += new System.EventHandler(this.btnHatchStyle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 587);
            this.Controls.Add(this.btnHatchStyle);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHatchStyle;
    }
}

