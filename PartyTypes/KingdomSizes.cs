using System;
using KaosesPartySizes.Objects;
using KaosesPartySizes.Settings;
using TaleWorlds.CampaignSystem;

namespace KaosesPartySizes.PartyTypes
{
	// Token: 0x0200000B RID: 11
	internal class KingdomSizes : BaseTemplateSizes
	{
		// Token: 0x06000121 RID: 289 RVA: 0x0000396C File Offset: 0x00001B6C
		public KingdomSizes(PartyTemplateObject pt)
		{
			this._partyTemplate = pt;
			bool flag = this._partyTemplate.StringId.Contains("empire") && ModSettings.Instance.empireKingdomMultiplierEnabled;
			if (flag)
			{
				base.processParties(ModSettings.Instance.empireKingdomMinMultiplier, ModSettings.Instance.empireKingdomMaxMultiplier);
			}
			else
			{
				bool flag2 = this._partyTemplate.StringId.Contains("aserai") && ModSettings.Instance.aseraiKingdomMultiplierEnabled;
				if (flag2)
				{
					base.processParties(ModSettings.Instance.aseraiKingdomMinMultiplier, ModSettings.Instance.aseraiKingdomMaxMultiplier);
				}
				else
				{
					bool flag3 = this._partyTemplate.StringId.Contains("sturgia") && ModSettings.Instance.sturgiaKingdomMultiplierEnabled;
					if (flag3)
					{
						base.processParties(ModSettings.Instance.sturgiaKingdomMinMultiplier, ModSettings.Instance.sturgiaKingdomMaxMultiplier);
					}
					else
					{
						bool flag4 = this._partyTemplate.StringId.Contains("vlandia") && ModSettings.Instance.vlandiaKingdomMultiplierEnabled;
						if (flag4)
						{
							base.processParties(ModSettings.Instance.vlandiaKingdomMinMultiplier, ModSettings.Instance.vlandiaKingdomMaxMultiplier);
						}
						else
						{
							bool flag5 = this._partyTemplate.StringId.Contains("battania") && ModSettings.Instance.battaniaKingdomMultiplierEnabled;
							if (flag5)
							{
								base.processParties(ModSettings.Instance.battaniaKingdomMinMultiplier, ModSettings.Instance.battaniaKingdomMaxMultiplier);
							}
							else
							{
								bool flag6 = this._partyTemplate.StringId.Contains("khuzait") && ModSettings.Instance.khuzaitKingdomMultiplierEnabled;
								if (flag6)
								{
									base.processParties(ModSettings.Instance.khuzaitKingdomMinMultiplier, ModSettings.Instance.khuzaitKingdomMaxMultiplier);
								}
								else
								{
									bool flag7 = ModSettings.Instance.minorFactionsMultiplierEnabled && !this._partyTemplate.StringId.Contains("cs_");
									if (flag7)
									{
										base.processParties(ModSettings.Instance.minorFactionsMinMultiplier, ModSettings.Instance.minorFactionsMaxMultiplier);
									}
									else
									{
										bool flag8 = this._partyTemplate.StringId.Contains("cs_");
										if (flag8)
										{
											new csSizes(pt);
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
