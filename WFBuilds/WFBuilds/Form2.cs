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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            TopMost = true;
        }
        private void btnCancelNew_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            if (tbFIO.Text != "")
            {
                ImportExport.FIO = tbFIO.Text;

                if (tbBirthday.Text != "")
                {
                    ImportExport.BORN = tbBirthday.Text;

                    if (tbGender.Text != "")
                    {
                        ImportExport.SEX = tbGender.Text;

                        if (tbCountry.Text != "")
                        {
                            ImportExport.COUNTRY = tbCountry.Text;

                            if (tbCity.Text != "")
                            {
                                ImportExport.CITY = tbCity.Text;

                                if (tbHeight.Text != "")
                                {
                                    ImportExport.HEIGHT = int.Parse(tbHeight.Text);

                                    if (tbWeight.Text != "")
                                    {
                                        ImportExport.WEIDTH = int.Parse(tbWeight.Text);

                                        if (tbHairColor.Text != "")
                                        {
                                            ImportExport.HAIR = tbHairColor.Text;

                                            if (tbEyeColor.Text != "")
                                            {
                                                ImportExport.EYE = tbEyeColor.Text;
                                                Close();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please write all information!");
            }
           
            
        }

       
    }
}
