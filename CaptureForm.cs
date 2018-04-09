using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCapture
{
	public partial class CaptureForm : Form
	{
		private Point MD;
		private Point MU;
		Bitmap bitmap;
		Boolean view = false;

		public CaptureForm(Screen sc)
		{
			InitializeComponent();
			this.Height = Screen.GetBounds(this.Location).Height;
			this.Width = Screen.GetBounds(this.Location).Width;
			bitmap = new Bitmap(Canpus.Width, Canpus.Height);
		}

		private void CaptureForm_KeyPress(object sender, KeyPressEventArgs e)
		{
			// もしescキーが押されたらフォームを閉じる
			if (e.KeyChar == (char)Keys.Escape)
			{
				this.Close();
			}
		}

		private void CaptureForm_MouseDown(object sender, MouseEventArgs e)
		{

		}

		private void CaptureForm_MouseUp(object sender, MouseEventArgs e)
		{

		}

		private void Canpus_MouseDown(object sender, MouseEventArgs e)
		{
			view = true;
			MD.X = e.X;
			MD.Y = e.Y;
		}

		private void Canpus_MouseUp(object sender, MouseEventArgs e)
		{
			Point start = new Point();
			Point end = new Point();
			MU.X = e.X;
			MU.Y = e.Y;

			start.X = Math.Min(MD.X, MU.X);
			start.Y = Math.Min(MD.Y, MU.Y);
			end.X = Math.Max(MD.X, MU.X);
			end.Y = Math.Max(MD.Y, MU.Y);
			view = false;
			this.Close();

			Bitmap bmp = new Bitmap(end.X - start.X, end.Y - start.Y);
			Graphics g = Graphics.FromImage(bmp);
			Size size = new Size(end.X - start.X, end.Y - start.Y);
			g.CopyFromScreen(start, new Point(0, 0), size);
			g.Dispose();
			string filename = @"C:\EasyCap\Shot" + Properties.Settings.Default.ImageNumber + ".jpg";
			bmp.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
			Properties.Settings.Default.ImageNumber++;
			Properties.Settings.Default.Save();
			ShowPictureForm sp = new ShowPictureForm();
			sp.Size = size;
			sp.pictureBox1.Size = size;
			sp.pictureBox1.Image = bmp;
			sp.Show();
		}

		private void DrawRegion(Point start, Point end)
		{
			Pen pen = new Pen(Color.Blue);
			Graphics g = Graphics.FromImage(bitmap);

			//blackPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

			g.Clear(SystemColors.Control);
			g.DrawRectangle(pen, start.X, start.Y, Math.Abs(start.X - end.X), Math.Abs(start.Y - end.Y));
			g.Dispose();
		}

		private void Canpus_MouseMove(object sender, MouseEventArgs e)
		{
			Point p = new Point();
			Point start = new Point();
			Point end = new Point();

			if (view == false)
			{
				return;
			}

			p.X = e.X;
			p.Y = e.Y;

			GetRegion(MD, p, ref start, ref end);

			// 四角形を描画
			DrawRegion(start, end);

			// Canpusに表示
			Canpus.Image = bitmap;
		}

		private void GetRegion(Point p1, Point p2, ref Point start, ref Point end)
		{
			start.X = Math.Min(p1.X, p2.X);
			start.Y = Math.Min(p1.Y, p2.Y);

			end.X = Math.Max(p1.X, p2.X);
			end.Y = Math.Max(p1.Y, p2.Y);
		}
	}
}
