using System;
using KaosesPartySizes.Utils;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Library;

namespace KaosesPartySizes.Objects
{
	public class BaseTemplateSizes
	{
		public void ProcessParties(float minMultiplier, float maxMultiplier)
		{
			if (PartyTemplate != null && PartyTemplate.Stacks != null)
			{
				Ux.ShowMessageDebug("PartyTemplate = " + PartyTemplate.StringId);
				Ux.ShowMessageDebug("Stacks.Count = " + PartyTemplate.Stacks.Count);
				for (int i = 0; i < PartyTemplate.Stacks.Count; i++)
				{
					Ux.ShowMessageDebug("Starting i = "+i);
					PartyTemplate.Stacks[i] = this.ProcessStacks(PartyTemplate.Stacks[i], minMultiplier, maxMultiplier);
				}
			}
			else
			{
				Ux.ShowMessageDebug("Kaoses Parties ProcessParties invalid Party template or no stacks");
			}
		}

		public void ProcessBanditBoss(float minMultiplier, float maxMultiplier)
		{
			if (PartyTemplate != null && PartyTemplate.Stacks != null)
			{
				for (int i = 0; i < PartyTemplate.Stacks.Count; i++)
				{
					PartyTemplateStack item = PartyTemplate.Stacks[i];
					bool flag2 = !item.Character.StringId.Contains("boss");
					if (flag2)
					{
						PartyTemplate.Stacks[i] = ProcessStacks(PartyTemplate.Stacks[i], minMultiplier, maxMultiplier);
					}
				}
			}
			else
			{
				Ux.ShowMessageError("Kaoses Parties ProcessBanditBoss invalid Party template or no stacks");
			}
		}

		private PartyTemplateStack ProcessStacks(PartyTemplateStack partyStack, float minMultiplier, float maxMultiplier)
		{
			int newMin = GetNewFloatValue(partyStack.MinValue, minMultiplier);
			int newMax = GetNewFloatValue(partyStack.MaxValue, maxMultiplier);
			bool flag = newMax < newMin;
			if (flag)
			{
				newMax = newMin;
			}
			partyStack.MinValue = newMin;
			partyStack.MaxValue = newMax;
			return partyStack;
		}

		public int GetNewFloatValue(int value, float multiplier)
		{
			float tmpMin = value * multiplier;
			int newValue = (int)tmpMin;
			bool flag = newValue < 1 && value >= 1;
			if (flag)
			{
				newValue = 1;
			}
			return newValue;
		}

		public bool IsBossParty()
		{
			bool isBoss = false;

			if (PartyTemplate is { } template && template.StringId.Contains("boss"))
			{
				isBoss = true;
			}
			return isBoss;
		}

		public bool IsNotRestrictedParty(PartyTemplateObject pt)
		{
			bool isRestricted = true;
			bool flag = pt.StringId.Contains("militia") && pt.StringId.Contains("quest") && pt.StringId.Contains("rebels");
			if (flag)
			{
				isRestricted = false;
			}
			return isRestricted;
		}

		public PartyTemplateObject? PartyTemplate;
	}
}
