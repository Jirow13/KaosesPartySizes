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

		public void LogString(string message)
		{
            using StreamWriter sw = File.AppendText(this._logPath);
            if (sw is not null) sw.WriteLine(message);
        }

		public static void Lm(string message)
		{
			using StreamWriter sw = File.AppendText("..\\\\..\\\\Modules\\\\KaosesPartySizes\\KaosLog.txt");
			if (sw is not null) sw.WriteLine(message);
		}

		private readonly string _logPath;
	}
}
