namespace WindowsFormsCS
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.cbLeather = new System.Windows.Forms.CheckBox();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbBlack = new System.Windows.Forms.RadioButton();
            this.grbColor = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCars = new System.Windows.Forms.ListBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.clbOptions = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.grbColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(70, 13);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 3;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(70, 55);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 4;
            // 
            // cbLeather
            // 
            this.cbLeather.AutoSize = true;
            this.cbLeather.Location = new System.Drawing.Point(13, 99);
            this.cbLeather.Name = "cbLeather";
            this.cbLeather.Size = new System.Drawing.Size(53, 17);
            this.cbLeather.TabIndex = 5;
            this.cbLeather.Text = "Кожа";
            this.cbLeather.UseVisualStyleBackColor = true;
            this.cbLeather.CheckedChanged += new System.EventHandler(this.cbLeather_CheckedChanged);
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.ForeColor = System.Drawing.Color.Red;
            this.rbRed.Location = new System.Drawing.Point(6, 23);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(70, 17);
            this.rbRed.TabIndex = 6;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Красный";
            this.rbRed.UseVisualStyleBackColor = true;
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.ForeColor = System.Drawing.Color.Green;
            this.rbGreen.Location = new System.Drawing.Point(82, 23);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(70, 17);
            this.rbGreen.TabIndex = 7;
            this.rbGreen.TabStop = true;
            this.rbGreen.Text = "Зеленый";
            this.rbGreen.UseVisualStyleBackColor = true;
            // 
            // rbBlack
            // 
            this.rbBlack.AutoSize = true;
            this.rbBlack.Location = new System.Drawing.Point(158, 23);
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Size = new System.Drawing.Size(65, 17);
            this.rbBlack.TabIndex = 8;
            this.rbBlack.TabStop = true;
            this.rbBlack.Text = "Черный";
            this.rbBlack.UseVisualStyleBackColor = true;
            // 
            // grbColor
            // 
            this.grbColor.Controls.Add(this.rbRed);
            this.grbColor.Controls.Add(this.rbBlack);
            this.grbColor.Controls.Add(this.rbGreen);
            this.grbColor.Location = new System.Drawing.Point(97, 90);
            this.grbColor.Name = "grbColor";
            this.grbColor.Size = new System.Drawing.Size(229, 54);
            this.grbColor.TabIndex = 9;
            this.grbColor.TabStop = false;
            this.grbColor.Text = "Цвет кожи";
            this.grbColor.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Марка машины";
            // 
            // lbCars
            // 
            this.lbCars.FormattingEnabled = true;
            this.lbCars.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Honda",
            "Opel",
            "Ford",
            "Saab"});
            this.lbCars.Location = new System.Drawing.Point(13, 182);
            this.lbCars.Name = "lbCars";
            this.lbCars.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbCars.Size = new System.Drawing.Size(98, 56);
            this.lbCars.TabIndex = 11;
            this.lbCars.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(236, 400);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(110, 23);
            this.btnOrder.TabIndex = 12;
            this.btnOrder.Text = "Заказ";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Комплектация";
            // 
            // clbOptions
            // 
            this.clbOptions.CheckOnClick = true;
            this.clbOptions.FormattingEnabled = true;
            this.clbOptions.Items.AddRange(new object[] {
            "ABS",
            "Кондиционер",
            "Обогрев ...",
            "Стереосистема"});
            this.clbOptions.Location = new System.Drawing.Point(179, 182);
            this.clbOptions.Name = "clbOptions";
            this.clbOptions.Size = new System.Drawing.Size(120, 64);
            this.clbOptions.Sorted = true;
            this.clbOptions.TabIndex = 14;
            this.clbOptions.ThreeDCheckBoxes = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Дата доставки";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(52, 28);
            this.monthCalendar1.MaxSelectionCount = 10;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 435);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clbOptions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lbCars);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grbColor);
            this.Controls.Add(this.cbLeather);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Покупка авто";
            this.grbColor.ResumeLayout(false);
            this.grbColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.CheckBox cbLeather;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbBlack;
        private System.Windows.Forms.GroupBox grbColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbCars;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox clbOptions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

