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
	public delegate void DisplayedExceptionChangedEventHandler(DetailedExceptionBox sender, Exception oldException);
	public partial class DetailedExceptionBox : Form
	{
		private Stack<Exception> exceptionStack = new Stack<Exception>();
		public event DisplayedExceptionChangedEventHandler DisplayedExceptionChanged;
		private Exception exception;
		public Exception Exception
		{
			get { return this.exception; }
			set
			{
				this.exception = value;
				if (this.displayedException == null)
				{
					this.ChangeDisplayedException(this.exception);
				}
			}
		}
		private Exception displayedException;
		public Exception DisplayedException
		{
			get { return this.displayedException; }
		}
		private ExceptionPanel currentExceptionPanel = null;
		public DetailedExceptionBox()
		{
			InitializeComponent();

			this.btnLevelDown.Click += BtnLevelDown_Click;
			this.btnLevelUp.Click += BtnLevelUp_Click;
			this.btnClose.Click += (sender, e) => this.Close();
			this.FormClosing += (sender, e) => this.DialogResult = DialogResult.Cancel;
		}

		private void BtnLevelUp_Click(object sender, EventArgs e)
		{
			if (this.exceptionStack.Count > 0)
			{
				this.ChangeDisplayedException(this.exceptionStack.Pop());
			}
		}

		private void BtnLevelDown_Click(object sender, EventArgs e)
		{
			if (this.displayedException.InnerException != null)
			{
				this.exceptionStack.Push(this.displayedException);
				this.ChangeDisplayedException(this.displayedException.InnerException);
			}
		}

		public DetailedExceptionBox(Exception e) : this()
		{
			this.Exception = e;
		}
		private void ChangeDisplayedException(Exception newException)
		{
			bool isNull = this.displayedException == null;
			Exception oldException = this.displayedException;
			if (this.displayedException != newException)
			{
				this.displayedException = newException;
				this.OnDisplayedExceptionChanged(oldException);
			}
		}
		protected virtual void OnDisplayedExceptionChanged(Exception oldException)
		{
			if (this.currentExceptionPanel != null)
			{
				this.Controls.Remove(this.currentExceptionPanel);
				this.currentExceptionPanel.Dispose();
			}

			this.currentExceptionPanel = new ExceptionPanel(this.displayedException)
			{
				Top = 10
			};
			this.Controls.Add(this.currentExceptionPanel);
			this.btnLevelDown.Enabled = this.displayedException.InnerException != null;
			this.btnLevelUp.Enabled = this.exceptionStack.Count > 0;
			this.Size = new Size(this.currentExceptionPanel.Width + this.currentExceptionPanel.Left + 20, this.currentExceptionPanel.Height + this.currentExceptionPanel.Top + 100);

			this.DisplayedExceptionChanged?.Invoke(this, oldException);
		}

	}
}
