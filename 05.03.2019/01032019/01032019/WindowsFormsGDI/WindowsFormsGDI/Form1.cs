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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            SolidBrush solidBrush = new SolidBrush(Color.Brown);
            graphics.FillPie(solidBrush, new Rectangle(50, 20, 200, 200), 45, -90);

            HatchBrush hatchBrush = new HatchBrush(HatchStyle.Cross, Color.Yellow, Color.Navy);
            graphics.FillRectangle(hatchBrush, 10, 10, 50, 75);

            //нарисовали эллипс
            Image image = Properties.Resources.Apollo;
            TextureBrush textureBrush = new TextureBrush(image, new Rectangle(50, 50, 50, 50));
            graphics.FillEllipse(textureBrush, new Rectangle(40, 70, 200, 300));

            //такой же кисть закрасили прямоугольник
            textureBrush = new TextureBrush(image, WrapMode.TileFlipXY, new Rectangle(50, 50, 50, 50));
            graphics.FillRectangle(textureBrush, new Rectangle(140, 370, 400, 270));

            //===============================
            LinearGradientBrush linearGradient = new LinearGradientBrush(new Point(25, 200),
                new Point(150, 150), Color.Azure, Color.DarkCyan);

            graphics.FillPolygon(linearGradient, new Point[] { new Point(50, 70), new Point(150, 240),
                new Point(150, 280), new Point(170, 280), new Point(140, 340) });
            graphics.FillRectangle(linearGradient, new Rectangle(340, 70, 400, 200));

            //-------------------------------
            Point[] points = { new Point(100, 100), new Point(50, 150), new Point(150, 150) };
            PathGradientBrush pathGradient = new PathGradientBrush(points);

            Rectangle rectangle = new Rectangle(300, 20, 100, 100);

            graphics.DrawRectangle(new Pen(Brushes.Navy), rectangle);
            graphics.FillRectangle(pathGradient, rectangle);

            //-------------------------------
            Point[] pointArray = new Point[3]; // массив точек
            pointArray[0] = new Point(300, 250);
            pointArray[1] = new Point(400, 400);
            pointArray[2] = new Point(250, 400);

            PathGradientBrush pgb = new PathGradientBrush(pointArray);
            pgb.CenterColor = Color.Violet;
            pgb.CenterPoint = new Point(300, 300);
            pgb.SurroundColors = new Color[] { Color.Pink, Color.Purple, Color.RosyBrown };

            graphics.FillRectangle(pgb, new Rectangle(230, 250, 200, 200));                      
        }

        //-------------------------------
        private void DrawBall(Graphics grfx, Rectangle rect)//стр. 257-258 Петцольд том. 2
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rect);
            PathGradientBrush pgbrush = new PathGradientBrush(path);
            pgbrush.CenterPoint = new PointF((rect.Left + rect.Right) / 2.3f, (rect.Top + rect.Bottom) / 2.3f);
            pgbrush.CenterColor = Color.White;
            pgbrush.SurroundColors = new Color[] { Color.Red };
            grfx.FillRectangle(pgbrush, rect);
        }

        private void btnHatchStyle_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
