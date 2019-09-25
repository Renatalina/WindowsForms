namespace WFButton
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
            this.rbTest = new DLLButton.RoundButton(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbTest
            // 
            this.rbTest.AutoSize = true;
            this.rbTest.Location = new System.Drawing.Point(54, 22);
            this.rbTest.Margin = new System.Windows.Forms.Padding(13);
            this.rbTest.Name = "rbTest";
            this.rbTest.Size = new System.Drawing.Size(87, 86);
            this.rbTest.TabIndex = 0;
            this.rbTest.Text = "Бах!!!!!!!!";
            this.rbTest.UseVisualStyleBackColor = true;
            this.rbTest.Click += new System.EventHandler(this.rbTest_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Пуск";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 195);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DLLButton.RoundButton rbTest;
        private System.Windows.Forms.Button button1;
    }
}

