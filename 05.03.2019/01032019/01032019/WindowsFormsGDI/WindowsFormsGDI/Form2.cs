using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGDI
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
            graphics.TranslateTransform(AutoScrollPosition.X, AutoScrollPosition.Y);

            int x = 20, y = 20;

            foreach (HatchStyle item in Enum.GetValues(typeof(HatchStyle)))
            {
                graphics.DrawString(item.ToString(), this.Font, Brushes.Red, new Point(x, y));
                y += 20;

                graphics.FillRectangle(new HatchBrush(item, Color.Red), new Rectangle(x, y, 40, 40));
                y += 50;
            }
            
        }
    }
}
