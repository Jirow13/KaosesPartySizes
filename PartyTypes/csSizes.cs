using System;
using KaosesPartySizes.Objects;
using KaosesPartySizes.Settings;
using TaleWorlds.CampaignSystem;

namespace KaosesPartySizes.PartyTypes
{
	internal class CSSizes : BaseTemplateSizes
	{
		public CSSizes(PartyTemplateObject pt)
		{
			PartyTemplate = pt;
			if (KaosesPartySizesSettings.Instance is { } instance && instance.CSFactionsMultiplierEnabled)
			{
				base.ProcessParties(instance.CSFactionsMinMultiplier, instance.CSFactionsMaxMultiplier);
			}
		}
	}
}
