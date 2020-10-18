using System;
using KaosesPartySizes.Settings;
using TaleWorlds.Core;
using TaleWorlds.Library;

namespace KaosesPartySizes.Utils
{
	// Token: 0x02000004 RID: 4
	public static class Ux
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002434 File Offset: 0x00000634
		public static void ShowMessage(string message, Color messageColor, bool printToLog = false)
		{
			InformationManager.DisplayMessage(new InformationMessage(message, messageColor));
			if (printToLog)
			{
				Logging logger = new Logging("..\\\\..\\\\Modules\\\\KaosesPartySizes\\KaosLog.txt");
				logger.logString(message);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002469 File Offset: 0x00000669
		public static void ShowMessageInfo(string message)
		{
			Ux.ShowMessage(message, Color.ConvertStringToColor("#42FF00FF"), KaosesPartySizesSettings.Instance.bLogToFile);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002488 File Offset: 0x00000688
		public static void ShowMessageDebug(string message)
		{
			bool bIsDebug = KaosesPartySizesSettings.Instance.bIsDebug;
			if (bIsDebug)
			{
				Ux.ShowMessage(message, Color.ConvertStringToColor("#E6FF00FF"), false);
				Logging.lm(message);
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000024BF File Offset: 0x000006BF
		public static void ShowMessageError(string message)
		{
			Ux.ShowMessage(message, Color.ConvertStringToColor("#FF000000"), true);
			Logging.lm(message);
		}
	}
}
