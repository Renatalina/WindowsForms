using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFFlowLayotPanelButtons
{
    public partial class Form2 : Form
    {
        public Form2(object obj)
        {
            InitializeComponent();
            propertyGrid1.SelectedObject = obj;
        }
    }
}
