﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsExterminator
{
	/// <summary>
	/// Параметризованны класс для хранения набора объектов от интерфейса ITransport
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Parking<T> where T : class, IPlane
	{
		/// <summary>
		/// Массив объектов, которые храним
		/// </summary>
		private T[] _places;
		/// <summary>
		/// Ширина окна отрисовки
		/// </summary>
		private int PictureWidth { get; set; }
		/// <summary>
		/// Высота окна отрисовки
		/// </summary>
		private int PictureHeight { get; set; }
		/// <summary>
		/// Размер парковочного места (ширина)
		/// </summary>
		private int _placeSizeWidth = 210;
		/// <summary>
		/// Размер парковочного места (высота)
		/// </summary>
		private int _placeSizeHeight = 80;
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="sizes">Количество мест на парковке</param>
		/// <param name="pictureWidth">Рамзер парковки - ширина</param>
		/// <param name="pictureHeight">Рамзер парковки - высота</param>
		public Parking(int sizes, int pictureWidth, int pictureHeight)
		{
			_places = new T[sizes];
			PictureWidth = pictureWidth;
			PictureHeight = pictureHeight;
			for (int i = 0; i < _places.Length; i++)
			{
				_places[i] = null;
			}
		}
		/// <summary>
		/// Перегрузка оператора сложения
		/// Логика действия: на парковку добавляется автомобиль
		/// </summary>
		/// <param name="p">Парковка</param>
		/// <param name="car">Добавляемый автомобиль</param>
		/// <returns></returns>
		public static int operator +(Parking<T> p, T exterm)
		{
			for (int i = 0; i < p._places.Length; i++)
			{
				if (p.CheckFreePlace(i))
				{
					p._places[i] = exterm;
					p._places[i].SetPosition(5 + i / 5 * p._placeSizeWidth + 5,
					 i % 5 * p._placeSizeHeight + 15, p.PictureWidth,
					p.PictureHeight);
					return i;
				}
			}
			return -1;
		}
		/// <summary>
		/// Перегрузка оператора вычитания
		/// Логика действия: с парковки забираем автомобиль
		/// </summary>
		/// <param name="p">Парковка</param>
		/// <param name="index">Индекс места, с которого пытаемся извлечь объект</param>
		/// <returns></returns>
		public static T operator -(Parking<T> p, int index)
		{
			if (index < 0 || index > p._places.Length)
			{
				return null;
			}
			if (!p.CheckFreePlace(index))
			{
				T exterm = p._places[index];
				p._places[index] = null;
				return exterm;
			}
			return null;
		}
		/// <summary>
		/// Метод проверки заполнености парковочного места (ячейки массива)
		/// </summary>
		/// <param name="index">Номер парковочного места (порядковый номер в массиве)</param>
 /// <returns></returns>
 private bool CheckFreePlace(int index)
		{
			return _places[index] == null;
		}
		/// <summary>
		/// Метод отрисовки парковки
		/// </summary>
		/// <param name="g"></param>
		public void Draw(Graphics g)
		{
			DrawMarking(g);
			for (int i = 0; i < _places.Length; i++)
			{
				if (!CheckFreePlace(i))
				{//если место не пустое
					_places[i].DrawExterminator(g);
				}
			}
		}
		/// <summary>
		/// Метод отрисовки разметки парковочных мест
		/// </summary>
		/// <param name="g"></param>
		private void DrawMarking(Graphics g)
		{
			Pen pen = new Pen(Color.Black, 3);
			//границы праковки
			g.DrawRectangle(pen, 0, 0, (_places.Length / 5) * _placeSizeWidth, 480);
			for (int i = 0; i < _places.Length / 5; i++)
			{//отрисовываем, по 5 мест на линии
				for (int j = 0; j < 6; ++j)
				{//линия рамзетки места
					g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
					i * _placeSizeWidth + 110, j * _placeSizeHeight);
				}
				g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
			}
		}
	}

}
