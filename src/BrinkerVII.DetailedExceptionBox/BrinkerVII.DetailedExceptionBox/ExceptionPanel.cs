using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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
			this.listStackTrace.Items.Clear();
		}
		private void FillPanel()
		{
			this.ClearPanel();
			if (this.exception == null) { return; }

			this.txtMessage.Text = this.exception.Message;
			this.txtHResult.Text = this.exception.HResult.ToString();
			this.txtSource.Text = this.exception.Source;

			StackTrace trace = new StackTrace(this.exception.StackTrace);
			foreach (StackTraceLine line in trace.Lines)
			{
				this.listStackTrace.Items.Add(line);
			}
		}
	}
}
