using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormGDI
{
    public partial class Form1 : Form
    {
        List<Point> _points = new List<Point>();
        public Form1()
        {
            InitializeComponent();

            Show();
            Graphics graphics = this.CreateGraphics();

            graphics.FillRectangle(Brushes.BlueViolet, 20, 30, 100, 150);
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(Brushes.CadetBlue, 30, 20, 140, 160);
            // PointF pointF = new PointF(3, 5f, 4.7f);

            Pen pen = new Pen(Color.AliceBlue, 8f);
            foreach (Point item in _points)
            {
                graphics.DrawEllipse(pen, item.X, item.Y, 30, 30);
            }

            Image image = Properties.Resources.but3;
            Graphics grap = Graphics.FromImage(image);
            grap.FillRectangle(Brushes.Red, 20, 20, 50, 50);
            graphics.DrawImage(image, 200, 20);
            grap.Dispose();

            graphics.DrawLine(pen, new Point(50, 70), new Point(100, 150));
            graphics.DrawLines(pen, new Point[] { new Point(120, 20), new Point(50, 150), new Point(170, 277), });

            graphics.DrawArc(pen, new Rectangle(150, 120, 100, 100), -285, -290);
            graphics.DrawPie(Pens.Aqua, new Rectangle(150, 120, 100, 100), -285, -290);
            graphics.FillPie(Brushes.Green, new Rectangle (150, 120, 100, 100), -285, -290);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            _points.Add(new Point(e.X - 10, e.Y - 10));

            Invalidate();

            Graphics graphics = Graphics.FromHwnd(this.Handle);
            Pen pen = new Pen(Color.AliceBlue, 3f);
            graphics.DrawEllipse(pen, e.X-10, e.Y-10, 30, 30);
            graphics.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = button1.CreateGraphics();

            RectangleF rectangleF = new RectangleF(15, 15, 50, 50);
            graphics.DrawRectangles(Pens.CadetBlue, new RectangleF[] { rectangleF });
            graphics.DrawString("Hello", button1.Font, Brushes.Coral, rectangleF);

        }
    }
}
