namespace WFBuilds
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
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.lblBirstdayDate = new System.Windows.Forms.Label();
            this.tbBirthday = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblFIO = new System.Windows.Forms.Label();
            this.btAddClient = new System.Windows.Forms.Button();
            this.cbFIO = new System.Windows.Forms.ComboBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.lblZodiac = new System.Windows.Forms.Label();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btDelClient = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.tbEyeColor = new System.Windows.Forms.TextBox();
            this.lblEyeColor = new System.Windows.Forms.Label();
            this.tbHairColor = new System.Windows.Forms.TextBox();
            this.lblHairColor = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.DataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CountryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.IMG = new System.Windows.Forms.ImageList(this.components);
            this.pbZodiack = new System.Windows.Forms.PictureBox();
            this._bs = new System.Windows.Forms.BindingSource(this.components);
            this.UpDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbZodiack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Location = new System.Drawing.Point(12, 27);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewInfo.Size = new System.Drawing.Size(1014, 150);
            this.dataGridViewInfo.TabIndex = 0;
            // 
            // lblBirstdayDate
            // 
            this.lblBirstdayDate.AutoSize = true;
            this.lblBirstdayDate.Location = new System.Drawing.Point(35, 294);
            this.lblBirstdayDate.Name = "lblBirstdayDate";
            this.lblBirstdayDate.Size = new System.Drawing.Size(86, 13);
            this.lblBirstdayDate.TabIndex = 1;
            this.lblBirstdayDate.Text = "Дата рождения";
            // 
            // tbBirthday
            // 
            this.tbBirthday.Location = new System.Drawing.Point(122, 292);
            this.tbBirthday.Name = "tbBirthday";
            this.tbBirthday.Size = new System.Drawing.Size(100, 20);
            this.tbBirthday.TabIndex = 2;
            this.tbBirthday.TextChanged += new System.EventHandler(this.tbBirthday_TextChanged);
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(123, 369);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(100, 20);
            this.tbCountry.TabIndex = 4;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(35, 372);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 3;
            this.lblCountry.Text = "Страна";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(122, 395);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(100, 20);
            this.tbCity.TabIndex = 6;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(35, 398);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(37, 13);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "Город";
            // 
            // tbGender
            // 
            this.tbGender.Location = new System.Drawing.Point(123, 318);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(100, 20);
            this.tbGender.TabIndex = 8;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(35, 318);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(27, 13);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Пол";
            // 
            // lblFIO
            // 
            this.lblFIO.AutoSize = true;
            this.lblFIO.Location = new System.Drawing.Point(35, 263);
            this.lblFIO.Name = "lblFIO";
            this.lblFIO.Size = new System.Drawing.Size(34, 13);
            this.lblFIO.TabIndex = 9;
            this.lblFIO.Text = "ФИО";
            // 
            // btAddClient
            // 
            this.btAddClient.Location = new System.Drawing.Point(252, 182);
            this.btAddClient.Name = "btAddClient";
            this.btAddClient.Size = new System.Drawing.Size(189, 23);
            this.btAddClient.TabIndex = 11;
            this.btAddClient.Text = "Добавить клиента";
            this.btAddClient.UseVisualStyleBackColor = true;
            this.btAddClient.Click += new System.EventHandler(this.btAddClient_Click);
            // 
            // cbFIO
            // 
            this.cbFIO.FormattingEnabled = true;
            this.cbFIO.Location = new System.Drawing.Point(122, 263);
            this.cbFIO.Name = "cbFIO";
            this.cbFIO.Size = new System.Drawing.Size(101, 21);
            this.cbFIO.TabIndex = 12;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(38, 183);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(36, 23);
            this.btnFirst.TabIndex = 13;
            this.btnFirst.Text = "|<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(80, 183);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(36, 23);
            this.btnPrevious.TabIndex = 14;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(168, 182);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(36, 23);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(210, 182);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(36, 23);
            this.btnLast.TabIndex = 16;
            this.btnLast.Text = ">>|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // lblZodiac
            // 
            this.lblZodiac.AutoSize = true;
            this.lblZodiac.Location = new System.Drawing.Point(239, 376);
            this.lblZodiac.Name = "lblZodiac";
            this.lblZodiac.Size = new System.Drawing.Size(40, 13);
            this.lblZodiac.TabIndex = 17;
            this.lblZodiac.Text = "Zodiak";
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(122, 185);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(40, 20);
            this.tbPosition.TabIndex = 18;
            this.tbPosition.TextChanged += new System.EventHandler(this.tbPosition_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Карточка клиента";
            // 
            // btDelClient
            // 
            this.btDelClient.Location = new System.Drawing.Point(447, 182);
            this.btDelClient.Name = "btDelClient";
            this.btDelClient.Size = new System.Drawing.Size(189, 23);
            this.btDelClient.TabIndex = 20;
            this.btDelClient.Text = "Удалить клиента";
            this.btDelClient.UseVisualStyleBackColor = true;
            this.btDelClient.Click += new System.EventHandler(this.btDelClient_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(642, 182);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(189, 23);
            this.btSave.TabIndex = 21;
            this.btSave.Text = "Сохранить в файл";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(837, 182);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(189, 23);
            this.btExit.TabIndex = 22;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(122, 470);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(100, 20);
            this.tbWeight.TabIndex = 26;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(35, 473);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(26, 13);
            this.lblWeight.TabIndex = 25;
            this.lblWeight.Text = "Вес";
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(123, 444);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(100, 20);
            this.tbHeight.TabIndex = 24;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(35, 447);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(31, 13);
            this.lblHeight.TabIndex = 23;
            this.lblHeight.Text = "Рост";
            // 
            // tbEyeColor
            // 
            this.tbEyeColor.Location = new System.Drawing.Point(121, 522);
            this.tbEyeColor.Name = "tbEyeColor";
            this.tbEyeColor.Size = new System.Drawing.Size(100, 20);
            this.tbEyeColor.TabIndex = 30;
            // 
            // lblEyeColor
            // 
            this.lblEyeColor.AutoSize = true;
            this.lblEyeColor.Location = new System.Drawing.Point(34, 525);
            this.lblEyeColor.Name = "lblEyeColor";
            this.lblEyeColor.Size = new System.Drawing.Size(58, 13);
            this.lblEyeColor.TabIndex = 29;
            this.lblEyeColor.Text = "Цвет глаз";
            // 
            // tbHairColor
            // 
            this.tbHairColor.Location = new System.Drawing.Point(122, 496);
            this.tbHairColor.Name = "tbHairColor";
            this.tbHairColor.Size = new System.Drawing.Size(100, 20);
            this.tbHairColor.TabIndex = 28;
            // 
            // lblHairColor
            // 
            this.lblHairColor.AutoSize = true;
            this.lblHairColor.Location = new System.Drawing.Point(34, 499);
            this.lblHairColor.Name = "lblHairColor";
            this.lblHairColor.Size = new System.Drawing.Size(65, 13);
            this.lblHairColor.TabIndex = 27;
            this.lblHairColor.Text = "Цвет волос";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataToolStripMenuItem,
            this.FoundToolStripMenuItem,
            this.UpDateToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1071, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DataToolStripMenuItem
            // 
            this.DataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataFileToolStripMenuItem});
            this.DataToolStripMenuItem.Name = "DataToolStripMenuItem";
            this.DataToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.DataToolStripMenuItem.Text = "Данные";
            // 
            // DataFileToolStripMenuItem
            // 
            this.DataFileToolStripMenuItem.Name = "DataFileToolStripMenuItem";
            this.DataFileToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.DataFileToolStripMenuItem.Text = "Загрузить данные из файла";
            this.DataFileToolStripMenuItem.Click += new System.EventHandler(this.DataFileToolStripMenuItem_Click);
            // 
            // FoundToolStripMenuItem
            // 
            this.FoundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CountryToolStripMenuItem,
            this.CityToolStripMenuItem,
            this.HeightToolStripMenuItem,
            this.WeightToolStripMenuItem,
            this.HairToolStripMenuItem,
            this.EyeToolStripMenuItem});
            this.FoundToolStripMenuItem.Name = "FoundToolStripMenuItem";
            this.FoundToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.FoundToolStripMenuItem.Text = "Поиск";
            // 
            // CountryToolStripMenuItem
            // 
            this.CountryToolStripMenuItem.Name = "CountryToolStripMenuItem";
            this.CountryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CountryToolStripMenuItem.Text = "Старана";
            this.CountryToolStripMenuItem.Click += new System.EventHandler(this.CountryToolStripMenuItem_Click);
            // 
            // CityToolStripMenuItem
            // 
            this.CityToolStripMenuItem.Name = "CityToolStripMenuItem";
            this.CityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CityToolStripMenuItem.Text = "Город";
            this.CityToolStripMenuItem.Click += new System.EventHandler(this.CountryToolStripMenuItem_Click);
            // 
            // HeightToolStripMenuItem
            // 
            this.HeightToolStripMenuItem.Name = "HeightToolStripMenuItem";
            this.HeightToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.HeightToolStripMenuItem.Text = "Рост";
            this.HeightToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // WeightToolStripMenuItem
            // 
            this.WeightToolStripMenuItem.Name = "WeightToolStripMenuItem";
            this.WeightToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.WeightToolStripMenuItem.Text = "Вес";
            this.WeightToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // HairToolStripMenuItem
            // 
            this.HairToolStripMenuItem.Name = "HairToolStripMenuItem";
            this.HairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.HairToolStripMenuItem.Text = "Цвет волос";
            this.HairToolStripMenuItem.Click += new System.EventHandler(this.CountryToolStripMenuItem_Click);
            // 
            // EyeToolStripMenuItem
            // 
            this.EyeToolStripMenuItem.Name = "EyeToolStripMenuItem";
            this.EyeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EyeToolStripMenuItem.Text = "Глаза";
            this.EyeToolStripMenuItem.Click += new System.EventHandler(this.CountryToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // IMG
            // 
            this.IMG.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IMG.ImageStream")));
            this.IMG.TransparentColor = System.Drawing.Color.Transparent;
            this.IMG.Images.SetKeyName(0, "близнецы.jpg");
            this.IMG.Images.SetKeyName(1, "весы.jpg");
            this.IMG.Images.SetKeyName(2, "водолей.jpg");
            this.IMG.Images.SetKeyName(3, "дева.jpg");
            this.IMG.Images.SetKeyName(4, "козерог.jpg");
            this.IMG.Images.SetKeyName(5, "лев.jpg");
            this.IMG.Images.SetKeyName(6, "овен.jpg");
            this.IMG.Images.SetKeyName(7, "рак.jpg");
            this.IMG.Images.SetKeyName(8, "рыбы.jpg");
            this.IMG.Images.SetKeyName(9, "скорпион.jpg");
            this.IMG.Images.SetKeyName(10, "стрелец.jpg");
            this.IMG.Images.SetKeyName(11, "телец.jpg");
            // 
            // pbZodiack
            // 
            this.pbZodiack.BackgroundImage = global::WFBuilds.Properties.Resources.телец;
            this.pbZodiack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbZodiack.Location = new System.Drawing.Point(242, 410);
            this.pbZodiack.Name = "pbZodiack";
            this.pbZodiack.Size = new System.Drawing.Size(121, 132);
            this.pbZodiack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbZodiack.TabIndex = 33;
            this.pbZodiack.TabStop = false;
            // 
            // _bs
            // 
            this._bs.AddingNew += new System.ComponentModel.AddingNewEventHandler(this._bs_AddingNew);
            this._bs.PositionChanged += new System.EventHandler(this.OnPositionChanged);
            // 
            // UpDateToolStripMenuItem
            // 
            this.UpDateToolStripMenuItem.Name = "UpDateToolStripMenuItem";
            this.UpDateToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.UpDateToolStripMenuItem.Text = "Обновить данные";
            this.UpDateToolStripMenuItem.Click += new System.EventHandler(this.UpDateToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WFBuilds.Properties.Resources.PHOTO1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1071, 593);
            this.Controls.Add(this.pbZodiack);
            this.Controls.Add(this.tbEyeColor);
            this.Controls.Add(this.lblEyeColor);
            this.Controls.Add(this.tbHairColor);
            this.Controls.Add(this.lblHairColor);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btDelClient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.lblZodiac);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.cbFIO);
            this.Controls.Add(this.btAddClient);
            this.Controls.Add(this.lblFIO);
            this.Controls.Add(this.tbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.tbBirthday);
            this.Controls.Add(this.lblBirstdayDate);
            this.Controls.Add(this.dataGridViewInfo);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Брачное Агенство";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbZodiack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInfo;
        private System.Windows.Forms.Label lblBirstdayDate;
        private System.Windows.Forms.TextBox tbBirthday;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblFIO;
        private System.Windows.Forms.Button btAddClient;
        private System.Windows.Forms.ComboBox cbFIO;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lblZodiac;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.BindingSource _bs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btDelClient;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox tbEyeColor;
        private System.Windows.Forms.Label lblEyeColor;
        private System.Windows.Forms.TextBox tbHairColor;
        private System.Windows.Forms.Label lblHairColor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem DataFileToolStripMenuItem;
        private System.Windows.Forms.ImageList IMG;
        private System.Windows.Forms.PictureBox pbZodiack;
        private System.Windows.Forms.ToolStripMenuItem CountryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HeightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WeightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EyeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpDateToolStripMenuItem;
    }
}

