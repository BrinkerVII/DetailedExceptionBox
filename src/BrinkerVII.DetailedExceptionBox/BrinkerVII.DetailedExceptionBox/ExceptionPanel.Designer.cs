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
			this.txtStackTrace = new System.Windows.Forms.TextBox();
			this.txtMessage = new System.Windows.Forms.TextBox();
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
			this.txtHResult.Size = new System.Drawing.Size(488, 20);
			this.txtHResult.TabIndex = 8;
			// 
			// txtStackTrace
			// 
			this.txtStackTrace.Location = new System.Drawing.Point(82, 130);
			this.txtStackTrace.Multiline = true;
			this.txtStackTrace.Name = "txtStackTrace";
			this.txtStackTrace.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtStackTrace.Size = new System.Drawing.Size(488, 67);
			this.txtStackTrace.TabIndex = 7;
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(82, 3);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtMessage.Size = new System.Drawing.Size(488, 95);
			this.txtMessage.TabIndex = 6;
			// 
			// ExceptionPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblStackTrace);
			this.Controls.Add(this.lblHResult);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.txtHResult);
			this.Controls.Add(this.txtStackTrace);
			this.Controls.Add(this.txtMessage);
			this.Name = "ExceptionPanel";
			this.Size = new System.Drawing.Size(635, 266);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblStackTrace;
		private System.Windows.Forms.Label lblHResult;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.TextBox txtHResult;
		private System.Windows.Forms.TextBox txtStackTrace;
		private System.Windows.Forms.TextBox txtMessage;
	}
}
