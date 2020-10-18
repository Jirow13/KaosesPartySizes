using System;
using KaosesPartySizes.Objects;
using KaosesPartySizes.Settings;
using TaleWorlds.CampaignSystem;

namespace KaosesPartySizes.PartyTypes
{
	internal class PlayerSizes : BaseTemplateSizes
	{	
		public PlayerSizes(PartyTemplateObject pt)
		{
			this._partyTemplate = pt;
			bool flag = this._partyTemplate.StringId.Contains("char_") && KaosesPartySizesSettings.Instance.charKingdomMultiplierEnabled;
			if (flag)
			{
				base.processParties(KaosesPartySizesSettings.Instance.charKingdomMinMultiplier, KaosesPartySizesSettings.Instance.charKingdomMaxMultiplier);
			}
			else
			{
				bool flag2 = this._partyTemplate.StringId.Contains("gamescom_player") && KaosesPartySizesSettings.Instance.gamescomMultiplierEnabled;
				if (flag2)
				{
					base.processParties(KaosesPartySizesSettings.Instance.gamescomMinMultiplier, KaosesPartySizesSettings.Instance.gamescomMaxMultiplier);
				}
			}
		}
	}
}
