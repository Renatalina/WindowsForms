using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarControlLibrary
{
    public enum AnimFrames
    {
        Lemon0, Lemon1, Lemon2, Lemon3, AboutToBlow, EngineBlown
    }
    public partial class UserControl1: UserControl
    {
        private AnimFrames _currFrame = AnimFrames.Lemon0;
        private AnimFrames _currMaxFrame = AnimFrames.Lemon3;
        
        private int _currentSpeed = 50;
        private int _maxSpeed = 150;

        private Rectangle _bottomRect = new Rectangle();

        public delegate void CarEventHandler(string msg);

        public event CarEventHandler Normal;
        public event CarEventHandler AboutToBlow;
        public event CarEventHandler BlewUp;
        private bool _isAnim;
        public bool Animate
        {
            get { return _isAnim; }
            set
            {
                _isAnim = value;
                imageTimer.Enabled = _isAnim;
            }
        }
        private string _carPetName = "Lemon0";
        public string PetName
        {
            get { return _carPetName;
            }
            set
            {
                _carPetName = value;
                Invalidate();
            }
        }
        public int Speed
        {
            get { return _currentSpeed; }
            set
            {
                _currentSpeed = value;

                if (_currentSpeed == 0) // стоим
                {
                    if (AboutToBlow != null)
                    {
                        Normal("Машина стоит!");
                        _currMaxFrame = AnimFrames.Lemon0;
                    }
                }
                else if ((_maxSpeed - _currentSpeed) >= 80) // очень медленно
                {
                    if (AboutToBlow != null)
                    {
                        Normal("Тише едешь дальше будешь!");
                        _currMaxFrame = AnimFrames.Lemon1;
                    }
                }
                else if ((_maxSpeed - _currentSpeed) >= 40) // в пределах безопасной скорости
                {
                    if (AboutToBlow != null)
                    {
                        Normal("Скорость в пределах нормы!");
                        _currMaxFrame = AnimFrames.Lemon2;
                    }
                }
                else if (_currentSpeed <= _maxSpeed) // приближение к границе нормы
                {
                    if (AboutToBlow != null)
                    {
                        Normal("Скорость приближается к границе нормы!");
                        _currMaxFrame = AnimFrames.Lemon3;
                    }
                }
                else if ((_currentSpeed - _maxSpeed) <= 20) // приближение к критической скорости
                {
                    if (AboutToBlow != null)
                    {
                        AboutToBlow("Едь чуть помедленее!");
                        _currMaxFrame = AnimFrames.AboutToBlow;
                    }
                }
                else if (_currentSpeed > _maxSpeed) // превышение
                {
                    //currentSpeed = maxSpeed;
                    if (BlewUp != null)
                    {
                        BlewUp("М-да...тебе крышка...");
                        _currMaxFrame = AnimFrames.EngineBlown;
                    }
                }
            }
        }


        public UserControl1()
        {
            InitializeComponent();
            StretchBox();
        }

        private void StretchBox()
        {
            // конфигурация окна изображения
            currentImage.Top = 0;
            currentImage.Left = 0;
            currentImage.Height = this.Height - 50;
            currentImage.Width = this.Width;
            currentImage.Image = carImages.Images[(int)AnimFrames.Lemon0];

            // выяснения размеров нижнего прямоугольника
            _bottomRect.X = 0;
            _bottomRect.Y = this.Height - 50;
            _bottomRect.Height = this.Height - currentImage.Height;
            _bottomRect.Width = this.Width;
        }

        private void imageTimer_Tick(object sender, EventArgs e)
        {
            if (_isAnim)
            {
                currentImage.Image = carImages.Images[(int)_currFrame];
                PetName = Enum.GetName(typeof(AnimFrames), _currFrame); // название картинки
            }
            // сдвиг фрейма
            int nextFrame = ((int)_currFrame) + 1;
            _currFrame = (AnimFrames)nextFrame;
            if (_currFrame > _currMaxFrame)
                _currFrame = AnimFrames.Lemon0;
        }

        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(Brushes.GreenYellow, _bottomRect);
            graphics.DrawString(PetName, new Font("Times New Roman", 15), Brushes.Black, _bottomRect);


        }
    }
}
