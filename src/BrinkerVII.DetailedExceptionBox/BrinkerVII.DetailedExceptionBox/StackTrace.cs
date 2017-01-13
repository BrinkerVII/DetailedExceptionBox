using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinkerVII
{
	class StackTrace
	{
		public string String { get; private set; }
		private List<StackTraceLine> lines = new List<StackTraceLine>();
		public ReadOnlyCollection<StackTraceLine> Lines { get; private set; }
		public StackTrace(string s)
		{
			this.String = s;
			this.Lines = new ReadOnlyCollection<StackTraceLine>(this.lines);

			this.ParseString();
		}
		private void ParseString()
		{
			if (this.String == null) { return; }
			this.lines.Clear();
			foreach (string line in this.String.Split('\n'))
			{
				if (!string.IsNullOrWhiteSpace(line))
				{
					this.lines.Add(new StackTraceLine(line));
				}
			}
		}
	}
}
