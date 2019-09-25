using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl1.SelectedIndex = 2;
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch(e.TabPageIndex)
            {
                case 1:
                    label2.Text = label1.Text;//тут мы из первой вкладке копирую текст, во вторую вкладку
                    break;
                default:
                    break;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            up.Text = trackBar1.Value.ToString();
            if (checkBox1.Checked)
            {
                trackBar2.Value = trackBar1.Value;
                down.Text = trackBar2.Value.ToString();
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            down.Text = trackBar2.Value.ToString();
            if (checkBox1.Checked)
            {
                trackBar1.Value = trackBar2.Value;
                up.Text = trackBar1.Value.ToString();
            }
        }

        private void up_TextChanged(object sender, EventArgs e)
        {
            int y = trackBar2.Value;
            int x = trackBar1.Value;

             rezult.Text = (x*y).ToString();
             
        }

       

        private void down_TextChanged(object sender, EventArgs e)
        {
            int y = trackBar2.Value;
            int x = trackBar1.Value;

            rezult.Text = (x * y).ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                trackBar2.Value = trackBar1.Value;
                down.Text = trackBar2.Value.ToString();
                groupBox1.Text = "Возведение в квадрат";
            }
            else
            {
                groupBox1.Text = "Произведение";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox2.Visible = true;
            label3.Text = textBox1.Text;
        }
        Color bt;

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
               if (((Button)sender).BackColor == Color.Red)
                {
                    ((Button)sender).Left = hScrollBar2.Value;
                }
            
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            
                if (((Button)sender).BackColor == Color.Red)
                {
                    ((Button)sender).BackColor = bt;
                }
            

            bt = ((Button)sender).BackColor;
            ((Button)sender).BackColor=Color.Red;               
        }
    }
}
