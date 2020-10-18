using System;
using KaosesPartySizes.Objects;
using KaosesPartySizes.Settings;
using TaleWorlds.CampaignSystem;

namespace KaosesPartySizes.PartyTypes
{
	public class BanditSizes : BaseTemplateSizes
	{
		public BanditSizes(PartyTemplateObject pt)
		{
			this._partyTemplate = pt;
			bool flag = this._partyTemplate.StringId.Contains("looter");
			if (flag)
			{
				bool lootersMultiplierEnabled = KaosesPartySizesSettings.Instance.lootersMultiplierEnabled;
				if (lootersMultiplierEnabled)
				{
					base.processParties(KaosesPartySizesSettings.Instance.lootersMinMultiplier, KaosesPartySizesSettings.Instance.lootersMaxMultiplier);
				}
			}
			else
			{
				bool flag2 = this._partyTemplate.StringId.Contains("sea");
				if (flag2)
				{
					bool flag3 = base.isBossParty() && KaosesPartySizesSettings.Instance.seaBossBanditsMultiplierEnabled;
					if (flag3)
					{
						base.processBanditBoss(KaosesPartySizesSettings.Instance.seaBossBanditMinMultiplier, KaosesPartySizesSettings.Instance.seaBossBanditMaxMultiplier);
					}
					else
					{
						bool flag4 = KaosesPartySizesSettings.Instance.seaBanditsMultiplierEnabled && !base.isBossParty();
						if (flag4)
						{
							base.processParties(KaosesPartySizesSettings.Instance.seaBanditMinMultiplier, KaosesPartySizesSettings.Instance.seaBanditMaxMultiplier);
						}
					}
				}
				else
				{
					bool flag5 = this._partyTemplate.StringId.Contains("forest");
					if (flag5)
					{
						bool flag6 = base.isBossParty() && KaosesPartySizesSettings.Instance.forestBossBanditMultiplierEnabled;
						if (flag6)
						{
							base.processBanditBoss(KaosesPartySizesSettings.Instance.forestBossBanditMinMultiplier, KaosesPartySizesSettings.Instance.forestBossBanditMaxMultiplier);
						}
						else
						{
							bool flag7 = KaosesPartySizesSettings.Instance.forestBanditMultiplierEnabled && !base.isBossParty();
							if (flag7)
							{
								base.processParties(KaosesPartySizesSettings.Instance.forestBanditMinMultiplier, KaosesPartySizesSettings.Instance.forestBanditMaxMultiplier);
							}
						}
					}
					else
					{
						bool flag8 = this._partyTemplate.StringId.Contains("mountain");
						if (flag8)
						{
							bool flag9 = base.isBossParty() && KaosesPartySizesSettings.Instance.mountainBossBanditsMultiplierEnabled;
							if (flag9)
							{
								base.processBanditBoss(KaosesPartySizesSettings.Instance.mountainBossBanditMinMultiplier, KaosesPartySizesSettings.Instance.mountainBossBanditMaxMultiplier);
							}
							else
							{
								bool flag10 = KaosesPartySizesSettings.Instance.mountainBanditsMultiplierEnabled && !base.isBossParty();
								if (flag10)
								{
									base.processParties(KaosesPartySizesSettings.Instance.mountainBanditMinMultiplier, KaosesPartySizesSettings.Instance.mountainBanditMaxMultiplier);
								}
							}
						}
						else
						{
							bool flag11 = this._partyTemplate.StringId.Contains("desert");
							if (flag11)
							{
								bool flag12 = base.isBossParty() && KaosesPartySizesSettings.Instance.desertBossBanditsMultiplierEnabled;
								if (flag12)
								{
									base.processBanditBoss(KaosesPartySizesSettings.Instance.desertBossBanditMinMultiplier, KaosesPartySizesSettings.Instance.desertBossBanditMaxMultiplier);
								}
								else
								{
									bool flag13 = KaosesPartySizesSettings.Instance.desertBanditsMultiplierEnabled && !base.isBossParty();
									if (flag13)
									{
										base.processParties(KaosesPartySizesSettings.Instance.desertBanditMinMultiplier, KaosesPartySizesSettings.Instance.desertBanditMaxMultiplier);
									}
								}
							}
							else
							{
								bool flag14 = this._partyTemplate.StringId.Contains("steppe");
								if (flag14)
								{
									bool flag15 = base.isBossParty() && KaosesPartySizesSettings.Instance.steppeBossBanditsMultiplierEnabled;
									if (flag15)
									{
										base.processBanditBoss(KaosesPartySizesSettings.Instance.steppeBossBanditMinMultiplier, KaosesPartySizesSettings.Instance.steppeBossBanditMaxMultiplier);
									}
									else
									{
										bool flag16 = KaosesPartySizesSettings.Instance.steppeBanditsMultiplierEnabled && !base.isBossParty();
										if (flag16)
										{
											base.processParties(KaosesPartySizesSettings.Instance.steppeBanditMinMultiplier, KaosesPartySizesSettings.Instance.steppeBanditMaxMultiplier);
										}
									}
								}
								else
								{
									bool flag17 = base.isBossParty() && KaosesPartySizesSettings.Instance.otherBanditsBossMultiplierEnabled;
									if (flag17)
									{
										base.processBanditBoss(KaosesPartySizesSettings.Instance.otherBanditsBossMinMultiplier, KaosesPartySizesSettings.Instance.otherBanditsBossMaxMultiplier);
									}
									else
									{
										bool flag18 = KaosesPartySizesSettings.Instance.otherBanditsMultiplierEnabled && !base.isBossParty();
										if (flag18)
										{
											base.processParties(KaosesPartySizesSettings.Instance.otherBanditsMinMultiplier, KaosesPartySizesSettings.Instance.otherBanditsMaxMultiplier);
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
