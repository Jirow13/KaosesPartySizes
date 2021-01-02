using System;
using KaosesPartySizes.Objects;
using KaosesPartySizes.Settings;
using KaosesPartySizes.Utils;
using TaleWorlds.CampaignSystem;

namespace KaosesPartySizes.PartyTypes
{
	internal class KingdomOtherSizes : BaseTemplateSizes
	{
		public KingdomOtherSizes(PartyTemplateObject pt)
		{
			PartyTemplate = pt;

			if (!(KaosesPartySizesSettings.Instance is { } instance)) 
			{ 
				Ux.ShowMessageError("Kaoses Party sizes: Error setting 'Kingdom-Other' Sizes!");
				return;
			}

			bool flag = PartyTemplate.StringId.Contains("kingdom_hero_ai") && instance.OtherKingdomMultiplierEnabled;
			if (flag)
			{
				ProcessParties(instance.OtherKingdomMinMultiplier, instance.OtherKingdomMaxMultiplier);
			}
			else
			{
				bool flag2 = PartyTemplate.StringId.Contains("kingdom_hero_minor") && instance.OtherMinorFactionsMultiplierEnabled;
				if (flag2)
				{
					ProcessParties(instance.OtherMinorFactionsMinMultiplier, instance.OtherMinorFactionsMaxMultiplier);
				}
			}
		}
	}
}
