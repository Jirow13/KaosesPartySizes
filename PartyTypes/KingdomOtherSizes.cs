using System;
using KaosesPartySizes.Objects;
using KaosesPartySizes.Settings;
using TaleWorlds.CampaignSystem;

namespace KaosesPartySizes.PartyTypes
{
	internal class KingdomOtherSizes : BaseTemplateSizes
	{
		public KingdomOtherSizes(PartyTemplateObject pt)
		{
			this._partyTemplate = pt;
			bool flag = this._partyTemplate.StringId.Contains("kingdom_hero_ai") && KaosesPartySizesSettings.Instance.otherKingdomMultiplierEnabled;
			if (flag)
			{
				base.processParties(KaosesPartySizesSettings.Instance.otherKingdomMinMultiplier, KaosesPartySizesSettings.Instance.otherKingdomMaxMultiplier);
			}
			else
			{
				bool flag2 = this._partyTemplate.StringId.Contains("kingdom_hero_minor") && KaosesPartySizesSettings.Instance.otherMinorFactionsMultiplierEnabled;
				if (flag2)
				{
					base.processParties(KaosesPartySizesSettings.Instance.otherMinorFactionsMinMultiplier, KaosesPartySizesSettings.Instance.otherMinorFactionsMaxMultiplier);
				}
			}
		}
	}
}
