namespace WFMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.имяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontFamilytoolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.стильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SizeToolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTest = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SmallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StateToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ClockToolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.DateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClockToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ClockToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.PlusToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.MinusToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.TextToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.btnProgress = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.форматToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(391, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(105, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // форматToolStripMenuItem
            // 
            this.форматToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шрифтToolStripMenuItem,
            this.цветToolStripMenuItem});
            this.форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            this.форматToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.форматToolStripMenuItem.Text = "Формат";
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.имяToolStripMenuItem,
            this.стильToolStripMenuItem,
            this.SizeToolStripMenuItem});
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            // 
            // имяToolStripMenuItem
            // 
            this.имяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontFamilytoolStripComboBox1});
            this.имяToolStripMenuItem.Name = "имяToolStripMenuItem";
            this.имяToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.имяToolStripMenuItem.Text = "Имя";
            // 
            // FontFamilytoolStripComboBox1
            // 
            this.FontFamilytoolStripComboBox1.Name = "FontFamilytoolStripComboBox1";
            this.FontFamilytoolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.FontFamilytoolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.FontFamilytoolStripComboBox1_SelectedIndexChanged);
            // 
            // стильToolStripMenuItem
            // 
            this.стильToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldToolStripMenuItem,
            this.italicToolStripMenuItem});
            this.стильToolStripMenuItem.Name = "стильToolStripMenuItem";
            this.стильToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.стильToolStripMenuItem.Text = "Стиль";
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.CheckOnClick = true;
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.boldToolStripMenuItem.Text = "Bold";
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
            // 
            // italicToolStripMenuItem
            // 
            this.italicToolStripMenuItem.CheckOnClick = true;
            this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            this.italicToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.italicToolStripMenuItem.Text = "Italic";
            this.italicToolStripMenuItem.Click += new System.EventHandler(this.italicToolStripMenuItem_Click);
            // 
            // SizeToolStripMenuItem
            // 
            this.SizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SizeToolStripComboBox1});
            this.SizeToolStripMenuItem.Name = "SizeToolStripMenuItem";
            this.SizeToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.SizeToolStripMenuItem.Text = "Размер";
            // 
            // SizeToolStripComboBox1
            // 
            this.SizeToolStripComboBox1.Items.AddRange(new object[] {
            "4",
            "6",
            "8",
            "9",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22"});
            this.SizeToolStripComboBox1.Name = "SizeToolStripComboBox1";
            this.SizeToolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.SizeToolStripComboBox1.Text = "14";
            this.SizeToolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.FontFamilytoolStripComboBox1_SelectedIndexChanged);
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.цветToolStripMenuItem.Text = "Цвет";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Black";
            this.toolStripTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(38, 59);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(72, 13);
            this.labelTest.TabIndex = 1;
            this.labelTest.Text = "Любой текст";
            this.labelTest.MouseLeave += new System.EventHandler(this.labelTest_MouseLeave);
            this.labelTest.MouseHover += new System.EventHandler(this.labelTest_MouseHover);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BigToolStripMenuItem,
            this.NormalToolStripMenuItem,
            this.SmallToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 70);
            // 
            // BigToolStripMenuItem
            // 
            this.BigToolStripMenuItem.Name = "BigToolStripMenuItem";
            this.BigToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.BigToolStripMenuItem.Tag = "2";
            this.BigToolStripMenuItem.Text = "Крупный";
            this.BigToolStripMenuItem.Click += new System.EventHandler(this.FontSizeChange);
            // 
            // NormalToolStripMenuItem
            // 
            this.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem";
            this.NormalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.NormalToolStripMenuItem.Tag = "30";
            this.NormalToolStripMenuItem.Text = "Обычный";
            this.NormalToolStripMenuItem.Click += new System.EventHandler(this.FontSizeChange);
            // 
            // SmallToolStripMenuItem
            // 
            this.SmallToolStripMenuItem.Name = "SmallToolStripMenuItem";
            this.SmallToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.SmallToolStripMenuItem.Tag = "-2";
            this.SmallToolStripMenuItem.Text = "Мелкий";
            this.SmallToolStripMenuItem.Click += new System.EventHandler(this.FontSizeChange);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StateToolStripStatusLabel,
            this.ClockToolStripDropDownButton1,
            this.ClockToolStripStatusLabel1,
            this.ClockToolStripStatusLabel,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 270);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(391, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StateToolStripStatusLabel
            // 
            this.StateToolStripStatusLabel.Name = "StateToolStripStatusLabel";
            this.StateToolStripStatusLabel.Size = new System.Drawing.Size(64, 17);
            this.StateToolStripStatusLabel.Text = "Ожидание";
            // 
            // ClockToolStripDropDownButton1
            // 
            this.ClockToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClockToolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DateToolStripMenuItem,
            this.TimeToolStripMenuItem});
            this.ClockToolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("ClockToolStripDropDownButton1.Image")));
            this.ClockToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Silver;
            this.ClockToolStripDropDownButton1.Name = "ClockToolStripDropDownButton1";
            this.ClockToolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.ClockToolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // DateToolStripMenuItem
            // 
            this.DateToolStripMenuItem.Name = "DateToolStripMenuItem";
            this.DateToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.DateToolStripMenuItem.Text = "Текущая дата";
            this.DateToolStripMenuItem.Click += new System.EventHandler(this.DateToolStripMenuItem_Click);
            // 
            // TimeToolStripMenuItem
            // 
            this.TimeToolStripMenuItem.Name = "TimeToolStripMenuItem";
            this.TimeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.TimeToolStripMenuItem.Text = "Текущее время";
            this.TimeToolStripMenuItem.Click += new System.EventHandler(this.TimeToolStripMenuItem_Click);
            // 
            // ClockToolStripStatusLabel1
            // 
            this.ClockToolStripStatusLabel1.Name = "ClockToolStripStatusLabel1";
            this.ClockToolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // ClockToolStripStatusLabel
            // 
            this.ClockToolStripStatusLabel.Name = "ClockToolStripStatusLabel";
            this.ClockToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // StatusTimer
            // 
            this.StatusTimer.Enabled = true;
            this.StatusTimer.Tick += new System.EventHandler(this.StatusTimer_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlusToolStripSplitButton,
            this.MinusToolStripSplitButton,
            this.TextToolStripTextBox,
            this.toolStripProgressBar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(391, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // PlusToolStripSplitButton
            // 
            this.PlusToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PlusToolStripSplitButton.Image = ((System.Drawing.Image)(resources.GetObject("PlusToolStripSplitButton.Image")));
            this.PlusToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.PlusToolStripSplitButton.Name = "PlusToolStripSplitButton";
            this.PlusToolStripSplitButton.Size = new System.Drawing.Size(32, 22);
            this.PlusToolStripSplitButton.Text = "toolStripSplitButton1";
            this.PlusToolStripSplitButton.Click += new System.EventHandler(this.PlusToolStripSplitButton_Click);
            // 
            // MinusToolStripSplitButton
            // 
            this.MinusToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MinusToolStripSplitButton.Image = ((System.Drawing.Image)(resources.GetObject("MinusToolStripSplitButton.Image")));
            this.MinusToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.MinusToolStripSplitButton.Name = "MinusToolStripSplitButton";
            this.MinusToolStripSplitButton.Size = new System.Drawing.Size(32, 22);
            this.MinusToolStripSplitButton.Text = "toolStripSplitButton2";
            this.MinusToolStripSplitButton.Click += new System.EventHandler(this.MinusToolStripSplitButton_Click);
            // 
            // TextToolStripTextBox
            // 
            this.TextToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextToolStripTextBox.ForeColor = System.Drawing.Color.Silver;
            this.TextToolStripTextBox.Name = "TextToolStripTextBox";
            this.TextToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.TextToolStripTextBox.Text = "Введите...";
            this.TextToolStripTextBox.Click += new System.EventHandler(this.TextToolStripTextBox_Click);
            this.TextToolStripTextBox.TextChanged += new System.EventHandler(this.TextToolStripTextBox_TextChanged);
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 22);
            this.toolStripProgressBar.Step = 1;
            // 
            // btnProgress
            // 
            this.btnProgress.Location = new System.Drawing.Point(158, 59);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(75, 23);
            this.btnProgress.TabIndex = 5;
            this.btnProgress.Text = "Progress";
            this.btnProgress.UseVisualStyleBackColor = true;
            this.btnProgress.Click += new System.EventHandler(this.btnProgress_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(41, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 292);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnProgress);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem имяToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox FontFamilytoolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem стильToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox SizeToolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NormalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SmallToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StateToolStripStatusLabel;
        private System.Windows.Forms.ToolStripDropDownButton ClockToolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem DateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel ClockToolStripStatusLabel1;
        private System.Windows.Forms.Timer StatusTimer;
        private System.Windows.Forms.ToolStripStatusLabel ClockToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton PlusToolStripSplitButton;
        private System.Windows.Forms.ToolStripSplitButton MinusToolStripSplitButton;
        private System.Windows.Forms.ToolStripTextBox TextToolStripTextBox;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.Button btnProgress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

