using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net.Core;
using log4net;

namespace EasyCapture
{
	public partial class MainForm : Form
	{
		ILog logger = LogManager.GetLogger(typeof(MainForm));

		public MainForm()
		{
			logger.Info("開始しました");
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
			var cap = new CaptureForm();
			cap.Show();
		}

		private void contextMenuItemConfig_Click(object sender, EventArgs e)
		{

		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			logger.Info("終了します");
		}
	}
}
