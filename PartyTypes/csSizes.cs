using System;
using KaosesPartySizes.Objects;
using KaosesPartySizes.Settings;
using TaleWorlds.CampaignSystem;

namespace KaosesPartySizes.PartyTypes
{
	internal class csSizes : BaseTemplateSizes
	{
		public csSizes(PartyTemplateObject pt)
		{
			this._partyTemplate = pt;
			bool csFactionsMultiplierEnabled = ModSettings.Instance.csFactionsMultiplierEnabled;
			if (csFactionsMultiplierEnabled)
			{
				base.processParties(ModSettings.Instance.csFactionsMinMultiplier, ModSettings.Instance.csFactionsMaxMultiplier);
			}
		}
	}
}
