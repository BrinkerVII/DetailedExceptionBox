using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalTest
{
	internal class RussianDollException : Exception
	{
		public static RussianDollException Create(string topMostException)
		{
			RussianDollException ex0 = new RussianDollException(topMostException);
			RussianDollException ex1 = new RussianDollException("Cyka Blyat!", ex0);
			RussianDollException ex2 = new RussianDollException("BLIN!", ex1);
			RussianDollException ex3 = new RussianDollException("VODKA!", ex2);
			RussianDollException ex4 = new RussianDollException("I don't know anymore", ex3);

			return ex4;
		}

		private RussianDollException(string message) : base(message)
		{

		}
		private RussianDollException(string message, Exception inner) : base(message, inner)
		{

		}
	}
}
