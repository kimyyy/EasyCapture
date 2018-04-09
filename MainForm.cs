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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void ExitItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void MinimizeItem_Click(object sender, EventArgs e)
		{
			this.Visible = false;
		}

		private void StartItem_Click(object sender, EventArgs e)
		{
			CaptureForm cap = new CaptureForm(Screen.PrimaryScreen);
			cap.ShowDialog();
		}
	}
}
