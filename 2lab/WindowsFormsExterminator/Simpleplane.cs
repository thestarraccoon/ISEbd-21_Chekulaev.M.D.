using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsExterminator
{
    public class Simpleplane : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        protected const int extermWidth = 180;
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        protected const int extermHeight = 160;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        public Simpleplane (int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - extermWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - extermHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawExterminator(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 2);
            //1
            g.DrawLine(pen, _startPosX + 100, _startPosY + 110, _startPosX + 170, _startPosY + 120);
            //2
            g.DrawLine(pen, _startPosX + 100, _startPosY + 130, _startPosX + 170, _startPosY + 120);
            //3
            g.DrawLine(pen, _startPosX + 100, _startPosY + 110, _startPosX + 65, _startPosY + 80);
            //4
            g.DrawLine(pen, _startPosX + 100, _startPosY + 130, _startPosX + 65, _startPosY + 160);
            //5
            g.DrawLine(pen, _startPosX + 65, _startPosY + 80, _startPosX + 50, _startPosY + 95);
            //6
            g.DrawLine(pen, _startPosX + 65, _startPosY + 160, _startPosX + 50, _startPosY + 145);
            //7
            g.DrawLine(pen, _startPosX + 50, _startPosY + 95, _startPosX + 65, _startPosY + 110);
            //8
            g.DrawLine(pen, _startPosX + 50, _startPosY + 145, _startPosX + 65, _startPosY + 130);
           //9
            SolidBrush fillRect = new SolidBrush(Color.Blue);
            g.DrawRectangle(pen, _startPosX + 40, _startPosY + 110, 25, 20);
            g.FillRectangle(fillRect, _startPosX + 40, _startPosY + 110, 25, 20);
            //10
            g.DrawLine(pen, _startPosX + 40, _startPosY + 120, _startPosX + 25, _startPosY + 110);
            //11
            g.DrawLine(pen, _startPosX + 40, _startPosY + 120, _startPosX + 25, _startPosY + 130);
            
        }

    }
}
