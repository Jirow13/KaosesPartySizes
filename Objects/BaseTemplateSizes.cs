using System;
using KaosesPartySizes.Utils;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Library;

namespace KaosesPartySizes.Objects
{
	public class BaseTemplateSizes
	{
		public void processParties(float minMultiplier, float maxMultiplier)
		{
			bool flag = this._partyTemplate != null;

			//if (flag)
			if (flag && this._partyTemplate.Stacks != null)
			{
				Ux.ShowMessageDebug("this._partyTemplate = " + this._partyTemplate.StringId);
				Ux.ShowMessageDebug("Stacks.Count = " + this._partyTemplate.Stacks.Count);
				for (int i = 0; i < this._partyTemplate.Stacks.Count; i++)
				{
					Ux.ShowMessageDebug("Starting i = "+i);
					this._partyTemplate.Stacks[i] = this.processStacks(this._partyTemplate.Stacks[i], minMultiplier, maxMultiplier);
				}
			}
			else
			{
				Ux.ShowMessageDebug("Kaoses Parties processParties invalid Party template or no stacks");
			}
		}

		public void processBanditBoss(float minMultiplier, float maxMultiplier)
		{
			bool flag = this._partyTemplate != null;
			//if (flag)
			if (flag && this._partyTemplate.Stacks != null)
			{
				for (int i = 0; i < this._partyTemplate.Stacks.Count; i++)
				{
					PartyTemplateStack item = this._partyTemplate.Stacks[i];
					bool flag2 = !item.Character.StringId.Contains("boss");
					if (flag2)
					{
						this._partyTemplate.Stacks[i] = this.processStacks(this._partyTemplate.Stacks[i], minMultiplier, maxMultiplier);
					}
				}
			}
			else
			{
				Ux.ShowMessageError("Kaoses Parties processBanditBoss invalid Party template or no stacks");
			}
		}

		private PartyTemplateStack processStacks(PartyTemplateStack partyStack, float minMultiplier, float maxMultiplier)
		{
			int newMin = this.getNewFloatValue(partyStack.MinValue, minMultiplier);
			int newMax = this.getNewFloatValue(partyStack.MaxValue, maxMultiplier);
			bool flag = newMax < newMin;
			if (flag)
			{
				newMax = newMin;
			}
			partyStack.MinValue = newMin;
			partyStack.MaxValue = newMax;
			return partyStack;
		}

		public int getNewFloatValue(int value, float multiplier)
		{
			float tmpMin = (float)value * multiplier;
			int newValue = (int)tmpMin;
			bool flag = newValue < 1 && value >= 1;
			if (flag)
			{
				newValue = 1;
			}
			return newValue;
		}

		public bool isBossParty()
		{
			bool isBoss = false;
			bool flag = this._partyTemplate.StringId.Contains("boss");
			if (flag)
			{
				isBoss = true;
			}
			return isBoss;
		}

		public bool isNotRestrictedParty(PartyTemplateObject pt)
		{
			bool isRestricted = true;
			bool flag = pt.StringId.Contains("militia") && pt.StringId.Contains("quest") && pt.StringId.Contains("rebels");
			if (flag)
			{
				isRestricted = false;
			}
			return isRestricted;
		}

		public PartyTemplateObject _partyTemplate;
	}
}
