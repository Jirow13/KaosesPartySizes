using System;
using KaosesPartySizes.Objects;
using KaosesPartySizes.Settings;
using TaleWorlds.CampaignSystem;

namespace KaosesPartySizes.PartyTypes
{
	// Token: 0x02000008 RID: 8
	internal class Caravan : BaseTemplateSizes
	{
		// Token: 0x0600011E RID: 286 RVA: 0x000037EC File Offset: 0x000019EC
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
