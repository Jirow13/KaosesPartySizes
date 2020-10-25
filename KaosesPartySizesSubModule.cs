using HarmonyLib;
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
		public class KaosesPartySizesSubModule : MBSubModuleBase
		{
			private static Harmony harmony = null;
			protected override void OnBeforeInitialModuleScreenSetAsRoot()
			{
				Ux.ShowMessageInfo("Kaoses Party Sizes is now enabled.");
				if (harmony == null)
				{
					try
					{
						harmony = new Harmony("mod.partysizes.kaoses");
						harmony.PatchAll();
						Ux.ShowMessageDebug($"Harmony Loaded: Kaoses Party Sizes");
					}
					catch (Exception ex)
					{
						Ux.ShowMessageError($"Error Initialising Kaoses Party Sizes:\n\n{ex.ToString()}");
					}
				}
			}

			protected override void OnSubModuleLoad()
			{
				base.OnSubModuleLoad();
				/*
				try
				{
					Loader.LoadConfig();
				}
				catch (Exception e)
				{
					Ux.ShowMessageError("Kaoses Parties Exception  : " + e.ToString());
				}
				*/
			}

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
							bool kaosesSpeedModifiersEnabled = KaosesPartySizesSettings.Instance.kaosesSpeedModifiersEnabled;
							if (kaosesSpeedModifiersEnabled)
							{
								initializer.AddModel(new KaosPartySpeed());
							}
							bool bLogPartySpawns = KaosesPartySizesSettings.Instance.bLogPartySpawns;
							if (bLogPartySpawns)
							{
								initializer.AddBehavior(new KaosesPartiesBehaviour());
							}
							// Jiros: Switched to Harmony patch instead of replacing the model as it was causing problems in hideouts, etc.
							// initializer.AddModel(new KaosesBanditDensityModel());
						}
					}
					catch (Exception e)
					{
						Ux.ShowMessageError("Kaoses Parties Exception  : " + e.ToString());
					}
				}
			}

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
						bool bPrintTroopLimits = KaosesPartySizesSettings.Instance.bPrintTroopLimits;
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
									if (pt2.Stacks != null)
									{
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
									else
									{
										Logging.lm("No Stacks for " + pt2.StringId);
									}
								}
							}
						}
					}
				}
			}

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

			public const string InstanceID = "Kaoses Party Sizes";

			public const string ModuleFolder = "KaosesPartySizes";

			public const string Version = "0.1.11";

			public const string logPath = "..\\\\..\\\\Modules\\\\KaosesPartySizes\\KaosLog.txt";

//			public const string ConfigFilePath = "..\\\\..\\\\Modules\\\\KaosesPartySizes\\config.json";

//			public const string ConfigFileBasePath = "..\\\\..\\\\Modules\\\\KaosesPartySizes\\Config.base.json";
	}
}
