using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsExterminator
{
	public class Exterminator
	{
		/// <summary>
		/// Левая координата отрисовки автомобиля
		/// </summary>
		private float _startPosX;
		/// <summary>
		/// Правая кооридната отрисовки автомобиля
		/// </summary>
		private float _startPosY;
		/// <summary>
		/// Ширина окна отрисовки
		/// </summary>
		private int _pictureWidth;
		//Высота окна отрисовки
		private int _pictureHeight;
		/// <summary>
		/// Ширина отрисовки автомобиля
		/// </summary>
		private const int extermWidth = 170;
		/// <summary>
		/// Ширина отрисовки автомобиля
		/// </summary>
		private const int extermHeight = 160;
		/// <summary>
		/// Максимальная скорость
		/// </summary>
		public int MaxSpeed { private set; get; }
		/// <summary>
		/// Вес автомобиля
		/// </summary>
		public float Weight { private set; get; }
		/// <summary>
		/// Основной цвет кузова
		/// </summary>
		public Color MainColor { private set; get; }
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
		public Exterminator(int maxSpeed, float weight, Color mainColor, Color dopColor, bool
	   frontSpoiler, bool sideSpoiler, bool backSpoiler)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
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


		public void MoveTransport(Direction direction)
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
		public void DrawExterminator(Graphics g)
		{
			Pen pen = new Pen(Color.Black,2);
			//1
			g.DrawLine(pen, _startPosX + 100, _startPosY +110, _startPosX + 170, _startPosY + 120);
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
			//12
			SolidBrush fillQuad = new SolidBrush(Color.Red);
			g.FillRectangle(fillQuad, _startPosX + 61, _startPosY + 90, 10, 10);
			//13
			SolidBrush fillQuadSec = new SolidBrush(Color.Red);
			g.FillRectangle(fillQuad, _startPosX + 61, _startPosY + 140, 10, 10);
		}
	}
}
