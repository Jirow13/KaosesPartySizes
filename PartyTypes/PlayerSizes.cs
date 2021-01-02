using System;
using KaosesPartySizes.Objects;
using KaosesPartySizes.Settings;
using KaosesPartySizes.Utils;
using TaleWorlds.CampaignSystem;

namespace KaosesPartySizes.PartyTypes
{
	internal class PlayerSizes : BaseTemplateSizes
	{	
		public PlayerSizes(PartyTemplateObject pt)
		{
			if (!(KaosesPartySizesSettings.Instance is { } instance))
			{
				Ux.ShowMessageError("Kaoses Party sizes: Error setting 'Player Party' Sizes!");
				return;
			}

			this.PartyTemplate = pt;
			bool flag = this.PartyTemplate.StringId.Contains("char_") && instance.CharKingdomMultiplierEnabled;
			if (flag)
			{
				base.ProcessParties(instance.CharKingdomMinMultiplier, instance.CharKingdomMaxMultiplier);
			}
			else
			{
				bool flag2 = this.PartyTemplate.StringId.Contains("gamescom_player") && instance.GamescomMultiplierEnabled;
				if (flag2)
				{
					base.ProcessParties(instance.GamescomMinMultiplier, instance.GamescomMaxMultiplier);
				}
			}
		}
	}
}
