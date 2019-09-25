using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFMultipleDocument
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            
            Color cr = Color.FromArgb(random.Next(0,256), random.Next(0, 256), random.Next(0, 256));
            Text = cr.ToString();
             BackColor = cr;

        }
    }
}
