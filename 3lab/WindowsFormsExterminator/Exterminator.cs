using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsExterminator
{
	public class Exterminator:Simpleplane
	{
		/// <summary>
		/// Дополнительный цвет
		/// </summary>
		public Color DopColor { private set; get; }
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="maxSpeed">Максимальная скорость</param>
		/// <param name="weight">Вес автомобиля</param>
		/// <param name="mainColor">Основной цвет кузова</param>
		/// <param name="dopColor">Дополнительный цвет</param>
		public Exterminator(int maxSpeed, float weight, Color mainColor, Color dopColor):
            base (maxSpeed, weight, mainColor)
		{
			DopColor = dopColor;
			
		}
		/// <summary>
		/// Установка позиции автомобиля
		/// </summary>
		/// <param name="x">Координата X</param>
		/// <param name="y">Координата Y</param>
		/// <param name="width">Ширина картинки</param>
		/// <param name="height">Высота картинки</param>
		public void SetPosition(int x, int y, int width, int height)
		{
			_startPosX = x;
			_startPosY = y;
			_pictureWidth = width;
			_pictureHeight = height;
		}
		/// <summary>
		/// Изменение направления пермещения
		/// </summary>
		/// <param name="direction">Направление</param>


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
		/// <param name="g"></param>
		public override void DrawExterminator(Graphics g)
		{
            SolidBrush fillQuad = new SolidBrush(MainColor);
            g.FillRectangle(fillQuad, _startPosX + 22, _startPosY + 7, 7, 7);
            //13
            SolidBrush fillQuadSec = new SolidBrush(MainColor);
            g.FillRectangle(fillQuad, _startPosX + 22, _startPosY + 37, 7, 7);

            // Pen pen1 = new Pen(Color.Black, 1);
            SolidBrush fillRect = new SolidBrush(DopColor);
            g.FillRectangle(fillRect, _startPosX + 35, _startPosY + 7, 35, 3);
            SolidBrush fillRect1 = new SolidBrush(DopColor);
            g.FillRectangle(fillRect, _startPosX + 35, _startPosY + 41, 35, 3);
            SolidBrush fillEll = new SolidBrush(Color.Red);
            g.FillEllipse(fillEll, _startPosX + 70, _startPosY + 4, 18, 8);
            g.FillEllipse(fillEll, _startPosX + 70, _startPosY + 38, 18, 8);

            base.DrawExterminator(g);
        }
	}
}
