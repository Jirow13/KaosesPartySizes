using System;
using Helpers;
using KaosesPartySizes.Settings;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.SandBox.GameComponents.Map;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace KaosesPartySizes.Models
{
	// Token: 0x02000011 RID: 17
	internal class KaosPartySpeed : DefaultPartySpeedCalculatingModel
	{
		// Token: 0x06000137 RID: 311 RVA: 0x000041F0 File Offset: 0x000023F0
		public override float CalculatePureSpeed(MobileParty mobileParty, StatExplainer explanation, int additionalTroopOnFootCount = 0, int additionalTroopOnHorseCount = 0)
		{
			return base.CalculatePureSpeed(mobileParty, explanation, additionalTroopOnFootCount, additionalTroopOnHorseCount);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00004210 File Offset: 0x00002410
		public override float CalculateFinalSpeed(MobileParty mobileParty, float baseSpeed, StatExplainer explanation)
		{
			PartyBase party = mobileParty.Party;
			ExplainedNumber explainedNumber = new ExplainedNumber(baseSpeed, explanation, null);
			TerrainType faceTerrainType = Campaign.Current.MapSceneWrapper.GetFaceTerrainType(mobileParty.CurrentNavigationFace);
			bool flag = faceTerrainType == TerrainType.Forest;
			if (flag)
			{
				explainedNumber.AddFactor(-0.3f, KaosPartySpeed._movingInForest);
				PerkHelper.AddFeatBonusForPerson(DefaultFeats.Cultural.BattanianForestAgility, mobileParty.Leader, ref explainedNumber);
			}
			else
			{
				bool flag2 = faceTerrainType == TerrainType.Water || faceTerrainType == TerrainType.River || faceTerrainType == TerrainType.Bridge || faceTerrainType == TerrainType.ShallowRiver;
				if (flag2)
				{
					explainedNumber.AddFactor(-0.3f, KaosPartySpeed._fordEffect);
				}
			}
			bool isNight = Campaign.Current.IsNight;
			if (isNight)
			{
				explainedNumber.AddFactor(-0.25f, KaosPartySpeed._night);
			}
			bool flag3 = faceTerrainType == TerrainType.Snow;
			if (flag3)
			{
				explainedNumber.AddFactor(-0.1f, KaosPartySpeed._snow);
				bool flag4 = party.Leader != null;
				if (flag4)
				{
					PerkHelper.AddFeatBonusForPerson(DefaultFeats.Cultural.SturgianSnowAgility, party.Leader, ref explainedNumber);
				}
			}
			bool isActive = mobileParty.IsActive;
			if (isActive)
			{
				bool partyTypeFound = false;
				bool flag5 = mobileParty.StringId.Contains("looter") && ModSettings.Instance.looterSpeedReductiontEnabled;
				if (flag5)
				{
					explainedNumber.Add(ModSettings.Instance.caravanSpeedReductionAmount, KaosPartySpeed._slowMessage);
					partyTypeFound = true;
				}
				bool flag6 = mobileParty.StringId.Contains("caravan");
				if (flag6)
				{
					bool flag7 = mobileParty.StringId.Contains("elite") && ModSettings.Instance.eliteCaravanSpeedReductiontEnabled;
					if (flag7)
					{
						explainedNumber.Add(ModSettings.Instance.eliteCaravanSpeedReductionAmount, KaosPartySpeed._slowCaravansMessage);
					}
					else
					{
						bool caravanSpeedReductiontEnabled = ModSettings.Instance.caravanSpeedReductiontEnabled;
						if (caravanSpeedReductiontEnabled)
						{
							explainedNumber.Add(ModSettings.Instance.caravanSpeedReductionAmount, KaosPartySpeed._slowCaravansMessage);
						}
					}
					partyTypeFound = true;
				}
				bool flag8 = mobileParty.StringId.Contains("desert") && ModSettings.Instance.desertSpeedReductiontEnabled;
				if (flag8)
				{
					explainedNumber.Add(ModSettings.Instance.desertSpeedReductionAmount, KaosPartySpeed._slowMessage);
					partyTypeFound = true;
				}
				bool flag9 = mobileParty.StringId.Contains("forest") && ModSettings.Instance.forestSpeedReductiontEnabled;
				if (flag9)
				{
					explainedNumber.Add(ModSettings.Instance.forestSpeedReductionAmount, KaosPartySpeed._slowMessage);
					partyTypeFound = true;
				}
				bool flag10 = mobileParty.StringId.Contains("mountain") && ModSettings.Instance.mountainSpeedReductiontEnabled;
				if (flag10)
				{
					explainedNumber.Add(ModSettings.Instance.mountainSpeedReductionAmount, KaosPartySpeed._slowMessage);
					partyTypeFound = true;
				}
				bool flag11 = mobileParty.StringId.Contains("raider") && ModSettings.Instance.seaRaiderSpeedReductiontEnabled;
				if (flag11)
				{
					explainedNumber.Add(ModSettings.Instance.seaRaiderSpeedReductionAmount, KaosPartySpeed._slowMessage);
					partyTypeFound = true;
				}
				bool flag12 = mobileParty.StringId.Contains("steppe") && ModSettings.Instance.steppeSpeedReductiontEnabled;
				if (flag12)
				{
					explainedNumber.Add(ModSettings.Instance.steppeSpeedReductionAmount, KaosPartySpeed._slowMessage);
					partyTypeFound = true;
				}
				bool flag13 = mobileParty.StringId.Contains("villager") && ModSettings.Instance.villagerSpeedReductiontEnabled;
				if (flag13)
				{
					explainedNumber.Add(ModSettings.Instance.villagerSpeedReductionAmount, KaosPartySpeed._slowVillagerMessage);
					partyTypeFound = true;
				}
				bool flag14 = mobileParty.StringId.Contains("lord_") && ModSettings.Instance.kingdomSpeedReductiontEnabled;
				if (flag14)
				{
					explainedNumber.Add(ModSettings.Instance.kingdomSpeedReductionAmount, KaosPartySpeed._slowKingdomMessage);
					partyTypeFound = true;
				}
				bool flag15 = mobileParty.StringId.Contains("troops_of") && ModSettings.Instance.otherKingdomSpeedReductionEnabled;
				if (flag15)
				{
					explainedNumber.Add(ModSettings.Instance.otherKingdomSpeedReductionAmount, KaosPartySpeed._slowMinorMessage);
					partyTypeFound = true;
				}
				bool flag16 = mobileParty.IsMainParty && ModSettings.Instance.playerSpeedReductiontEnabled;
				if (flag16)
				{
					explainedNumber.Add(ModSettings.Instance.playerSpeedReductionAmount, KaosPartySpeed._slowPlayerMessage);
					partyTypeFound = true;
				}
				bool flag17 = !mobileParty.IsMainParty && !mobileParty.StringId.Contains("player_") && !mobileParty.StringId.Contains("militias_") && !mobileParty.StringId.Contains("garrison_");
				if (flag17)
				{
					bool flag18 = !partyTypeFound && !mobileParty.IsLeaderless;
					if (flag18)
					{
						Hero hero = mobileParty.LeaderHero;
						bool flag19 = hero != null;
						if (flag19)
						{
							Clan clan = hero.Clan;
							Clan playerClan = Clan.PlayerClan;
							bool flag20 = clan == playerClan && ModSettings.Instance.playerCompanionSpeedReductiontEnabled;
							if (flag20)
							{
								explainedNumber.Add(ModSettings.Instance.playerCompanionSpeedReductionAmount, KaosPartySpeed._slowPlayerClanMessage);
							}
							else
							{
								bool otherKingdomSpeedReductionEnabled = ModSettings.Instance.otherKingdomSpeedReductionEnabled;
								if (otherKingdomSpeedReductionEnabled)
								{
									explainedNumber.Add(ModSettings.Instance.otherKingdomSpeedReductionAmount, KaosPartySpeed._slowMinorMessage);
								}
							}
						}
					}
				}
			}
			explainedNumber.LimitMin(ModSettings.Instance.kaosesmininumSpeedAmount);
			return explainedNumber.ResultNumber;
		}

		// Token: 0x04000090 RID: 144
		private static readonly TextObject _movingInForest = new TextObject("{=rTFaZCdY}Forest", null);

		// Token: 0x04000091 RID: 145
		private static readonly TextObject _fordEffect = new TextObject("{=NT5fwUuJ}Fording", null);

		// Token: 0x04000092 RID: 146
		private static readonly TextObject _night = new TextObject("{=fAxjyMt5}Night", null);

		// Token: 0x04000093 RID: 147
		private static readonly TextObject _snow = new TextObject("{=vLjgcdgB}Snow", null);

		// Token: 0x04000094 RID: 148
		private static readonly TextObject _sturgiaSnowBonus = new TextObject("{=0VfEGekD}Sturgia Snow Bonus", null);

		// Token: 0x04000095 RID: 149
		private static readonly TextObject _slowMessage = new TextObject("{=1ZiDIanZ}Kaoses Bandits", null);

		// Token: 0x04000096 RID: 150
		private static readonly TextObject _slowPlayerMessage = new TextObject("{=1ZiDIa2Z}Kaoses Player", null);

		// Token: 0x04000097 RID: 151
		private static readonly TextObject _slowPlayerClanMessage = new TextObject("{=1ZiDIa6Z}Player Clan", null);

		// Token: 0x04000098 RID: 152
		private static readonly TextObject _slowMinorMessage = new TextObject("{=1ZiDIa4Z}Kaoses Minor", null);

		// Token: 0x04000099 RID: 153
		private static readonly TextObject _slowKingdomMessage = new TextObject("{=1ZiDIa3Z}Kaoses Kingdom", null);

		// Token: 0x0400009A RID: 154
		private static readonly TextObject _slowVillagerMessage = new TextObject("{=1ZiDIa4Z}Kaoses Villagers", null);

		// Token: 0x0400009B RID: 155
		private static readonly TextObject _slowCaravansMessage = new TextObject("{=1ZiDIa5Z}Kaoses Caravans", null);
	}
}
