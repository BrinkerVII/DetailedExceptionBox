namespace BrinkerVII
{
	partial class DetailedExceptionBox
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
			this.btnClose = new System.Windows.Forms.Button();
			this.btnLevelUp = new BrinkerVII.ImageButton();
			this.btnLevelDown = new BrinkerVII.ImageButton();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Location = new System.Drawing.Point(159, 137);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			// 
			// btnLevelUp
			// 
			this.btnLevelUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLevelUp.Image = global::BrinkerVII.Properties.Resources.appbar_chevron_up;
			this.btnLevelUp.Location = new System.Drawing.Point(101, 137);
			this.btnLevelUp.Name = "btnLevelUp";
			this.btnLevelUp.Size = new System.Drawing.Size(23, 23);
			this.btnLevelUp.SizeMode = BrinkerVII.ImageButtonSizeMode.Normal;
			this.btnLevelUp.TabIndex = 3;
			this.btnLevelUp.UseVisualStyleBackColor = true;
			// 
			// btnLevelDown
			// 
			this.btnLevelDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLevelDown.Image = global::BrinkerVII.Properties.Resources.appbar_chevron_down;
			this.btnLevelDown.Location = new System.Drawing.Point(130, 137);
			this.btnLevelDown.Name = "btnLevelDown";
			this.btnLevelDown.Size = new System.Drawing.Size(23, 23);
			this.btnLevelDown.SizeMode = BrinkerVII.ImageButtonSizeMode.Normal;
			this.btnLevelDown.TabIndex = 2;
			this.btnLevelDown.UseVisualStyleBackColor = true;
			// 
			// DetailedExceptionBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(246, 172);
			this.Controls.Add(this.btnLevelUp);
			this.Controls.Add(this.btnLevelDown);
			this.Controls.Add(this.btnClose);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "DetailedExceptionBox";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DetailedExceptionBox";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnClose;
		private ImageButton btnLevelDown;
		private ImageButton btnLevelUp;
	}
}