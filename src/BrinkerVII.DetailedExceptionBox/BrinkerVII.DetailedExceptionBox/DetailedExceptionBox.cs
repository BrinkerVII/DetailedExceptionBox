using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrinkerVII
{
	public partial class DetailedExceptionBox : Form
	{
		private Exception exception = null;
		public Exception Exception
		{
			get { return this.exception; }
			set
			{
				this.exception = value;
				this.FillForm();
			}
		}

		public DetailedExceptionBox()
		{
			InitializeComponent();
		}
		public DetailedExceptionBox(Exception e) : this()
		{
			this.Exception = e;
		}
		private void ClearForm()
		{
			foreach (Control control in this.Controls)
			{
				if (control is TextBox)
				{
					(control as TextBox).Text = "";
				}
			}
		}
		private void FillForm()
		{
			this.ClearForm();
			if (this.exception == null) { return; }

			this.txtMessage.Text = this.exception.Message;
			this.txtHResult.Text = this.exception.HResult.ToString();
			this.txtStackTrace.Text = this.exception.StackTrace;
		}
	}
}
