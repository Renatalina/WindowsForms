using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // pct.LoadAsync("http://evrofilm.com/wp-content/uploads/2014/05/foto-evr-muzh-01.jpg");            
            
        }

      
        private void pct_LoadCpmpleted(object sender, AsyncCompletedEventArgs args)
        {
            timer1.Enabled = true;
        }

        int index = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
                  index = ++index % img.Images.Count;               
                    pct.Image = img.Images[index];
                
            
        }

        private void progressBar1_EnabledChanged(object sender, EventArgs e)
        {

        }
        private void pct_Click(object sender, EventArgs e)
        {
            index = ++index % img.Images.Count;
            pct.Image = Image.FromFile($@"{Directory.GetCurrentDirectory()}/picture/img{index}.jpg");
            // button1.Visible = true;
            // pct.Image = Image.FromFile("C:\Users\Висковатых.Наталия\Pictures\images(1)");


        }
    }
}
