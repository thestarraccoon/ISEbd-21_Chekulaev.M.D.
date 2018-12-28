using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsExterminator
{
	public partial class FormExterm : Form
	{
		private IPlane exterminator;
		/// <summary>
		/// Конструктор
		/// </summary>
		public FormExterm()
		{
			InitializeComponent();
		}
		/// <summary>
		/// Метод отрисовки машины
		/// </summary>
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxExterminator.Width, pictureBoxExterminator.Height);
			Graphics gr = Graphics.FromImage(bmp);
			exterminator.DrawExterminator(gr);
			pictureBoxExterminator.Image = bmp;
		}
		/// <summary>
		/// Обработка нажатия кнопки "Создать простой самолет"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonCreateSimpleplane_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			exterminator = new Simpleplane(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
			exterminator.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxExterminator.Width,
		   pictureBoxExterminator.Height);
			Draw();
		}
        /// <summary>
        /// Обработка нажатия кнопки "Создать крутой самолет"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateExterminator_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            exterminator = new Exterminator(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue,
           Color.Yellow);
            exterminator.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxExterminator.Width,
           pictureBoxExterminator.Height);
            Draw();
        }

        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
		{
			//получаем имя кнопки
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					exterminator.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					exterminator.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					exterminator.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					exterminator.MoveTransport(Direction.Right);
					break;
			}
			Draw();
		}
	}
}