using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using st = System.Threading; //это псевдоним, если есть несколько классов


namespace DialogWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            labelExample.ForeColor = colorDialog1.Color;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            //fontDialog1.ShowDialog();
            //labelExample.ForeColor = fontDialog1.Color;
            //labelExample.Font = fontDialog1.Font;
            //второй вариант, как мы можем изменить размер шрифта и цвет 

            FontDialog fontDialog = new FontDialog
            {
                ShowColor = true
            };
            fontDialog.ShowDialog();
            labelExample.ForeColor = fontDialog.Color;
            labelExample.Font = fontDialog.Font;

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text file(*.txt)|*.txt| CS files (*.cs)|*.cs|All files(*.*)|*.*";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                using (StreamReader reader=new StreamReader/*(openFileDialog1.OpenFile()*/(openFileDialog1.FileName))
                {
                    tbFile.Text = reader.ReadToEnd();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //saveFileDialog1.ShowDialog();
                StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);
                writer.WriteLine(tbFile.Text);
                writer.Close();
            }

        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            Form form = new Form
            {
                Name = "Little Form",
                Width = 500,
                Height = 500
            };
            Button btOk = new Button
            {
                Width = 50,
                Height = 50,
                Location = new Point(150, 150),
                Text = "Ok"
            };
            Button btCancel = new Button
            {
                Width = 50,
                Height = 50,
                Location = new Point(250, 150),
                Text = "Cancel"
            };
            btOk.Click += BtOk_Click;
            btCancel.Click += BtCancel_Click;

            TextBox textBox = new TextBox
            {
                Width = 150,
                Height=50,
                Location=new Point(150,50)
               
            };
            form.Controls.Add(btCancel);
            form.Controls.Add(btOk);
            form.Controls.Add(textBox);            
            form.Load += Form_Load;            


        }
        private void Form_Load()
        {
            InitializeComponent();
            tbInfo.Text = ImportExport.Data;
        }

      /*  private void Form_Load(string str):this()
        {
            
            
        }
        */
        private void BtCancel_Click(object sender, EventArgs e)
        {
            ImportExport.Data = tbInfo.Text;
            Close();
        }

        private void BtOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
