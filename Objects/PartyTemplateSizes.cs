using System;
using KaosesPartySizes.PartyTypes;
using TaleWorlds.CampaignSystem;

namespace KaosesPartySizes.Objects
{
	internal class PartyTemplateSizes
	{
		public PartyTemplateSizes(PartyTemplateObject pt)
		{
			bool flag = pt.StringId.Contains("looter") || pt.StringId.Contains("bandit") || pt.StringId.Contains("raider");
			if (flag)
			{
				new BanditSizes(pt);
			}
			else
			{
				bool flag2 = pt.StringId.Contains("mercenary") || pt.StringId.Contains("outlaw") || pt.StringId.Contains("villager");
				if (flag2)
				{
					new MiscSizes(pt);
				}
				else
				{
					bool flag3 = pt.StringId.Contains("caravan") && !pt.StringId.Contains("char_");
					if (flag3)
					{
						new Caravan(pt);
					}
					else
					{
						bool flag4 = pt.StringId.Contains("kingdom_hero") && this.isNotRestrictedParty(pt);
						if (flag4)
						{
							new KingdomSizes(pt);
						}
						else
						{
							bool flag5 = pt.StringId.Contains("char_") || (pt.StringId.Contains("gamescom_player") && !pt.StringId.Contains("caravan"));
							if (flag5)
							{
								new PlayerSizes(pt);
							}
							else
							{
								bool flag6 = pt.StringId.Contains("kingdom_hero_ai") || pt.StringId.Contains("kingdom_hero_minor");
								if (flag6)
								{
									new KingdomOtherSizes(pt);
								}
								else
								{
									bool flag7 = pt.StringId.Contains("cs_");
									if (flag7)
									{
										new csSizes(pt);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00004148 File Offset: 0x00002348
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
	}
}
