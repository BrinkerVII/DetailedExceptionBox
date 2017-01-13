using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrinkerVII;

namespace FunctionalTest
{
	public partial class ATestForm : Form
	{
		public ATestForm()
		{
			InitializeComponent();
		}

		private void btnDivideByZero_Click(object sender, EventArgs e)
		{
			try { this.DivideByZero(); }
			catch (Exception ex)
			{
				(new DetailedExceptionBox(ex)).Show();
			}
		}

		private void DivideByZero()
		{
			int totallyNotZero = 5 - 5;
			int q = 5 / totallyNotZero;
			MessageBox.Show(q.ToString());
		}
	}
}
