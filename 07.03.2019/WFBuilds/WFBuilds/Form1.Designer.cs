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
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbConactName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbContactPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btAddClient = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this._bs = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.btDelClient = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Location = new System.Drawing.Point(50, 27);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewInfo.Size = new System.Drawing.Size(678, 150);
            this.dataGridViewInfo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(122, 292);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 2;
            // 
            // tbConactName
            // 
            this.tbConactName.Location = new System.Drawing.Point(123, 384);
            this.tbConactName.Name = "tbConactName";
            this.tbConactName.Size = new System.Drawing.Size(100, 20);
            this.tbConactName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contact name";
            // 
            // tbContactPhone
            // 
            this.tbContactPhone.Location = new System.Drawing.Point(123, 421);
            this.tbContactPhone.Name = "tbContactPhone";
            this.tbContactPhone.Size = new System.Drawing.Size(100, 20);
            this.tbContactPhone.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Conrack Phone";
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Location = new System.Drawing.Point(123, 318);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(100, 20);
            this.tbCompanyName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Company Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contacts";
            // 
            // btAddClient
            // 
            this.btAddClient.Location = new System.Drawing.Point(341, 185);
            this.btAddClient.Name = "btAddClient";
            this.btAddClient.Size = new System.Drawing.Size(119, 23);
            this.btAddClient.TabIndex = 11;
            this.btAddClient.Text = "Добавить клиента";
            this.btAddClient.UseVisualStyleBackColor = true;
            this.btAddClient.Click += new System.EventHandler(this.btAddClient_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 263);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 12;
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
            this.btnNext.Location = new System.Drawing.Point(228, 183);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(36, 23);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(270, 183);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(36, 23);
            this.btnLast.TabIndex = 16;
            this.btnLast.Text = ">>|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Position";
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(122, 185);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(100, 20);
            this.tbPosition.TabIndex = 18;
            this.tbPosition.TextChanged += new System.EventHandler(this.tbPosition_TextChanged);
            // 
            // _bs
            // 
            this._bs.PositionChanged += new System.EventHandler(this.OnPositionChanged);
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
            this.btDelClient.Location = new System.Drawing.Point(477, 185);
            this.btDelClient.Name = "btDelClient";
            this.btDelClient.Size = new System.Drawing.Size(119, 23);
            this.btDelClient.TabIndex = 20;
            this.btDelClient.Text = "Удалить клиента";
            this.btDelClient.UseVisualStyleBackColor = true;
            this.btDelClient.Click += new System.EventHandler(this.btDelClient_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(609, 185);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(119, 23);
            this.btSave.TabIndex = 21;
            this.btSave.Text = "Сохранить в файл";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(745, 185);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(119, 23);
            this.btExit.TabIndex = 22;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 506);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btDelClient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btAddClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCompanyName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbContactPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbConactName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbConactName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbContactPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btAddClient;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.BindingSource _bs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btDelClient;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btExit;
    }
}

