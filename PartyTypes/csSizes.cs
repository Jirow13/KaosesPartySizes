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
			bool csFactionsMultiplierEnabled = KaosesPartySizesSettings.Instance.csFactionsMultiplierEnabled;
			if (csFactionsMultiplierEnabled == true)
			{
				base.processParties(KaosesPartySizesSettings.Instance.csFactionsMinMultiplier, KaosesPartySizesSettings.Instance.csFactionsMaxMultiplier);
			}
		}
	}
}
