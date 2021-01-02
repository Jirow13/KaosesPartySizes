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
				logger.LogString(message);
			}
		}

		public static void ShowMessageInfo(string message)
		{
			if (KaosesPartySizesSettings.Instance is { } instance)
				Ux.ShowMessage(message, Color.ConvertStringToColor("#42FF00FF"), instance.BLogToFile);
		}

		public static void ShowMessageDebug(string message)
		{
			if (KaosesPartySizesSettings.Instance is { } instance && instance.BIsDebug)
			{
				Ux.ShowMessage(message, Color.ConvertStringToColor("#E6FF00FF"), false);
				Logging.Lm(message);
			}
		}

		public static void ShowMessageError(string message)
		{
			Ux.ShowMessage(message, Color.ConvertStringToColor("#FF000000"), true);
			Logging.Lm(message);
		}
	}
}
