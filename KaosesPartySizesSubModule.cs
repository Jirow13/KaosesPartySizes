using System;
using KaosesPartySizes.Behaviours;
using KaosesPartySizes.Models;
using KaosesPartySizes.Objects;
using KaosesPartySizes.Settings;
using KaosesPartySizes.Utils;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;
using TaleWorlds.ObjectSystem;

namespace KaosesPartySizes
{
	// Token: 0x02000002 RID: 2
	public class KaosesPartySizesSubModule : MBSubModuleBase
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00000248
		protected override void OnBeforeInitialModuleScreenSetAsRoot()
		{
			Ux.ShowMessageInfo("Kaoses Party Sizes 0.1.11 is now enabled.");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		protected override void OnSubModuleLoad()
		{
			base.OnSubModuleLoad();
			try
			{
				Loader.LoadConfig();
			}
			catch (Exception e)
			{
				Ux.ShowMessageError("Kaoses Parties Exception  : " + e.ToString());
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020A4 File Offset: 0x000002A4
		protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
		{
			base.OnGameStart(game, gameStarterObject);
			bool flag = !(game.GameType is Campaign);
			if (!flag)
			{
				try
				{
					CampaignGameStarter initializer = (CampaignGameStarter)gameStarterObject;
					bool flag2 = initializer != null;
					if (flag2)
					{
						bool kaosesSpeedModifiersEnabled = ModSettings.Instance.kaosesSpeedModifiersEnabled;
						if (kaosesSpeedModifiersEnabled)
						{
							initializer.AddModel(new KaosPartySpeed());
						}
						bool bLogPartySpawns = ModSettings.Instance.bLogPartySpawns;
						if (bLogPartySpawns)
						{
							initializer.AddBehavior(new KaosesPartiesBehaviour());
						}
						initializer.AddModel(new KaosesBanditDensityModel());
					}
				}
				catch (Exception e)
				{
					Ux.ShowMessageError("Kaoses Parties Exception  : " + e.ToString());
				}
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000215C File Offset: 0x0000035C
		public override void OnGameInitializationFinished(Game game)
		{
			base.OnGameInitializationFinished(game);
			bool flag = !(game.GameType is Campaign);
			if (!flag)
			{
				Campaign campaign = game.GameType as Campaign;
				bool flag2 = campaign != null;
				if (flag2)
				{
					bool flag3 = MBObjectManager.Instance.GetObjectTypeList<PartyTemplateObject>() != null;
					if (flag3)
					{
						MBReadOnlyList<PartyTemplateObject> partyTemplateList = MBObjectManager.Instance.GetObjectTypeList<PartyTemplateObject>();
						for (int index = 0; index < partyTemplateList.Count; index++)
						{
							PartyTemplateObject pt = partyTemplateList[index];
							new PartyTemplateSizes(pt);
						}
					}
					bool bPrintTroopLimits = ModSettings.Instance.bPrintTroopLimits;
					if (bPrintTroopLimits)
					{
						bool flag4 = MBObjectManager.Instance.GetObjectTypeList<PartyTemplateObject>() != null;
						if (flag4)
						{
							MBReadOnlyList<PartyTemplateObject> partyTemplateList2 = MBObjectManager.Instance.GetObjectTypeList<PartyTemplateObject>();
							Logging.lm("-------------------------------------------");
							Logging.lm("Printing Party Template Troop Limits ");
							for (int index2 = 0; index2 < partyTemplateList2.Count; index2++)
							{
								Logging.lm("");
								PartyTemplateObject pt2 = partyTemplateList2[index2];
								Logging.lm("Party String Id: " + pt2.StringId.ToString());
								foreach (PartyTemplateStack ps in pt2.Stacks)
								{
									string[] array = new string[6];
									array[0] = "Character: ";
									array[1] = ps.Character.StringId.ToString();
									array[2] = " Min: ";
									int num = 3;
									int num2 = ps.MinValue;
									array[num] = num2.ToString();
									array[4] = " Max: ";
									int num3 = 5;
									num2 = ps.MaxValue;
									array[num3] = num2.ToString();
									Logging.lm(string.Concat(array));
								}
								Logging.lm("");
							}
						}
					}
				}
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002350 File Offset: 0x00000550
		public override void OnGameLoaded(Game game, object initializerObject)
		{
			CampaignGameStarter gameInitializer = (CampaignGameStarter)initializerObject;
			bool flag = !(game.GameType is Campaign);
			if (!flag)
			{
				Campaign campaign = game.GameType as Campaign;
				bool flag2 = campaign != null;
				if (flag2)
				{
				}
			}
		}

		// Token: 0x04000001 RID: 1
		public const string InstanceID = "Kaoses Party Sizes";

		// Token: 0x04000002 RID: 2
		public const string ModuleFolder = "KaosesPartySizes";

		// Token: 0x04000003 RID: 3
		public const string Version = "0.1.11";

		// Token: 0x04000004 RID: 4
		public const string logPath = "..\\\\..\\\\Modules\\\\KaosesPartySizes\\KaosLog.txt";

		// Token: 0x04000005 RID: 5
		public const string ConfigFilePath = "..\\\\..\\\\Modules\\\\KaosesPartySizes\\config.json";

		// Token: 0x04000006 RID: 6
		public const string ConfigFileBasePath = "..\\\\..\\\\Modules\\\\KaosesPartySizes\\Config.base.json";
	}
}
