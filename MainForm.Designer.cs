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
			this.ScreenPanel = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.ScreenPanel)).BeginInit();
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 261);
			this.Controls.Add(this.ScreenPanel);
			this.Name = "MainForm";
			this.Text = "MainForm";
			((System.ComponentModel.ISupportInitialize)(this.ScreenPanel)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox ScreenPanel;
	}
}

