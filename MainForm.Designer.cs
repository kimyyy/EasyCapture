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
			this.ScreenPanel = new System.Windows.Forms.PictureBox();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.StartItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MinimizeItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.ScreenPanel)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ScreenPanel
			// 
			this.ScreenPanel.Location = new System.Drawing.Point(188, 12);
			this.ScreenPanel.Name = "ScreenPanel";
			this.ScreenPanel.Size = new System.Drawing.Size(282, 237);
			this.ScreenPanel.TabIndex = 0;
			this.ScreenPanel.TabStop = false;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "EasyCap";
			this.notifyIcon1.Visible = true;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartItem,
            this.ExitItem,
            this.MinimizeItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
			// 
			// StartItem
			// 
			this.StartItem.Name = "StartItem";
			this.StartItem.Size = new System.Drawing.Size(152, 22);
			this.StartItem.Text = "開始";
			// 
			// ExitItem
			// 
			this.ExitItem.Name = "ExitItem";
			this.ExitItem.Size = new System.Drawing.Size(152, 22);
			this.ExitItem.Text = "終了";
			this.ExitItem.Click += new System.EventHandler(this.ExitItem_Click);
			// 
			// MinimizeItem
			// 
			this.MinimizeItem.Name = "MinimizeItem";
			this.MinimizeItem.Size = new System.Drawing.Size(152, 22);
			this.MinimizeItem.Text = "最小化";
			this.MinimizeItem.Click += new System.EventHandler(this.MinimizeItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 261);
			this.Controls.Add(this.ScreenPanel);
			this.Name = "MainForm";
			this.Text = "MainForm";
			((System.ComponentModel.ISupportInitialize)(this.ScreenPanel)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox ScreenPanel;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem StartItem;
		private System.Windows.Forms.ToolStripMenuItem ExitItem;
		private System.Windows.Forms.ToolStripMenuItem MinimizeItem;
	}
}

