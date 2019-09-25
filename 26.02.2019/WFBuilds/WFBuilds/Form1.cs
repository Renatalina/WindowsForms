using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBuilds
{
    public partial class Form1 : Form
    {
        List<Company> _companyList=new List<Company>();
        public Form1()
        {

            InitializeComponent();
        }

        private void SetBinding()
        {
            _bs.DataSource = _companyList;
            
            //сложная привязка
            dataGridViewInfo.DataSource = _bs;
            //простая привязка
            tbID.DataBindings.Add("Text", _bs, "ID",true);
            tbConactName.DataBindings.Add("Text", _bs, "ContactName", true);
            tbContactPhone.DataBindings.Add("Text", _bs, "ContactPhone", true);
            tbCompanyName.DataBindings.Add("Text", _bs, "CompanyName", true);


            comboBox1.DataSource = _bs;
            comboBox1.DisplayMember = "ContactName";//это свойство класса, а не лэйбл 
            comboBox1.ValueMember = "ID"; //это то что потом можно вытащить


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _companyList.Add(new Company(1, "Philips", "Maria Anders", "(555)37-45"));
            _companyList.Add(new Company(2, "Sony", "Ana Trucilo", "(553)33-45"));
            _companyList.Add(new Company(3, "Sanyo", "Martin Sommer", "(545)27-48"));
            _companyList.Add(new Company(4, "Samsung", "Tomas Hardy", "(527)12-52"));
            _companyList.Add(new Company(5, "Toshiba", "Hanna Moos", "(638)29-78"));
            _companyList.Add(new Company(6, "JVC", "Antonio Morento", "(912)73-44"));

            SetBinding();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            _bs.MoveFirst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _bs.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _bs.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            _bs.MoveLast();
        }

        private void OnPositionChanged(object sender, EventArgs e)
        {
            tbPosition.Text =( _bs.Position+1).ToString();
        }

        private void tbPosition_TextChanged(object sender, EventArgs e)
        {
            int enteredPos; // введенное значение позиции
            bool success = int.TryParse(tbPosition.Text, out enteredPos);
            if (success)
                _bs.Position = enteredPos-1;
        }
    }
}
