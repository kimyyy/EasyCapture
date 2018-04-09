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
	public partial class ShowPictureForm : Form
	{
		public ShowPictureForm()
		{
			InitializeComponent();
		}

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			string[] filenames = { @"C:\EasyCap\Shot1.jpg" };
			DataObject dataObj = new DataObject(DataFormats.FileDrop, filenames);
			dataObj.SetData(DataFormats.Bitmap, Image.FromFile(filenames[0]));
			pictureBox1.DoDragDrop(pictureBox1.Image, DragDropEffects.All);
		}

		private void ShowPictureForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Console.WriteLine(Size.ToString());
		}

		private void ShowPictureForm_SizeChanged(object sender, EventArgs e)
		{
			
		}
	}
}
