using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WFBuilds
{
    public partial class Form1 : Form
    {
        List<Person> _companyList = new List<Person>();
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
            tbBirthday.DataBindings.Add("Text", _bs, "Birthday", true);
            tbCountry.DataBindings.Add("Text", _bs, "Country", true);
            tbCity.DataBindings.Add("Text", _bs, "City", true);
            tbGender.DataBindings.Add("Text", _bs, "Sex", true);
            tbHeight.DataBindings.Add("Text", _bs, "Height", true);
            tbWeight.DataBindings.Add("Text", _bs, "Weight", true);
            tbHairColor.DataBindings.Add("Text", _bs, "Hair", true);
            tbEyeColor.DataBindings.Add("Text", _bs, "Eyes", true);

            cbFIO.DataSource = _bs;
            cbFIO.DisplayMember = "FullName";//это свойство класса, а не лэйбл 
            cbFIO.ValueMember = "ID"; //это то что потом можно вытащить


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            _companyList.Add(new Person(1, "Maria Anders", "25/02/1970", "Woman", "USA", "California", 168, 60, "Brown", "Green"));
            _companyList.Add(new Person(2, "Ana Trucilo", "30/02/1990", "Woman", "Belorassia", "Belacerkov", 162, 70, "White", "Brown"));
            _companyList.Add(new Person(3, "Martin Sommer", "12/01/2001", "Man", "Dania", "Copengagen", 189, 80, "Red", "Brown"));
            _companyList.Add(new Person(4, "Tomas Hardy", "14/07/1977", "Man", "GreatBritan", "London", 179, 75, "Brown", "Blue"));
            _companyList.Add(new Person(5, "Hanna Moos", "26/05/1980", "Woman", "Greece", "Afins", 169, 50, "Black", "Brown"));
            _companyList.Add(new Person(6, "Antonio Morento", "20/11/1984", "Man", "Italy", "Venic", 185, 90, "Black", "Black"));
            _companyList.Add(new Person(7, "Ferdinand Lyacavelli", "10/10/1979", "Man", "Italy", "Roma", 171, 70, "Black", "Blue"));
            _companyList.Add(new Person(8, "Maria Sharapova", "09/08/1991", "Woman", "Rassia", "SantPetersburg", 177, 60, "White", "Grey"));


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
            tbPosition.Text = (_bs.Position + 1).ToString();
        }

        private void tbPosition_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int enteredPos; // введенное значение позиции
                bool success = int.TryParse(tbPosition.Text, out enteredPos);
                if (success)
                    _bs.Position = enteredPos - 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDelClient_Click(object sender, EventArgs e)
        {
            try
            {               
                int index = int.Parse(tbPosition.Text) - 1;
                dataGridViewInfo.Rows.RemoveAt(index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 form = new Form2();

                if (form.ShowDialog() == DialogResult.Cancel)
                {
                    Person person = new Person(_companyList.Count + 1, ImportExport.FIO, ImportExport.BORN, ImportExport.SEX, ImportExport.COUNTRY, ImportExport.CITY,
                        ImportExport.HEIGHT, ImportExport.WEIDTH, ImportExport.HAIR, ImportExport.EYE);

                    _bs.Add(person);
                    //_companyList.Add(person);
                    ImportExport.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    XmlSerializer xml = new XmlSerializer(typeof(List<Person>));

                    using (FileStream stream = File.Create(saveFileDialog1.FileName))
                    {
                        xml.Serialize(stream, _companyList);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _bs_AddingNew(object sender, AddingNewEventArgs e)
        {

        }

        private void DataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Text files (*.txt)|*.txt|Exeml files(*.xml)|*.xml|CS files(*.cs)|*.cs|All files(*.*)|*.*";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<Person>));

                    using (FileStream stream = File.OpenRead(openFileDialog1.FileName))
                    {
                        _companyList = xml.Deserialize(stream) as List<Person>;
                    }
                }
                SetBinding();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void tbBirthday_TextChanged(object sender, EventArgs e)
        {
            int month = DateTime.Parse(tbBirthday.Text).Month;
            int day = DateTime.Parse(tbBirthday.Text).Day;
            string img = "";
            switch (month)
            {
                case 1: img = (day <= 20) ? "козерог" : "водолей"; break;
                case 2: img = (day <= 19) ? "водолей" : "рыбы"; break;
                case 3: img = (day <= 21) ? "рыбы" : "овен"; break;
                case 4: img = (day <= 20) ? "овен" : "телец"; break;
                case 5: img = (day <= 21) ? "телец" : "близнецы"; break;
                case 6: img = (day <= 22) ? "близнецы" : "рак"; break;
                case 7: img = (day <= 23) ? "рак" : "лев"; break;
                case 8: img = (day <= 23) ? "лев" : "дева"; break;
                case 9: img = (day <= 24) ? "дева" : "весы"; break;
                case 10: img = (day <= 23) ? "весы" : "скорпион"; break;
                case 11: img = (day <= 23) ? "скорпион" : "стрелец"; break;
                case 12: img = (day <= 22) ? "стрелец" : "козерог"; break;
            }
            pbZodiack.Image = Image.FromFile(Environment.CurrentDirectory + $@"\img\{img}.jpg");

            lblZodiac.Text = img;

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 form = new Form3();
                if (form.ShowDialog() == DialogResult.Cancel)
                {                   
                    List<Person> _personList = new List<Person>();
                    foreach (Person item in _companyList)
                    {
                        if (item.Birthday == ImportExport.FAIND)
                        {
                            _personList.Add(item);
                        }
                        if (item.City == ImportExport.FAIND)
                        {
                            _personList.Add(item);
                        }
                        if (item.Country == ImportExport.FAIND)
                        {
                            _personList.Add(item);
                        }
                        if (item.Eyes == ImportExport.FAIND)
                        {
                            _personList.Add(item);
                        }
                        if (item.FullName == ImportExport.FAIND)
                        {
                            _personList.Add(item);
                        }
                        if (item.Hair == ImportExport.FAIND)
                        {
                            _personList.Add(item);
                        }
                        if (item.Sex == ImportExport.FAIND)
                        {
                            _personList.Add(item);
                        }                        

                    }
                    dataGridViewInfo.DataSource = _personList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewInfo.DataSource = null;
            DataFileToolStripMenuItem_Click(sender, e);


        }
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 form = new Form3();
                if (form.ShowDialog() == DialogResult.Cancel)
                {
                    int buffer = int.Parse(ImportExport.FAIND);
                    List<Person> _personList = new List<Person>();
                    foreach (Person item in _companyList)
                    {
                        if (item.Height == buffer)
                        {
                            _personList.Add(item);
                        }
                        if (item.Weight == buffer)
                        {
                            _personList.Add(item);
                        }
                    }
                    dataGridViewInfo.DataSource = _personList;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}




