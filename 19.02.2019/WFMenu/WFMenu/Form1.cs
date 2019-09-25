using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFMenu
{
    public partial class Form1 : Form
    {
        private FontStyle _fontStyle;

        public Form1()
        {
            InitializeComponent();
            foreach(FontFamily item in FontFamily.Families)
            {
                FontFamilytoolStripComboBox1.Items.Add(item.Name);//так мы добавим себе все шрифты
            }
            FontFamilytoolStripComboBox1.Text = "Arial";
            _fontStyle = FontStyle.Regular;

            ClockToolStripStatusLabel.Text = DateTime.Now.ToLongTimeString(); // время
            checkedDropDownButton = TimeToolStripMenuItem;
            checkedDropDownButton.Checked = true; // отмечена кнопка - время
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();//это именно команда выход из всего приложения
            // Close();//можно по разному или эксит или клоус
            this.Close();//клоус закрывает текущее окно
            
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            //about.Show();
            about.ShowDialog();

        }

        private void FontFamilytoolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
              }

        private void SizeToolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelTest.Font = new Font(new FontFamily(FontFamilytoolStripComboBox1.Text),
                Convert.ToSingle(SizeToolStripComboBox1.Text),
                _fontStyle);

        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fontStyle ^= FontStyle.Bold;
            SizeToolStripComboBox1_SelectedIndexChanged(sender, e);
            
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fontStyle ^= FontStyle.Italic;
            SizeToolStripComboBox1_SelectedIndexChanged(sender, e);

        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                try
                {
                    labelTest.ForeColor = Color.FromName(toolStripTextBox1.Text);
                }
                catch { }
                
            }
        }
        private void FontSizeChange(object sender, EventArgs e)
        {
            // нахожу размер = текущий размер + значение Tag в пункте ContextMenu
            int size = Convert.ToInt32(SizeToolStripComboBox1.Text) + Convert.ToInt32(((ToolStripMenuItem)sender).Tag);

            if (size < 4 || size > 28) // проверка выхода за границы
                size = 14;

            SizeToolStripComboBox1.Text = size.ToString(); // меняю размер


            SizeToolStripComboBox1_SelectedIndexChanged(sender, e);
        }

        private void labelTest_MouseHover(object sender, EventArgs e)
        {
            StateToolStripStatusLabel.Text = "It is mark";
        }

        private void labelTest_MouseLeave(object sender, EventArgs e)
        {
            StateToolStripStatusLabel.Text = "Weiting...";
        }

        enum DateTimeFormat { ShowClock, ShowDay } // формат отображения даты

        DateTimeFormat dtFormat = DateTimeFormat.ShowClock; // время

        ToolStripMenuItem checkedDropDownButton; // текущая нажатая кнопка


        private void StatusTimer_Tick(object sender, EventArgs e)
        {
            string info = "";
            switch (dtFormat)
            {
                case DateTimeFormat.ShowClock:
                    info = DateTime.Now.ToLongTimeString();
                    break;
                case DateTimeFormat.ShowDay:
                    info = DateTime.Now.ToLongDateString();
                    break;
            }
            ClockToolStripStatusLabel.Text = info;
        }

        private void DateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // установка отметки для кнопки и даты для панели
            checkedDropDownButton.Checked = false;
            dtFormat = DateTimeFormat.ShowDay;
            checkedDropDownButton = DateToolStripMenuItem;
            checkedDropDownButton.Checked = true;
        }

        private void TimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // установка отметки для кнопки и времени для панели
            checkedDropDownButton.Checked = false;
            dtFormat = DateTimeFormat.ShowClock;
            checkedDropDownButton = TimeToolStripMenuItem;
            checkedDropDownButton.Checked = true;
        }


        private void TextToolStripTextBox_Click(object sender, EventArgs e)
        {
            TextToolStripTextBox.Text = "";
            TextToolStripTextBox.ForeColor = Color.Black;
            TextToolStripTextBox.Font = new Font(TextToolStripTextBox.Font, FontStyle.Regular);

        }

        private void TextToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            labelTest.Text = TextToolStripTextBox.Text;

        }
        float currFontSize = 12f;
        const int MinFontSize = 4;
        const int MaxFontSize = 30;

        private void PlusToolStripSplitButton_Click(object sender, EventArgs e)
        {

            // увеличение шрифта
            currFontSize += 2;
            if (currFontSize > MaxFontSize)
                currFontSize = 12;

            // изменяю размер - шрифт тот же
            labelTest.Font = new Font(labelTest.Font.FontFamily, currFontSize);

            Text = $"Выбранный размер шрифта: {currFontSize}";
        }

        private void MinusToolStripSplitButton_Click(object sender, EventArgs e)
        {
            // уменьшение шрифта
            currFontSize -= 2;
            if (currFontSize < MinFontSize)
                currFontSize = 12;

            // изменяю размер - шрифт тот же
            labelTest.Font = new Font(labelTest.Font.FontFamily, currFontSize);

            Text = $"Выбранный размер шрифта: {currFontSize}";
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            btnProgress.Enabled = false;

            for (int i = 0; i < toolStripProgressBar.Maximum; i++)
            {
                toolStripProgressBar.Value = i;
                //toolStripProgressBar.Increment(1);
                //toolStripProgressBar.PerformStep(); // свойство Step = 1
                System.Threading.Thread.Sleep(100);
            }
            toolStripProgressBar.Value = 0;
            btnProgress.Enabled = true;
        }
    }
}
