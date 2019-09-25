using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFResourses
{

    public partial class Form1 : Form
    {
        private ResourceManager _manager;
        private int _label=1;
        private int _icon = 34;
        public Form1()
        {
            InitializeComponent();
        }
 private void Form1_Load(object sender, EventArgs e)
        {
            _manager = new ResourceManager("WFResourses.Properties.Resources", Assembly.GetExecutingAssembly());
            lblRest.Text=_manager.GetString($"String{_label}");
            Icon=_manager.GetObject($"MISC{_icon}") as Icon;



            timerRest.Enabled = true;
        }
        private void timerRest_Tick(object sender, EventArgs e)
        {
            if(_label>3)
            {
                _label = 1;
            }
            else
            {
                _label++;

            }
            lblRest.Text = _manager.GetString($"String{_label}");
            if(_icon>36)
            {
                _icon = 34;
            }
            else
            {
                _icon++;
            }
            Icon = _manager.GetObject($"MISC{_icon}") as Icon;
        }

       
    }
}
