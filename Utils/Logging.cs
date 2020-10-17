using System;
using System.IO;

namespace KaosesPartySizes.Utils
{
	internal class Logging
	{
		public Logging(string logPath)
		{
			this._logPath = logPath;
		}

		public void logString(string message)
		{
			using (StreamWriter sw = File.AppendText(this._logPath))
			{
				sw.WriteLine(message);
			}
		}

		public static void lm(string message)
		{
			using (StreamWriter sw = File.AppendText("..\\\\..\\\\Modules\\\\KaosesPartySizes\\KaosLog.txt"))
			{
				sw.WriteLine(message);
			}
		}

		private string _logPath;
	}
}
