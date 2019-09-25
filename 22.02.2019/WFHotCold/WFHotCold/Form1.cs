using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFHotCold
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
         

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((MousePosition.X >= (button1.Location.X+50)|| MousePosition.X <= (button1.Location.X - 50))&&( MousePosition.Y>=(button1.Location.Y+50)||
                MousePosition.Y<=(button1.Location.Y-50)))
                {                    
                label1.Text = "Fire!";
                }
            else
            {
                label1.Text = "Cold";
            }
                        
        }
    }
}
