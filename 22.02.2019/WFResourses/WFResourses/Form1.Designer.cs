namespace WFResourses
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
            this.lblRest = new System.Windows.Forms.Label();
            this.timerRest = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblRest
            // 
            this.lblRest.AutoSize = true;
            this.lblRest.Location = new System.Drawing.Point(215, 37);
            this.lblRest.Name = "lblRest";
            this.lblRest.Size = new System.Drawing.Size(35, 13);
            this.lblRest.TabIndex = 0;
            this.lblRest.Text = "label1";
            // 
            // timerRest
            // 
            this.timerRest.Interval = 1000;
            this.timerRest.Tick += new System.EventHandler(this.timerRest_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 227);
            this.Controls.Add(this.lblRest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRest;
        private System.Windows.Forms.Timer timerRest;
    }
}

