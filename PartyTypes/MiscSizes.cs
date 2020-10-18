using System;
using KaosesPartySizes.Objects;
using KaosesPartySizes.Settings;
using TaleWorlds.CampaignSystem;

namespace KaosesPartySizes.PartyTypes
{
	// Token: 0x0200000C RID: 12
	internal class MiscSizes : BaseTemplateSizes
	{
		// Token: 0x06000122 RID: 290 RVA: 0x00003BB8 File Offset: 0x00001DB8
		public MiscSizes(PartyTemplateObject pt)
		{
			this._partyTemplate = pt;
			bool flag = this._partyTemplate.StringId.Contains("mercenary") && KaosesPartySizesSettings.Instance.mercenaryFactionsMultiplierEnabled;
			if (flag)
			{
				base.processParties(KaosesPartySizesSettings.Instance.mercenaryFactionsMinMultiplier, KaosesPartySizesSettings.Instance.mercenaryFactionsMaxMultiplier);
			}
			else
			{
				bool flag2 = this._partyTemplate.StringId.Contains("outlaw") && KaosesPartySizesSettings.Instance.outlawFactionsMultiplierEnabled;
				if (flag2)
				{
					base.processParties(KaosesPartySizesSettings.Instance.outlawFactionsMinMultiplier, KaosesPartySizesSettings.Instance.outlawFactionsMaxMultiplier);
				}
				else
				{
					bool flag3 = this._partyTemplate.StringId.Contains("villager") && KaosesPartySizesSettings.Instance.villagersPesantsMultiplierEnabled;
					if (flag3)
					{
						base.processParties(KaosesPartySizesSettings.Instance.villagersPesantsMinMultiplier, KaosesPartySizesSettings.Instance.villagersPesantsMaxMultiplier);
					}
				}
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00003CAA File Offset: 0x00001EAA
		public void processMercenary()
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00003CAA File Offset: 0x00001EAA
		public void processOutlaw()
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00003CAA File Offset: 0x00001EAA
		public void processVillager()
		{
		}
	}
}
