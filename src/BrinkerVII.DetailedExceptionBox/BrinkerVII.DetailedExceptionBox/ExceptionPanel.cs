using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrinkerVII
{
	internal partial class ExceptionPanel : UserControl
	{
		private Exception exception = null;

		public Exception Exception
		{
			get { return this.exception; }
			set
			{
				this.exception = value;
				this.FillPanel();
			}
		}
		public ExceptionPanel()
		{
			InitializeComponent();

			this.Dock = DockStyle.Fill;
		}

		public ExceptionPanel(Exception displayedException) : this()
		{
			this.Exception = displayedException;
		}

		private void ClearPanel()
		{
			foreach (Control control in this.Controls)
			{
				if (control is TextBox)
				{
					(control as TextBox).Text = "";
				}
			}
		}
		private void FillPanel()
		{
			this.ClearPanel();
			if (this.exception == null) { return; }

			this.txtMessage.Text = this.exception.Message;
			this.txtHResult.Text = this.exception.HResult.ToString();
			this.txtStackTrace.Text = this.exception.StackTrace;
		}
	}
}
