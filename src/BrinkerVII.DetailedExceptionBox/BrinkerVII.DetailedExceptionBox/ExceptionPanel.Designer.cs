namespace BrinkerVII
{
	partial class ExceptionPanel
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblStackTrace = new System.Windows.Forms.Label();
			this.lblHResult = new System.Windows.Forms.Label();
			this.lblMessage = new System.Windows.Forms.Label();
			this.txtHResult = new System.Windows.Forms.TextBox();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.listStackTrace = new System.Windows.Forms.ListBox();
			this.txtSource = new System.Windows.Forms.TextBox();
			this.lblSource = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblStackTrace
			// 
			this.lblStackTrace.AutoSize = true;
			this.lblStackTrace.Location = new System.Drawing.Point(10, 133);
			this.lblStackTrace.Name = "lblStackTrace";
			this.lblStackTrace.Size = new System.Drawing.Size(66, 13);
			this.lblStackTrace.TabIndex = 11;
			this.lblStackTrace.Text = "Stack Trace";
			// 
			// lblHResult
			// 
			this.lblHResult.AutoSize = true;
			this.lblHResult.BackColor = System.Drawing.SystemColors.Control;
			this.lblHResult.Location = new System.Drawing.Point(31, 107);
			this.lblHResult.Name = "lblHResult";
			this.lblHResult.Size = new System.Drawing.Size(45, 13);
			this.lblHResult.TabIndex = 10;
			this.lblHResult.Text = "HResult";
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.Location = new System.Drawing.Point(26, 6);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(50, 13);
			this.lblMessage.TabIndex = 9;
			this.lblMessage.Text = "Message";
			// 
			// txtHResult
			// 
			this.txtHResult.Location = new System.Drawing.Point(82, 104);
			this.txtHResult.Name = "txtHResult";
			this.txtHResult.ReadOnly = true;
			this.txtHResult.Size = new System.Drawing.Size(488, 20);
			this.txtHResult.TabIndex = 8;
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(82, 3);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.ReadOnly = true;
			this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtMessage.Size = new System.Drawing.Size(488, 95);
			this.txtMessage.TabIndex = 6;
			// 
			// listStackTrace
			// 
			this.listStackTrace.FormattingEnabled = true;
			this.listStackTrace.Location = new System.Drawing.Point(82, 130);
			this.listStackTrace.Name = "listStackTrace";
			this.listStackTrace.Size = new System.Drawing.Size(488, 108);
			this.listStackTrace.TabIndex = 12;
			// 
			// txtSource
			// 
			this.txtSource.Location = new System.Drawing.Point(82, 244);
			this.txtSource.Name = "txtSource";
			this.txtSource.ReadOnly = true;
			this.txtSource.Size = new System.Drawing.Size(488, 20);
			this.txtSource.TabIndex = 13;
			// 
			// lblSource
			// 
			this.lblSource.AutoSize = true;
			this.lblSource.Location = new System.Drawing.Point(31, 247);
			this.lblSource.Name = "lblSource";
			this.lblSource.Size = new System.Drawing.Size(41, 13);
			this.lblSource.TabIndex = 14;
			this.lblSource.Text = "Source";
			// 
			// ExceptionPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblSource);
			this.Controls.Add(this.txtSource);
			this.Controls.Add(this.listStackTrace);
			this.Controls.Add(this.lblStackTrace);
			this.Controls.Add(this.lblHResult);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.txtHResult);
			this.Controls.Add(this.txtMessage);
			this.Name = "ExceptionPanel";
			this.Size = new System.Drawing.Size(581, 278);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblStackTrace;
		private System.Windows.Forms.Label lblHResult;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.TextBox txtHResult;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.ListBox listStackTrace;
		private System.Windows.Forms.TextBox txtSource;
		private System.Windows.Forms.Label lblSource;
	}
}
