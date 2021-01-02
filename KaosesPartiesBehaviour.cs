using System;
using System.Collections.Generic;
using System.Linq;
using KaosesPartySizes.Settings;
using KaosesPartySizes.Utils;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Library;
using TaleWorlds.ObjectSystem;

namespace KaosesPartySizes.Behaviours
{
	internal class KaosesPartiesBehaviour : CampaignBehaviorBase
	{
		public override void RegisterEvents()
		{
			try
			{
				CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, new Action(this.OnDailyTick));
			}
			catch (Exception e)
			{
				Ux.ShowMessageError("Kaoses Parties Exception in Register Events : " + e.ToString());
			}
		}

		public override void SyncData(IDataStore dataStore)
		{
		}

		private void OnDailyTick()
		{
			try
			{
				if (MBObjectManager.Instance.GetObjectTypeList<Clan>() != null)
				{
					if (KaosesPartySizesSettings.Instance is { } instance && instance.BLogPartySpawns)
					{
						Logging.Lm("-------------------------------------------");
						Logging.Lm(" Logging Party Spawns to File");
						Logging.Lm("ToDays : " + CampaignTime.Now.ToDays.ToString());
						Logging.Lm("Now : " + CampaignTime.Now.ToString());
						Logging.Lm("NumberOfMaximumLooterParties :  " + Campaign.Current.Models.BanditDensityModel.NumberOfMaximumLooterParties.ToString());
						Logging.Lm("NumberOfMinimumBanditPartiesInAHideoutToInfestIt :  " + Campaign.Current.Models.BanditDensityModel.NumberOfMinimumBanditPartiesInAHideoutToInfestIt.ToString());
						Logging.Lm("NumberOfMaximumBanditPartiesInEachHideout :  " + Campaign.Current.Models.BanditDensityModel.NumberOfMaximumBanditPartiesInEachHideout.ToString());
						Logging.Lm("NumberOfMaximumBanditPartiesAroundEachHideout :  " + Campaign.Current.Models.BanditDensityModel.NumberOfMaximumBanditPartiesAroundEachHideout.ToString());
						Logging.Lm("NumberOfMaximumHideoutsAtEachBanditFaction :  " + Campaign.Current.Models.BanditDensityModel.NumberOfMaximumHideoutsAtEachBanditFaction.ToString());
						Logging.Lm("NumberOfInitialHideoutsAtEachBanditFaction :  " + Campaign.Current.Models.BanditDensityModel.NumberOfInitialHideoutsAtEachBanditFaction.ToString());
						MBReadOnlyList<Clan> clanList = MBObjectManager.Instance.GetObjectTypeList<Clan>();
						foreach (Clan clan in clanList)
						{
							if (clan.Culture != null)
							{
								Logging.Lm("------");
								if (this.clanPartyCount.ContainsKey(clan.StringId))
								{
									int oldNumber = this.clanPartyCount[clan.StringId];
									Logging.Lm(string.Concat(new string[]
									{
										"Clan Name: ",
										clan.Name.ToString(),
										"  StringId: ",
										clan.StringId.ToString(),
										"Culture Name: ",
										clan.Culture.Name.ToString(),
										"    Parties Count: ",
//										clan.Parties.Count<MobileParty>().ToString(),
										clan.AllParties.Count<MobileParty>().ToString(),
									    "  Last Count: ",
										oldNumber.ToString()
									}));
									this.clanPartyCount[clan.StringId] = clan.AllParties.Count<MobileParty>();
								}
								else
								{
									Logging.Lm(string.Concat(new string[]
									{
										"Clan Name: ",
										clan.Name.ToString(),
										"  StringId: ",
										clan.StringId.ToString(),
										"Culture Name: ",
										clan.Culture.Name.ToString(),
										"    Parties Count: ",
										clan.AllParties.Count<MobileParty>().ToString()
									}));
									this.clanPartyCount.Add(clan.StringId, clan.AllParties.Count<MobileParty>());
								}
								Logging.Lm("");
							}
						}
					}
				}
			}
			catch (Exception e)
			{
				Ux.ShowMessageError("Kaoses Parties Exception in OnDailyTick Events : " + e.ToString());
			}
		}

		public Dictionary<string, int> clanPartyCount = new Dictionary<string, int>();
	}
}
