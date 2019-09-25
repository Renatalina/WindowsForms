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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Pen pen = new Pen(Color.Red);

            //graphics.TranslateTransform(graphics.VisibleClipBounds.Size.Width / 2, graphics.VisibleClipBounds.Size.Height / 2);

            graphics.TranslateTransform(graphics.VisibleClipBounds.Size.Width / 2, graphics.C.Height / 2);
            for (int i = 0; i < 120; i++)
            {
                graphics.DrawRectangle(pen, 0, 0, 100, 100);
                graphics.RotateTransform(3);
            }
        }
    }
}
