namespace EasyCapture
{
	partial class CaptureForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Canpus = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.Canpus)).BeginInit();
			this.SuspendLayout();
			// 
			// Canpus
			// 
			this.Canpus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Canpus.Location = new System.Drawing.Point(0, 0);
			this.Canpus.Name = "Canpus";
			this.Canpus.Size = new System.Drawing.Size(642, 385);
			this.Canpus.TabIndex = 0;
			this.Canpus.TabStop = false;
			this.Canpus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canpus_MouseDown);
			this.Canpus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canpus_MouseMove);
			this.Canpus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canpus_MouseUp);
			// 
			// CaptureForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(642, 385);
			this.Controls.Add(this.Canpus);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CaptureForm";
			this.Opacity = 0.1D;
			this.Text = "CaptureForm";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.Canpus)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox Canpus;
	}
}