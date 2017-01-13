using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace BrinkerVII
{
	class StackTraceLine
	{
		private string bigOldPattern = @"^\s+at\s*([\S\s]+)\sin\s([\S\s]+)\:line\s(\d+)";
		public string String { get; private set; }
		public string Method { get; private set; }
		public string File { get; private set; }
		public string FileName { get; private set; }
		public bool FileExists { get; private set; }
		public int LineNumber { get; private set; }
		private string toStringValue = "";
		public StackTraceLine(string s)
		{
			this.String = s;
			this.DoPatternMatching();
		}
		private void DoPatternMatching()
		{
			Match match = Regex.Match(this.String, bigOldPattern);
			this.Method = match.Groups[1].Value;
			this.File = match.Groups[2].Value;
			this.LineNumber = Int32.Parse(match.Groups[3].Value);

			this.FileExists = System.IO.File.Exists(this.File);
			if (this.FileExists)
			{
				this.FileName = System.IO.Path.GetFileName(this.File);
			}
			else
			{
				this.FileName = this.File;
			}
			this.UpdateToStringValue();
		}
		private void UpdateToStringValue()
		{
			this.toStringValue = string.Format("{0} line {1} : {2}", this.FileName, this.LineNumber, this.Method);
		}
		public override string ToString()
		{
			return this.toStringValue;
		}
	}
}
