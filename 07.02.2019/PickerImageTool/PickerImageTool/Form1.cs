using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickerImageTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime start = dateTimePicker1.Value;
            DateTime end = dateTimePicker2.Value;
            if (start > end)
            {
                DateTime temp = start;
                start = end;
                end = temp;
            }
        
            int yers = end.Year - start.Year;
            int month = end.Month - start.Month;
            int day = end.Day - start.Day;            
            int hour = end.Hour - start.Hour;

            int n = (end.Month + 10) % 12 + 1;//это формула для месяца, что бы на один месяц раньше 

            if(hour<0)
            {
                hour += 24;
                day--;
            }

            if (day<0)
            {
                day += DateTime.DaysInMonth(end.Year, (end.Month + 10) % 12 + 1);
                month--;
            }

            if(month<0)
            {
                month += 12; 
                yers--;
            }

            
           label3.Text=$"Yers: {yers}, Month: {month}, Day: {day}";

        }

       
    }
}
