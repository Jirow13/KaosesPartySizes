using System;
using KaosesPartySizes.Settings;
using TaleWorlds.Core;
using TaleWorlds.Library;

namespace KaosesPartySizes.Utils
{
	public static class Ux
	{
		public static void ShowMessage(string message, Color messageColor, bool printToLog = false)
		{
			InformationManager.DisplayMessage(new InformationMessage(message, messageColor));
			if (printToLog)
			{
				Logging logger = new Logging("..\\\\..\\\\Modules\\\\KaosesPartySizes\\KaosLog.txt");
				logger.logString(message);
			}
		}

		public static void ShowMessageInfo(string message)
		{
			Ux.ShowMessage(message, Color.ConvertStringToColor("#42FF00FF"), KaosesPartySizesSettings.Instance.bLogToFile);
		}

		public static void ShowMessageDebug(string message)
		{
			bool bIsDebug = KaosesPartySizesSettings.Instance.bIsDebug;
			if (bIsDebug)
			{
				Ux.ShowMessage(message, Color.ConvertStringToColor("#E6FF00FF"), false);
				Logging.lm(message);
			}
		}

		public static void ShowMessageError(string message)
		{
			Ux.ShowMessage(message, Color.ConvertStringToColor("#FF000000"), true);
			Logging.lm(message);
		}
	}
}
