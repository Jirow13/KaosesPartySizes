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
	// Token: 0x02000012 RID: 18
	internal class KaosesPartiesBehaviour : CampaignBehaviorBase
	{
		// Token: 0x0600013B RID: 315 RVA: 0x00004808 File Offset: 0x00002A08
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

		// Token: 0x0600013C RID: 316 RVA: 0x00003CAA File Offset: 0x00001EAA
		public override void SyncData(IDataStore dataStore)
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00004860 File Offset: 0x00002A60
		private void OnDailyTick()
		{
			try
			{
				bool flag = MBObjectManager.Instance.GetObjectTypeList<Clan>() != null;
				if (flag)
				{
					bool bLogPartySpawns = KaosesPartySizesSettings.Instance.bLogPartySpawns;
					if (bLogPartySpawns)
					{
						Logging.lm("-------------------------------------------");
						Logging.lm(" Logging Party Spawns to File");
						Logging.lm("ToDays : " + CampaignTime.Now.ToDays.ToString());
						Logging.lm("Now : " + CampaignTime.Now.ToString());
						Logging.lm("NumberOfMaximumLooterParties :  " + Campaign.Current.Models.BanditDensityModel.NumberOfMaximumLooterParties.ToString());
						Logging.lm("NumberOfMinimumBanditPartiesInAHideoutToInfestIt :  " + Campaign.Current.Models.BanditDensityModel.NumberOfMinimumBanditPartiesInAHideoutToInfestIt.ToString());
						Logging.lm("NumberOfMaximumBanditPartiesInEachHideout :  " + Campaign.Current.Models.BanditDensityModel.NumberOfMaximumBanditPartiesInEachHideout.ToString());
						Logging.lm("NumberOfMaximumBanditPartiesAroundEachHideout :  " + Campaign.Current.Models.BanditDensityModel.NumberOfMaximumBanditPartiesAroundEachHideout.ToString());
						Logging.lm("NumberOfMaximumHideoutsAtEachBanditFaction :  " + Campaign.Current.Models.BanditDensityModel.NumberOfMaximumHideoutsAtEachBanditFaction.ToString());
						Logging.lm("NumberOfInitialHideoutsAtEachBanditFaction :  " + Campaign.Current.Models.BanditDensityModel.NumberOfInitialHideoutsAtEachBanditFaction.ToString());
						MBReadOnlyList<Clan> clanList = MBObjectManager.Instance.GetObjectTypeList<Clan>();
						foreach (Clan clan in clanList)
						{
							bool flag2 = clan.Culture != null;
							if (flag2)
							{
								Logging.lm("------");
								bool flag3 = this.clanPartyCount.ContainsKey(clan.StringId);
								if (flag3)
								{
									int oldNumber = this.clanPartyCount[clan.StringId];
									Logging.lm(string.Concat(new string[]
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
									Logging.lm(string.Concat(new string[]
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
								Logging.lm("");
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

		// Token: 0x0400009C RID: 156
		public Dictionary<string, int> clanPartyCount = new Dictionary<string, int>();
	}
}
