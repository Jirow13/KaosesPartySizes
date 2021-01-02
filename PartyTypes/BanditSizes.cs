using System;
using KaosesPartySizes.Objects;
using KaosesPartySizes.Settings;
using KaosesPartySizes.Utils;
using TaleWorlds.CampaignSystem;

namespace KaosesPartySizes.PartyTypes
{
	public class BanditSizes : BaseTemplateSizes
	{
		public BanditSizes(PartyTemplateObject pt)
		{
			this.PartyTemplate = pt;

			if (!(KaosesPartySizesSettings.Instance is { } instance))
			{
				Ux.ShowMessageError("Kaoses Party sizes: Error setting Bandit Sizes!");
				return;
			}

			if (PartyTemplate.StringId.Contains("Looter"))
			{
				if (instance.LootersMultiplierEnabled)
				{
					base.ProcessParties(instance.LootersMinMultiplier, instance.LootersMaxMultiplier);
				}
			}
			else
			{
				bool flag2 = this.PartyTemplate.StringId.Contains("sea");
				if (flag2)
				{
					bool flag3 = base.IsBossParty() && instance.SeaBossBanditsMultiplierEnabled;
					if (flag3)
					{
						base.ProcessBanditBoss(instance.SeaBossBanditMinMultiplier, instance.SeaBossBanditMaxMultiplier);
					}
					else
					{
						bool flag4 = instance.SeaBanditsMultiplierEnabled && !base.IsBossParty();
						if (flag4)
						{
							base.ProcessParties(instance.SeaBanditMinMultiplier, instance.SeaBanditMaxMultiplier);
						}
					}
				}
				else
				{
					bool flag5 = this.PartyTemplate.StringId.Contains("forest");
					if (flag5)
					{
						bool flag6 = base.IsBossParty() && instance.ForestBossBanditMultiplierEnabled;
						if (flag6)
						{
							base.ProcessBanditBoss(instance.ForestBossBanditMinMultiplier, instance.ForestBossBanditMaxMultiplier);
						}
						else
						{
							bool flag7 = instance.ForestBanditMultiplierEnabled && !base.IsBossParty();
							if (flag7)
							{
								base.ProcessParties(instance.ForestBanditMinMultiplier, instance.ForestBanditMaxMultiplier);
							}
						}
					}
					else
					{
						bool flag8 = this.PartyTemplate.StringId.Contains("mountain");
						if (flag8)
						{
							bool flag9 = base.IsBossParty() && instance.MountainBossBanditsMultiplierEnabled;
							if (flag9)
							{
								base.ProcessBanditBoss(instance.MountainBossBanditMinMultiplier, instance.MountainBossBanditMaxMultiplier);
							}
							else
							{
								bool flag10 = instance.MountainBanditsMultiplierEnabled && !base.IsBossParty();
								if (flag10)
								{
									base.ProcessParties(instance.MountainBanditMinMultiplier, instance.MountainBanditMaxMultiplier);
								}
							}
						}
						else
						{
							bool flag11 = this.PartyTemplate.StringId.Contains("Desert");
							if (flag11)
							{
								bool flag12 = base.IsBossParty() && instance.DesertBossBanditsMultiplierEnabled;
								if (flag12)
								{
									base.ProcessBanditBoss(instance.DesertBossBanditMinMultiplier, instance.DesertBossBanditMaxMultiplier);
								}
								else
								{
									bool flag13 = instance.DesertBanditsMultiplierEnabled && !base.IsBossParty();
									if (flag13)
									{
										base.ProcessParties(instance.DesertBanditMinMultiplier, instance.DesertBanditMaxMultiplier);
									}
								}
							}
							else
							{
								bool flag14 = this.PartyTemplate.StringId.Contains("Steppe");
								if (flag14)
								{
									bool flag15 = base.IsBossParty() && instance.SteppeBossBanditsMultiplierEnabled;
									if (flag15)
									{
										base.ProcessBanditBoss(instance.SteppeBossBanditMinMultiplier, instance.SteppeBossBanditMaxMultiplier);
									}
									else
									{
										bool flag16 = instance.SteppeBanditsMultiplierEnabled && !base.IsBossParty();
										if (flag16)
										{
											base.ProcessParties(instance.SteppeBanditMinMultiplier, instance.SteppeBanditMaxMultiplier);
										}
									}
								}
								else
								{
									bool flag17 = base.IsBossParty() && instance.OtherBanditsBossMultiplierEnabled;
									if (flag17)
									{
										base.ProcessBanditBoss(instance.OtherBanditsBossMinMultiplier, instance.OtherBanditsBossMaxMultiplier);
									}
									else
									{
										bool flag18 = instance.OtherBanditsMultiplierEnabled && !base.IsBossParty();
										if (flag18)
										{
											base.ProcessParties(instance.OtherBanditsMinMultiplier, instance.OtherBanditsMaxMultiplier);
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
