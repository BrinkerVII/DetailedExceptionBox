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
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.txtStackTrace = new System.Windows.Forms.TextBox();
			this.txtHResult = new System.Windows.Forms.TextBox();
			this.lblMessage = new System.Windows.Forms.Label();
			this.lblHResult = new System.Windows.Forms.Label();
			this.lblStackTrace = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(81, 12);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtMessage.Size = new System.Drawing.Size(488, 95);
			this.txtMessage.TabIndex = 0;
			// 
			// txtStackTrace
			// 
			this.txtStackTrace.Location = new System.Drawing.Point(81, 139);
			this.txtStackTrace.Multiline = true;
			this.txtStackTrace.Name = "txtStackTrace";
			this.txtStackTrace.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtStackTrace.Size = new System.Drawing.Size(488, 67);
			this.txtStackTrace.TabIndex = 1;
			// 
			// txtHResult
			// 
			this.txtHResult.Location = new System.Drawing.Point(81, 113);
			this.txtHResult.Name = "txtHResult";
			this.txtHResult.Size = new System.Drawing.Size(488, 20);
			this.txtHResult.TabIndex = 2;
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.Location = new System.Drawing.Point(25, 15);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(50, 13);
			this.lblMessage.TabIndex = 3;
			this.lblMessage.Text = "Message";
			// 
			// lblHResult
			// 
			this.lblHResult.AutoSize = true;
			this.lblHResult.BackColor = System.Drawing.SystemColors.Control;
			this.lblHResult.Location = new System.Drawing.Point(30, 116);
			this.lblHResult.Name = "lblHResult";
			this.lblHResult.Size = new System.Drawing.Size(45, 13);
			this.lblHResult.TabIndex = 4;
			this.lblHResult.Text = "HResult";
			// 
			// lblStackTrace
			// 
			this.lblStackTrace.AutoSize = true;
			this.lblStackTrace.Location = new System.Drawing.Point(9, 142);
			this.lblStackTrace.Name = "lblStackTrace";
			this.lblStackTrace.Size = new System.Drawing.Size(66, 13);
			this.lblStackTrace.TabIndex = 5;
			this.lblStackTrace.Text = "Stack Trace";
			// 
			// DetailedExceptionBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(581, 392);
			this.Controls.Add(this.lblStackTrace);
			this.Controls.Add(this.lblHResult);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.txtHResult);
			this.Controls.Add(this.txtStackTrace);
			this.Controls.Add(this.txtMessage);
			this.Name = "DetailedExceptionBox";
			this.Text = "DetailedExceptionBox";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.TextBox txtStackTrace;
		private System.Windows.Forms.TextBox txtHResult;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.Label lblHResult;
		private System.Windows.Forms.Label lblStackTrace;
	}
}