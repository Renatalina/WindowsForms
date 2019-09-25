using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void cbLeather_CheckedChanged(object sender, EventArgs e)
        {
            grbColor.Visible = cbLeather.Checked;

            //grbColor.Visible = !grbColor.Visible;                
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCars.SelectedItem!=null)
            {
                //MessageBox.Show(listBox1.SelectedItem.ToString());
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var item in clbOptions.CheckedItems)
            {
                builder.Append($"{item.ToString()}\n");
            }
            MessageBox.Show(builder.ToString());
        }
    }
}
