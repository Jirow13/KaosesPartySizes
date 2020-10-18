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
			bool flag = this._partyTemplate.StringId.Contains("empire") && KaosesPartySizesSettings.Instance.empireKingdomMultiplierEnabled;
			if (flag)
			{
				base.processParties(KaosesPartySizesSettings.Instance.empireKingdomMinMultiplier, KaosesPartySizesSettings.Instance.empireKingdomMaxMultiplier);
			}
			else
			{
				bool flag2 = this._partyTemplate.StringId.Contains("aserai") && KaosesPartySizesSettings.Instance.aseraiKingdomMultiplierEnabled;
				if (flag2)
				{
					base.processParties(KaosesPartySizesSettings.Instance.aseraiKingdomMinMultiplier, KaosesPartySizesSettings.Instance.aseraiKingdomMaxMultiplier);
				}
				else
				{
					bool flag3 = this._partyTemplate.StringId.Contains("sturgia") && KaosesPartySizesSettings.Instance.sturgiaKingdomMultiplierEnabled;
					if (flag3)
					{
						base.processParties(KaosesPartySizesSettings.Instance.sturgiaKingdomMinMultiplier, KaosesPartySizesSettings.Instance.sturgiaKingdomMaxMultiplier);
					}
					else
					{
						bool flag4 = this._partyTemplate.StringId.Contains("vlandia") && KaosesPartySizesSettings.Instance.vlandiaKingdomMultiplierEnabled;
						if (flag4)
						{
							base.processParties(KaosesPartySizesSettings.Instance.vlandiaKingdomMinMultiplier, KaosesPartySizesSettings.Instance.vlandiaKingdomMaxMultiplier);
						}
						else
						{
							bool flag5 = this._partyTemplate.StringId.Contains("battania") && KaosesPartySizesSettings.Instance.battaniaKingdomMultiplierEnabled;
							if (flag5)
							{
								base.processParties(KaosesPartySizesSettings.Instance.battaniaKingdomMinMultiplier, KaosesPartySizesSettings.Instance.battaniaKingdomMaxMultiplier);
							}
							else
							{
								bool flag6 = this._partyTemplate.StringId.Contains("khuzait") && KaosesPartySizesSettings.Instance.khuzaitKingdomMultiplierEnabled;
								if (flag6)
								{
									base.processParties(KaosesPartySizesSettings.Instance.khuzaitKingdomMinMultiplier, KaosesPartySizesSettings.Instance.khuzaitKingdomMaxMultiplier);
								}
								else
								{
									bool flag7 = KaosesPartySizesSettings.Instance.minorFactionsMultiplierEnabled && !this._partyTemplate.StringId.Contains("cs_");
									if (flag7)
									{
										base.processParties(KaosesPartySizesSettings.Instance.minorFactionsMinMultiplier, KaosesPartySizesSettings.Instance.minorFactionsMaxMultiplier);
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
