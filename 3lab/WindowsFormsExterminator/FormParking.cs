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
	public partial class FormParking : Form
	{
		Parking<IPlane> parking;

		public FormParking()
		{
			InitializeComponent();
			parking = new Parking<IPlane>(20, pictureBoxParking.Width, pictureBoxParking.Height);
			Draw();
		}
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
			Graphics gr = Graphics.FromImage(bmp);
			parking.Draw(gr);
			pictureBoxParking.Image = bmp;
		}
		private void buttonGetSimpleplane_Click(object sender, EventArgs e)//простой самолет
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				var exterm = new Simpleplane(100, 1000, dialog.Color);
				int place = parking + exterm;
				Draw();
			}
		}

		private void buttonGetExterminator_Click(object sender, EventArgs e)//сложный самолет
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				ColorDialog dialogDop = new ColorDialog();
				if (dialogDop.ShowDialog() == DialogResult.OK)
				{
					var exterm = new Exterminator(100, 1000, dialog.Color, dialogDop.Color);
					int place = parking + exterm;
					Draw();
				}
			}
		}
		private void buttonGetOut_Click(object sender, EventArgs e)//забрать
		{
			if (maskedTextBoxParknig.Text != "")
			{
				var exterm = parking - Convert.ToInt32(maskedTextBoxParknig.Text);
				if (exterm != null)
				{
					Bitmap bmp = new Bitmap(pictureBoxLittle.Width,
				   pictureBoxLittle.Height);
					Graphics gr = Graphics.FromImage(bmp);
					exterm.SetPosition(5, 5, pictureBoxLittle.Width,
				   pictureBoxLittle.Height);
					exterm.DrawExterminator(gr);
					pictureBoxLittle.Image = bmp;
				}
				else
				{
					Bitmap bmp = new Bitmap(pictureBoxLittle.Width,
				   pictureBoxLittle.Height);
					pictureBoxLittle.Image = bmp;
				}
				Draw();
			}
		}
	}
}
