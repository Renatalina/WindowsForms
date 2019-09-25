using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFDataGreitView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Example();
            Example2();
        }
        private void Example()
        {
            //DataGridView column = new DataGridViewTextBoxColumn();
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());//добавление новой колонки
            dataGridView1.Columns.Add("Name","Name");
            dataGridView1.Rows.Add(2);//это строка
            dataGridView1.Rows.Add();
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewComboBoxCell boxCell = new DataGridViewComboBoxCell();
            boxCell.Items.AddRange("Table", "Chair", "Stool");
            row.Cells.Add(boxCell);
            row.Cells.Add(new DataGridViewCheckBoxCell { Value = true });
            dataGridView1.Rows.Add(row);

            DataGridViewCell cell = dataGridView1.Rows[2].Cells[3];//это мы получили ячейку (сторка 1, колонка 0)
            if(cell is DataGridViewComboBoxCell)
            {
                (cell as DataGridViewComboBoxCell).Items.AddRange("C#", "C++");
            }
           cell = dataGridView1.Rows[3].Cells[3];

            DataGridViewComboBoxCell currentCell = cell as DataGridViewComboBoxCell;//это мы получили ячейку (сторка 1, колонка 0)
            if (currentCell !=null)
            {
                currentCell.Items.AddRange("WindowsForms", "WPF");
            }

        }
        private void Example2()
        {
            //DataGridView _grid = new DataGridView();
            //_grid.Dock = DockStyle.Fill;//Задает позицию и способ закрепления элемента управления.
            dataGridView2.AllowUserToAddRows = false;//Возвращает или задает значение, указывающее, отображается ли для пользователя параметр добавления строк.

            // выравнивание всех значений по центру
            dataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Controls.Add(_grid);
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "TextBoxColumn",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            }
                );

            dataGridView2.Columns.Add(new DataGridViewLinkColumn());
            dataGridView2.Columns[1].HeaderText = "LinkColumn";
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns.Add(new DataGridViewButtonColumn());
            dataGridView2.Columns[2].HeaderText = "ButtonColumn";
            dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns.Add(new DataGridViewCheckBoxColumn());
            dataGridView2.Columns[3].HeaderText = "CheckBoxColumn";
            dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns.Add(new DataGridViewComboBoxColumn());
            dataGridView2.Columns[4].HeaderText = "ComboBoxColumn";
            dataGridView2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns.Add(new DataGridViewImageColumn());
            dataGridView2.Columns[5].HeaderText = "ViewImageColumn";
            //dataGridView2.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView2.Rows.Add(); // добавляет одну строку, заполняя ее значениями по умолчанию
            // добавляем еще 4 строки - все ячейки TextBox
            for (int i = 0; i < 4; i++)
            {
                DataGridViewRow heter_row = new DataGridViewRow();

                for (int j = 0; j < dataGridView2.Columns.Count; j++)
                    heter_row.Cells.Add(new DataGridViewTextBoxCell());

                switch (i)
                {
                    case 0:
                        heter_row.HeaderCell.Value = "Value";
                        break;
                    case 1:
                        heter_row.HeaderCell.Value = "ValueType";
                        break;
                    case 2:
                        heter_row.HeaderCell.Value = "FormattedValue";
                        break;
                    case 3:
                        heter_row.HeaderCell.Value = "FormattedValueType";
                        break;
                }
                dataGridView2.Rows.Add(heter_row);
            }
            // Корректирует ширину заголовков строк в соответствии с содержимым заголовка (автоподбор ширины заголовков)
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders; // изменяется автоматически
                                                                                                              // регулируются один раз - автоматически не изменяется
                                                                                                              //dataGridView2.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);


            // Заполнение строки 0

            DataGridViewRow row0 = dataGridView2.Rows[0];
            row0.HeaderCell.Value = "Внешний вид ячейки";

            DataGridViewTextBoxCell cell0 = (DataGridViewTextBoxCell)row0.Cells[0];
            cell0.Value = "Я просто текст";

            DataGridViewLinkCell cell1 = (DataGridViewLinkCell)row0.Cells[1];
            cell1.Value = "Я ссылка!";

            DataGridViewButtonCell cell2 = (DataGridViewButtonCell)row0.Cells[2];
            cell2.Value = "Я кнопка";

            DataGridViewCheckBoxCell cell3 = (DataGridViewCheckBoxCell)row0.Cells[3];
            cell3.Value = true;

            DataGridViewComboBoxCell cell4 = (DataGridViewComboBoxCell)row0.Cells[4];
            cell4.Items.AddRange(new string[] { "Trace", "Debug", "Release" });
            cell4.Value = "Release";

            DataGridViewImageCell cell5 = (DataGridViewImageCell)row0.Cells[5];
            cell5.ImageLayout = DataGridViewImageCellLayout.Zoom;
            //cell5.Value = Image.FromFile("!.bmp");
            //cell5.Value = DataGridView.Properties.Resources._; // image-ресурс "!.bmp"
            cell5.Value = WFDataGreitView.Properties.Resources.HappyDude; // image-ресурс "HappyDude"

            // Заполнение строки 1
            for (int j = 0; j < dataGridView2.Columns.Count; j++)
                dataGridView2.Rows[1].Cells[j].Value = dataGridView2.Rows[0].Cells[j].Value.ToString();

            // Заполнение строки 2
            for (int j = 0; j < dataGridView2.Columns.Count; j++)
                dataGridView2.Rows[2].Cells[j].Value =
                 dataGridView2.Rows[0].Cells[j].ValueType.ToString();

            // Заполнение строки 3
            for (int j = 0; j < dataGridView2.Columns.Count; j++)
                dataGridView2.Rows[3].Cells[j].Value =
                  dataGridView2.Rows[0].Cells[j].FormattedValue.ToString();

            // Заполнение строки 4
            for (int j = 0; j < dataGridView2.Columns.Count; j++)
                dataGridView2.Rows[4].Cells[j].Value =
                  dataGridView2.Rows[0].Cells[j].FormattedValueType.ToString();  /**/
        }
    }
}
