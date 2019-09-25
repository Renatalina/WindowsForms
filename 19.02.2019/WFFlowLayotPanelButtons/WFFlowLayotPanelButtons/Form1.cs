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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Создаем и инициализируем генератор случайных чисел
            // текущим значением секунд в диапазоне от 0 до 59
            Random rand = new Random(DateTime.Now.Second);
            //Random rand = new Random();

            // Создаем btnCount кнопок случайных размеров
            const int btnCount = 10;
            for (int i = 0; i < btnCount; i++)
            {
                Button btn = new Button();// Создали кнопку
                btn.Parent = flowLayoutPanel1;// Привязали к панели
                btn.Text = "Кнопка " + Convert.ToString(i + 1);// Подписали
                btn.AutoSize = true;// Подстроили под текст
                // Регистрируем общий с компоновочной панелью обработчик кнопок
                btn.Click += elementClick;
                // Создаем структуру и инициализируем начальным размером
                Size btnSize = btn.PreferredSize;// Предпочтительный размер
                // Корректируем структуру случайным образом в сторону увеличения
                //btnSize.Width += rand.Next(5, 100);
                //btn.Height += rand.Next(10, 100);
                btnSize.Width = (int)(btnSize.Width * (1 + 2 * rand.NextDouble()));
                btnSize.Height = (int)(btnSize.Height * (1 + 2 * rand.NextDouble()));
                // Задаем размер кнопки
                btn.Size = btnSize;
                // Маркируем
                btn.Name = "btn" + (i + 1);
                // Центрируем построчно
                btn.Anchor = AnchorStyles.None;
            }
        }

        // Общий обработчик для кнопок и панели
        void elementClick(object sender, EventArgs e)
        {
            // показ готовой формы
            Form2 f2 = new Form2(sender);
            f2.ShowDialog();
        }


    }
}
