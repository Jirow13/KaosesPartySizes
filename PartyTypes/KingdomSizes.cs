using System;
using KaosesPartySizes.Objects;
using KaosesPartySizes.Settings;
using KaosesPartySizes.Utils;
using TaleWorlds.CampaignSystem;

namespace KaosesPartySizes.PartyTypes
{
	internal class KingdomSizes : BaseTemplateSizes
	{
		public KingdomSizes(PartyTemplateObject pt)
		{
			if (!(KaosesPartySizesSettings.Instance is { } instance))
            {
				Ux.ShowMessageError("Kaoses Party sizes: Error setting 'Kingdom Party' Sizes!");
				return;
			}
				

			this.PartyTemplate = pt;
			bool flag = this.PartyTemplate.StringId.Contains("empire") && instance.EmpireKingdomMultiplierEnabled;
			if (flag)
			{
				base.ProcessParties(instance.EmpireKingdomMinMultiplier, instance.EmpireKingdomMaxMultiplier);
			}
			else
			{
				bool flag2 = this.PartyTemplate.StringId.Contains("aserai") && instance.AseraiKingdomMultiplierEnabled;
				if (flag2)
				{
					base.ProcessParties(instance.AseraiKingdomMinMultiplier, instance.AseraiKingdomMaxMultiplier);
				}
				else
				{
					bool flag3 = this.PartyTemplate.StringId.Contains("sturgia") && instance.SturgiaKingdomMultiplierEnabled;
					if (flag3)
					{
						base.ProcessParties(instance.SturgiaKingdomMinMultiplier, instance.SturgiaKingdomMaxMultiplier);
					}
					else
					{
						bool flag4 = this.PartyTemplate.StringId.Contains("vlandia") && instance.VlandiaKingdomMultiplierEnabled;
						if (flag4)
						{
							base.ProcessParties(instance.VlandiaKingdomMinMultiplier, instance.VlandiaKingdomMaxMultiplier);
						}
						else
						{
							bool flag5 = this.PartyTemplate.StringId.Contains("battania") && instance.BattaniaKingdomMultiplierEnabled;
							if (flag5)
							{
								base.ProcessParties(instance.BattaniaKingdomMinMultiplier, instance.BattaniaKingdomMaxMultiplier);
							}
							else
							{
								bool flag6 = this.PartyTemplate.StringId.Contains("khuzait") && instance.KhuzaitKingdomMultiplierEnabled;
								if (flag6)
								{
									base.ProcessParties(instance.KhuzaitKingdomMinMultiplier, instance.KhuzaitKingdomMaxMultiplier);
								}
								else
								{
									bool flag7 = instance.MinorFactionsMultiplierEnabled && !this.PartyTemplate.StringId.Contains("cs_");
									if (flag7)
									{
										base.ProcessParties(instance.MinorFactionsMinMultiplier, instance.MinorFactionsMaxMultiplier);
									}
									else
									{
										bool flag8 = this.PartyTemplate.StringId.Contains("cs_");
										if (flag8)
										{
											new CSSizes(pt);
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
