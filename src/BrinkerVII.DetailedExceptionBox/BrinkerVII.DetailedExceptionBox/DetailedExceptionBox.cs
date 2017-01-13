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

			this.currentExceptionPanel = new ExceptionPanel(this.displayedException);
			this.Controls.Add(this.currentExceptionPanel);

			this.DisplayedExceptionChanged?.Invoke(this, oldException);
		}
	}
}
