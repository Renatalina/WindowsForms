using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTransformer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            graphics.TranslateTransform(113, 30);

            graphics.RotateTransform(15);

            graphics.DrawRectangle(Pens.Violet, new Rectangle(0, 0, 100, 100));

            graphics.RotateTransform(65);

            graphics.DrawRectangle(Pens.Tomato, new Rectangle(0, 0, 100, 100));

            graphics.ResetTransform();
            graphics.TranslateTransform(100, 100);
            graphics.DrawRectangle(Pens.Navy, new Rectangle(0, 0, 150, 150));
            graphics.ScaleTransform(1.57f, -2.5f);
            graphics.DrawString("Hello GDI++", Font, Brushes.Red, new Rectangle(0, 0, 150, 150));
            graphics.DrawRectangle(Pens.Green, new Rectangle(50, 150, 100, 100));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
