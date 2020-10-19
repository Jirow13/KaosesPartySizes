using System;
using KaosesPartySizes.Objects;
using KaosesPartySizes.Settings;
using TaleWorlds.CampaignSystem;

namespace KaosesPartySizes.PartyTypes
{
	internal class Caravan : BaseTemplateSizes
	{
		public Caravan(PartyTemplateObject pt)
		{
			this._partyTemplate = pt;
			bool flag = this._partyTemplate.StringId.Contains("elite") && KaosesPartySizesSettings.Instance.eliteCaravansMultiplierEnabled;
			if (flag)
			{
				base.processParties(KaosesPartySizesSettings.Instance.eliteCaravansMinMultiplier, KaosesPartySizesSettings.Instance.eliteCaravansMaxMultiplier);
			}
			else
			{
				bool caravansMultiplierEnabled = KaosesPartySizesSettings.Instance.caravansMultiplierEnabled;
				if (caravansMultiplierEnabled)
				{
					base.processParties(KaosesPartySizesSettings.Instance.caravansMinMultiplier, KaosesPartySizesSettings.Instance.caravansMaxMultiplier);
				}
			}
		}
	}
}
