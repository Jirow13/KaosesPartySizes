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
			bool flag = this._partyTemplate.StringId.Contains("char_") && ModSettings.Instance.charKingdomMultiplierEnabled;
			if (flag)
			{
				base.processParties(ModSettings.Instance.charKingdomMinMultiplier, ModSettings.Instance.charKingdomMaxMultiplier);
			}
			else
			{
				bool flag2 = this._partyTemplate.StringId.Contains("gamescom_player") && ModSettings.Instance.gamescomMultiplierEnabled;
				if (flag2)
				{
					base.processParties(ModSettings.Instance.gamescomMinMultiplier, ModSettings.Instance.gamescomMaxMultiplier);
				}
			}
		}
	}
}
