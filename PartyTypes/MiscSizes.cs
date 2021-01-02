using System;
using KaosesPartySizes.Objects;
using KaosesPartySizes.Settings;
using KaosesPartySizes.Utils;
using TaleWorlds.CampaignSystem;

namespace KaosesPartySizes.PartyTypes
{
	internal class MiscSizes : BaseTemplateSizes
	{
		public MiscSizes(PartyTemplateObject pt)
		{
			PartyTemplate = pt;

			if (!(KaosesPartySizesSettings.Instance is { } instance))
			{
				Ux.ShowMessageError("Kaoses Party sizes: Error setting 'Misc Party' Sizes!");
				return;
			}

			bool flag = this.PartyTemplate.StringId.Contains("mercenary") && instance.MercenaryFactionsMultiplierEnabled;
			if (flag && pt is not null)
			{
				base.ProcessParties(instance.MercenaryFactionsMinMultiplier, instance.MercenaryFactionsMaxMultiplier);
			}
			else
			{
				bool flag2 = this.PartyTemplate.StringId.Contains("outlaw") && instance.OutlawFactionsMultiplierEnabled;
				if (flag2)
				{
					base.ProcessParties(instance.OutlawFactionsMinMultiplier, instance.OutlawFactionsMaxMultiplier);
				}
				else
				{
					bool flag3 = this.PartyTemplate.StringId.Contains("Villager") && instance.VillagersPesantsMultiplierEnabled;
					if (flag3)
					{
						base.ProcessParties(instance.VillagersPesantsMinMultiplier, instance.VillagersPesantsMaxMultiplier);
					}
				}
			}
		}

		public void ProcessMercenary()
		{
		}

		public void ProcessOutlaw()
		{
		}

		public void ProcessVillager()
		{
		}
	}
}
