namespace WFBuilds
{
    partial class Form3
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
            this.tbFound = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbFound
            // 
            this.tbFound.Location = new System.Drawing.Point(140, 64);
            this.tbFound.Name = "tbFound";
            this.tbFound.Size = new System.Drawing.Size(139, 20);
            this.tbFound.TabIndex = 0;
            this.tbFound.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFound
            // 
            this.lblFound.AutoSize = true;
            this.lblFound.Location = new System.Drawing.Point(22, 64);
            this.lblFound.Name = "lblFound";
            this.lblFound.Size = new System.Drawing.Size(90, 13);
            this.lblFound.TabIndex = 2;
            this.lblFound.Text = "Введите данные";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 178);
            this.Controls.Add(this.lblFound);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbFound);
            this.Name = "Form3";
            this.Text = "Поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFound;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFound;
    }
}