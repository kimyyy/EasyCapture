namespace EasyCapture
{
	partial class MainForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.contextMenuStripItemStart = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStripItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuItemConfig = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "EasyCap";
			this.notifyIcon1.Visible = true;
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuStripItemStart,
            this.contextMenuItemConfig,
            this.contextMenuStripItemExit});
			this.contextMenuStrip.Name = "contextMenuStrip1";
			this.contextMenuStrip.Size = new System.Drawing.Size(181, 92);
			// 
			// contextMenuStripItemStart
			// 
			this.contextMenuStripItemStart.Name = "contextMenuStripItemStart";
			this.contextMenuStripItemStart.Size = new System.Drawing.Size(180, 22);
			this.contextMenuStripItemStart.Text = "開始";
			this.contextMenuStripItemStart.Click += new System.EventHandler(this.StartItem_Click);
			// 
			// contextMenuStripItemExit
			// 
			this.contextMenuStripItemExit.Name = "contextMenuStripItemExit";
			this.contextMenuStripItemExit.Size = new System.Drawing.Size(180, 22);
			this.contextMenuStripItemExit.Text = "終了";
			this.contextMenuStripItemExit.Click += new System.EventHandler(this.ExitItem_Click);
			// 
			// contextMenuItemConfig
			// 
			this.contextMenuItemConfig.Name = "contextMenuItemConfig";
			this.contextMenuItemConfig.Size = new System.Drawing.Size(180, 22);
			this.contextMenuItemConfig.Text = "設定";
			this.contextMenuItemConfig.Click += new System.EventHandler(this.contextMenuItemConfig_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(230, 147);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Opacity = 0D;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "MainForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem contextMenuStripItemStart;
		private System.Windows.Forms.ToolStripMenuItem contextMenuStripItemExit;
		private System.Windows.Forms.ToolStripMenuItem contextMenuItemConfig;
	}
}

