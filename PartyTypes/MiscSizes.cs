using System;
using KaosesPartySizes.Objects;
using KaosesPartySizes.Settings;
using TaleWorlds.CampaignSystem;

namespace KaosesPartySizes.PartyTypes
{
	internal class MiscSizes : BaseTemplateSizes
	{
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

		public void processMercenary()
		{
		}

		public void processOutlaw()
		{
		}

		public void processVillager()
		{
		}
	}
}
