using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using System.IO;

namespace EasyCapture
{
	public partial class CaptureForm : Form
	{

		ILog logger = LogManager.GetLogger(typeof(CaptureForm));

		private Point mouseDown;
		private Point mouseUp;
		Bitmap bitmap;
		Boolean view = false;

		public CaptureForm()
		{
			InitializeComponent();
			Point point = Cursor.Position;
			Screen sc = Screen.FromPoint(point);
			Location = sc.Bounds.Location;
			Height = sc.Bounds.Height;
			Width = sc.Bounds.Width;
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

		private void Canpus_MouseDown(object sender, MouseEventArgs e)
		{
			view = true;
			mouseDown.X = Cursor.Position.X;
			mouseDown.Y = Cursor.Position.Y;
		}

		private void Canpus_MouseUp(object sender, MouseEventArgs e)
		{
			Point start = new Point();
			Point end = new Point();
			mouseUp.X = Cursor.Position.X;
			mouseUp.Y = Cursor.Position.Y;
			if (mouseDown.X == mouseUp.X || mouseDown.Y == mouseUp.Y)
			{
				this.Close();
				return;
			}

			// 左上と右下を決定
			start.X = Math.Min(mouseDown.X, mouseUp.X);
			start.Y = Math.Min(mouseDown.Y, mouseUp.Y);
			end.X = Math.Max(mouseDown.X, mouseUp.X);
			end.Y = Math.Max(mouseDown.Y, mouseUp.Y);
			view = false;
			this.Close();

			// 画像の保存
			Bitmap bmp = new Bitmap(end.X - start.X, end.Y - start.Y);
			Graphics g = Graphics.FromImage(bmp);
			Size size = new Size(end.X - start.X, end.Y - start.Y);
			g.CopyFromScreen(start, new Point(0, 0), size);
			g.Dispose();
			string picFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
			string filePath = picFolderPath + Properties.Settings.Default.ImageNumber + ".jpg";
			bmp.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
			logger.InfoFormat("画像は{0}に保存されました。", filePath);
			Properties.Settings.Default.ImageNumber++;
			Properties.Settings.Default.Save();

			// 画像の表示
			var sp = new ShowPictureForm();
			sp.Size = new Size(end.X - start.X + 16, end.Y - start.Y + 39);
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

			GetRegion(mouseDown, p, ref start, ref end);

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

		private void Canpus_MouseLeave(object sender, EventArgs e)
		{
			Point point = Cursor.Position;
			Screen sc = Screen.FromPoint(point);
			Location = sc.Bounds.Location;
			Height = sc.Bounds.Height;
			Width = sc.Bounds.Width;
		}
	}
}
