using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFMenu
{
    public partial class Form1 : Form
    {
        private FontStyle _fontStyle;

        public Form1()
        {
            InitializeComponent();
            foreach(FontFamily item in FontFamily.Families)
            {
                FontFamilytoolStripComboBox1.Items.Add(item.Name);//так мы добавим себе все шрифты
            }
            FontFamilytoolStripComboBox1.Text = "Arial";
            _fontStyle = FontStyle.Regular;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();//это именно команда выход из всего приложения
            // Close();//можно по разному или эксит или клоус
            this.Close();//клоус закрывает текущее окно
            
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            //about.Show();
            about.ShowDialog();

        }

        private void FontFamilytoolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
              }

        private void SizeToolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelTest.Font = new Font(new FontFamily(FontFamilytoolStripComboBox1.Text),
                Convert.ToSingle(SizeToolStripComboBox1.Text),
                _fontStyle);

        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fontStyle ^= FontStyle.Bold;
            SizeToolStripComboBox1_SelectedIndexChanged(sender, e);
            
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fontStyle ^= FontStyle.Italic;
            SizeToolStripComboBox1_SelectedIndexChanged(sender, e);

        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                try
                {
                    labelTest.ForeColor = Color.FromName(toolStripTextBox1.Text);
                }
                catch { }
                
            }
        }
    }
}
