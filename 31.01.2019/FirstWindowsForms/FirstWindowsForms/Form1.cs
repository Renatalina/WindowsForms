using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsForms
{
    public partial class Form1 : Form//посмотреть код нажать на Forms1 + <>
    {
        StringBuilder _builder;
        ContentAlignment _aligment;
        Array _array;
        int _position;
        public Form1()
        {
           
            InitializeComponent();//
            _builder = new StringBuilder();
            this.Text = "140286";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _builder.Append("Loaded\n");

            _array = Enum.GetValues(_aligment.GetType());
            this.BackColor = Color.Aquamarine;
        }

        private void MainForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _builder.Append("Form is Closing nom?\n");

            
           /* if(MessageBox.Show("It Closed?","To Closing", MessageBoxButtons.YesNo)==DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            switch (e.CloseReason)
            {
                case CloseReason.None:
                    break;
                case CloseReason.WindowsShutDown:
                    break;
                case CloseReason.MdiFormClosing:
                    break;
                case CloseReason.UserClosing:
                    MessageBox.Show(CloseReason.UserClosing.ToString());
                    break;
                case CloseReason.TaskManagerClosing:
                    MessageBox.Show("TaskManagerClosing");
                    break;
                case CloseReason.FormOwnerClosing:
                    break;
                case CloseReason.ApplicationExitCall:
                    MessageBox.Show("ApplicationExitCall");
                    break;
                default:
                    break;
            }*/

        }

        private void button1_Click(object sender, EventArgs e)//когда нажимаем кнопку отправить форму
        {
            //Application.Exit();
            if(Login.Text=="John" && Password.Text=="Doe")
            {
                MessageBox.Show("Ok");
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = $"x:{e.X} Y:{e.Y}";
           

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)//это когда мы нажали мышку, а точнее отжали Ап!
        {
            switch (e.Button)
            {
                case MouseButtons.Left://левая кнопка мыши
                    break;
                case MouseButtons.None:
                    break;
                case MouseButtons.Right://правая кнопка мыши
                    MessageBox.Show("Right");
                    break;
                case MouseButtons.Middle:// когда мы колесеко нажимаем
                    MessageBox.Show("Middle");
                    break;
                case MouseButtons.XButton1:
                    break;
                case MouseButtons.XButton2:
                    break;
                default:
                    break;
            }
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Random _random = new Random();
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Point point = new Point
            {
                X = _random.Next(ClientSize.Width - button1.Width),
                Y = _random.Next(ClientSize.Height - button1.Height)
            };

            button1.Location = point;//кнопка будет убегать от нас 

        }
        private void button3_Click(object sender, EventArgs e)
        {
            button3.TextAlign = ContentAlignment.MiddleCenter;
            button3.ImageAlign = ContentAlignment.MiddleCenter;
            button3.Text = ContentAlignment.MiddleCenter.ToString();

            _position = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if(_position>=_array.Length)
            {
                _position = 0;
            }
            _aligment =(ContentAlignment)Enum.Parse(_aligment.GetType(), _array.GetValue(_position).ToString());
            button3.TextAlign = _aligment;
            button3.ImageAlign = _aligment;
            button3.Text = _aligment.ToString();
            _position++;
        }

      
    }
}
