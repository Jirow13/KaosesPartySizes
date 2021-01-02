using System;
using KaosesPartySizes.Objects;
using KaosesPartySizes.Settings;
using KaosesPartySizes.Utils;
using TaleWorlds.CampaignSystem;

namespace KaosesPartySizes.PartyTypes
{
	internal class Caravan : BaseTemplateSizes
	{
		public Caravan(PartyTemplateObject pt)
		{
			this.PartyTemplate = pt;

			if (!(KaosesPartySizesSettings.Instance is { } instance))
			{
				Ux.ShowMessageError("Kaoses Party sizes: Error setting Caravan Sizes!");
				return;
			}

			bool flag = this.PartyTemplate.StringId.Contains("elite") && instance.EliteCaravansMultiplierEnabled;
			if (flag)
			{
				base.ProcessParties(instance.EliteCaravansMinMultiplier, instance.EliteCaravansMaxMultiplier);
			}
			else
			{
				bool CaravansMultiplierEnabled = instance.CaravansMultiplierEnabled;
				if (CaravansMultiplierEnabled)
				{
					base.ProcessParties(instance.CaravansMinMultiplier, instance.CaravansMaxMultiplier);
				}
			}
		}
	}
}
