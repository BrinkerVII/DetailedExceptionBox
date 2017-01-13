namespace FunctionalTest
{
	partial class ATestForm
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
			this.btnDivideByZero = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnDivideByZero
			// 
			this.btnDivideByZero.Location = new System.Drawing.Point(12, 12);
			this.btnDivideByZero.Name = "btnDivideByZero";
			this.btnDivideByZero.Size = new System.Drawing.Size(123, 23);
			this.btnDivideByZero.TabIndex = 0;
			this.btnDivideByZero.Text = "Divide by zero";
			this.btnDivideByZero.UseVisualStyleBackColor = true;
			this.btnDivideByZero.Click += new System.EventHandler(this.btnDivideByZero_Click);
			// 
			// ATestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 266);
			this.Controls.Add(this.btnDivideByZero);
			this.Name = "ATestForm";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnDivideByZero;
	}
}

