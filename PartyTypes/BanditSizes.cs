using System;
using KaosesPartySizes.Objects;
using KaosesPartySizes.Settings;
using TaleWorlds.CampaignSystem;

namespace KaosesPartySizes.PartyTypes
{
	// Token: 0x02000007 RID: 7
	public class BanditSizes : BaseTemplateSizes
	{
		// Token: 0x0600011D RID: 285 RVA: 0x00003420 File Offset: 0x00001620
		public BanditSizes(PartyTemplateObject pt)
		{
			this._partyTemplate = pt;
			bool flag = this._partyTemplate.StringId.Contains("looter");
			if (flag)
			{
				bool lootersMultiplierEnabled = ModSettings.Instance.lootersMultiplierEnabled;
				if (lootersMultiplierEnabled)
				{
					base.processParties(ModSettings.Instance.lootersMinMultiplier, ModSettings.Instance.lootersMaxMultiplier);
				}
			}
			else
			{
				bool flag2 = this._partyTemplate.StringId.Contains("sea");
				if (flag2)
				{
					bool flag3 = base.isBossParty() && ModSettings.Instance.seaBossBanditsMultiplierEnabled;
					if (flag3)
					{
						base.processBanditBoss(ModSettings.Instance.seaBossBanditMinMultiplier, ModSettings.Instance.seaBossBanditMaxMultiplier);
					}
					else
					{
						bool flag4 = ModSettings.Instance.seaBanditsMultiplierEnabled && !base.isBossParty();
						if (flag4)
						{
							base.processParties(ModSettings.Instance.seaBanditMinMultiplier, ModSettings.Instance.seaBanditMaxMultiplier);
						}
					}
				}
				else
				{
					bool flag5 = this._partyTemplate.StringId.Contains("forest");
					if (flag5)
					{
						bool flag6 = base.isBossParty() && ModSettings.Instance.forestBossBanditMultiplierEnabled;
						if (flag6)
						{
							base.processBanditBoss(ModSettings.Instance.forestBossBanditMinMultiplier, ModSettings.Instance.forestBossBanditMaxMultiplier);
						}
						else
						{
							bool flag7 = ModSettings.Instance.forestBanditMultiplierEnabled && !base.isBossParty();
							if (flag7)
							{
								base.processParties(ModSettings.Instance.forestBanditMinMultiplier, ModSettings.Instance.forestBanditMaxMultiplier);
							}
						}
					}
					else
					{
						bool flag8 = this._partyTemplate.StringId.Contains("mountain");
						if (flag8)
						{
							bool flag9 = base.isBossParty() && ModSettings.Instance.mountainBossBanditsMultiplierEnabled;
							if (flag9)
							{
								base.processBanditBoss(ModSettings.Instance.mountainBossBanditMinMultiplier, ModSettings.Instance.mountainBossBanditMaxMultiplier);
							}
							else
							{
								bool flag10 = ModSettings.Instance.mountainBanditsMultiplierEnabled && !base.isBossParty();
								if (flag10)
								{
									base.processParties(ModSettings.Instance.mountainBanditMinMultiplier, ModSettings.Instance.mountainBanditMaxMultiplier);
								}
							}
						}
						else
						{
							bool flag11 = this._partyTemplate.StringId.Contains("desert");
							if (flag11)
							{
								bool flag12 = base.isBossParty() && ModSettings.Instance.desertBossBanditsMultiplierEnabled;
								if (flag12)
								{
									base.processBanditBoss(ModSettings.Instance.desertBossBanditMinMultiplier, ModSettings.Instance.desertBossBanditMaxMultiplier);
								}
								else
								{
									bool flag13 = ModSettings.Instance.desertBanditsMultiplierEnabled && !base.isBossParty();
									if (flag13)
									{
										base.processParties(ModSettings.Instance.desertBanditMinMultiplier, ModSettings.Instance.desertBanditMaxMultiplier);
									}
								}
							}
							else
							{
								bool flag14 = this._partyTemplate.StringId.Contains("steppe");
								if (flag14)
								{
									bool flag15 = base.isBossParty() && ModSettings.Instance.steppeBossBanditsMultiplierEnabled;
									if (flag15)
									{
										base.processBanditBoss(ModSettings.Instance.steppeBossBanditMinMultiplier, ModSettings.Instance.steppeBossBanditMaxMultiplier);
									}
									else
									{
										bool flag16 = ModSettings.Instance.steppeBanditsMultiplierEnabled && !base.isBossParty();
										if (flag16)
										{
											base.processParties(ModSettings.Instance.steppeBanditMinMultiplier, ModSettings.Instance.steppeBanditMaxMultiplier);
										}
									}
								}
								else
								{
									bool flag17 = base.isBossParty() && ModSettings.Instance.otherBanditsBossMultiplierEnabled;
									if (flag17)
									{
										base.processBanditBoss(ModSettings.Instance.otherBanditsBossMinMultiplier, ModSettings.Instance.otherBanditsBossMaxMultiplier);
									}
									else
									{
										bool flag18 = ModSettings.Instance.otherBanditsMultiplierEnabled && !base.isBossParty();
										if (flag18)
										{
											base.processParties(ModSettings.Instance.otherBanditsMinMultiplier, ModSettings.Instance.otherBanditsMaxMultiplier);
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}
}
