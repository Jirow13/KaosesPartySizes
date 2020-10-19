using System;
using Helpers;
using KaosesPartySizes.Settings;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.SandBox.GameComponents.Map;
using TaleWorlds.Core;
using TaleWorlds.Localization;

// Jiros ToDo: Convert this to Harmony so updates to DefaultPartySpeedCalculatingModel don't wreck the mod.

namespace KaosesPartySizes.Models
{
	internal class KaosPartySpeed : DefaultPartySpeedCalculatingModel
	{
		public override float CalculatePureSpeed(MobileParty mobileParty, StatExplainer explanation, int additionalTroopOnFootCount = 0, int additionalTroopOnHorseCount = 0)
		{
			return base.CalculatePureSpeed(mobileParty, explanation, additionalTroopOnFootCount, additionalTroopOnHorseCount);
		}

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
				bool flag5 = mobileParty.StringId.Contains("looter") && KaosesPartySizesSettings.Instance.looterSpeedReductiontEnabled;
				if (flag5)
				{
					explainedNumber.Add(KaosesPartySizesSettings.Instance.caravanSpeedReductionAmount, KaosPartySpeed._slowMessage);
					partyTypeFound = true;
				}
				bool flag6 = mobileParty.StringId.Contains("caravan");
				if (flag6)
				{
					bool flag7 = mobileParty.StringId.Contains("elite") && KaosesPartySizesSettings.Instance.eliteCaravanSpeedReductiontEnabled;
					if (flag7)
					{
						explainedNumber.Add(KaosesPartySizesSettings.Instance.eliteCaravanSpeedReductionAmount, KaosPartySpeed._slowCaravansMessage);
					}
					else
					{
						bool caravanSpeedReductiontEnabled = KaosesPartySizesSettings.Instance.caravanSpeedReductiontEnabled;
						if (caravanSpeedReductiontEnabled)
						{
							explainedNumber.Add(KaosesPartySizesSettings.Instance.caravanSpeedReductionAmount, KaosPartySpeed._slowCaravansMessage);
						}
					}
					partyTypeFound = true;
				}
				bool flag8 = mobileParty.StringId.Contains("desert") && KaosesPartySizesSettings.Instance.desertSpeedReductiontEnabled;
				if (flag8)
				{
					explainedNumber.Add(KaosesPartySizesSettings.Instance.desertSpeedReductionAmount, KaosPartySpeed._slowMessage);
					partyTypeFound = true;
				}
				bool flag9 = mobileParty.StringId.Contains("forest") && KaosesPartySizesSettings.Instance.forestSpeedReductiontEnabled;
				if (flag9)
				{
					explainedNumber.Add(KaosesPartySizesSettings.Instance.forestSpeedReductionAmount, KaosPartySpeed._slowMessage);
					partyTypeFound = true;
				}
				bool flag10 = mobileParty.StringId.Contains("mountain") && KaosesPartySizesSettings.Instance.mountainSpeedReductiontEnabled;
				if (flag10)
				{
					explainedNumber.Add(KaosesPartySizesSettings.Instance.mountainSpeedReductionAmount, KaosPartySpeed._slowMessage);
					partyTypeFound = true;
				}
				bool flag11 = mobileParty.StringId.Contains("raider") && KaosesPartySizesSettings.Instance.seaRaiderSpeedReductiontEnabled;
				if (flag11)
				{
					explainedNumber.Add(KaosesPartySizesSettings.Instance.seaRaiderSpeedReductionAmount, KaosPartySpeed._slowMessage);
					partyTypeFound = true;
				}
				bool flag12 = mobileParty.StringId.Contains("steppe") && KaosesPartySizesSettings.Instance.steppeSpeedReductiontEnabled;
				if (flag12)
				{
					explainedNumber.Add(KaosesPartySizesSettings.Instance.steppeSpeedReductionAmount, KaosPartySpeed._slowMessage);
					partyTypeFound = true;
				}
				bool flag13 = mobileParty.StringId.Contains("villager") && KaosesPartySizesSettings.Instance.villagerSpeedReductiontEnabled;
				if (flag13)
				{
					explainedNumber.Add(KaosesPartySizesSettings.Instance.villagerSpeedReductionAmount, KaosPartySpeed._slowVillagerMessage);
					partyTypeFound = true;
				}
				bool flag14 = mobileParty.StringId.Contains("lord_") && KaosesPartySizesSettings.Instance.kingdomSpeedReductiontEnabled;
				if (flag14)
				{
					explainedNumber.Add(KaosesPartySizesSettings.Instance.kingdomSpeedReductionAmount, KaosPartySpeed._slowKingdomMessage);
					partyTypeFound = true;
				}
				bool flag15 = mobileParty.StringId.Contains("troops_of") && KaosesPartySizesSettings.Instance.otherKingdomSpeedReductionEnabled;
				if (flag15)
				{
					explainedNumber.Add(KaosesPartySizesSettings.Instance.otherKingdomSpeedReductionAmount, KaosPartySpeed._slowMinorMessage);
					partyTypeFound = true;
				}
				bool flag16 = mobileParty.IsMainParty && KaosesPartySizesSettings.Instance.playerSpeedReductiontEnabled;
				if (flag16)
				{
					explainedNumber.Add(KaosesPartySizesSettings.Instance.playerSpeedReductionAmount, KaosPartySpeed._slowPlayerMessage);
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
							bool flag20 = clan == playerClan && KaosesPartySizesSettings.Instance.playerCompanionSpeedReductiontEnabled;
							if (flag20)
							{
								explainedNumber.Add(KaosesPartySizesSettings.Instance.playerCompanionSpeedReductionAmount, KaosPartySpeed._slowPlayerClanMessage);
							}
							else
							{
								bool otherKingdomSpeedReductionEnabled = KaosesPartySizesSettings.Instance.otherKingdomSpeedReductionEnabled;
								if (otherKingdomSpeedReductionEnabled)
								{
									explainedNumber.Add(KaosesPartySizesSettings.Instance.otherKingdomSpeedReductionAmount, KaosPartySpeed._slowMinorMessage);
								}
							}
						}
					}
				}
			}
			explainedNumber.LimitMin(KaosesPartySizesSettings.Instance.kaosesmininumSpeedAmount);
			return explainedNumber.ResultNumber;
		}

		private static readonly TextObject _movingInForest = new TextObject("{=rTFaZCdY}Forest", null);

		private static readonly TextObject _fordEffect = new TextObject("{=NT5fwUuJ}Fording", null);

		private static readonly TextObject _night = new TextObject("{=fAxjyMt5}Night", null);

		private static readonly TextObject _snow = new TextObject("{=vLjgcdgB}Snow", null);

		private static readonly TextObject _sturgiaSnowBonus = new TextObject("{=0VfEGekD}Sturgia Snow Bonus", null);

		private static readonly TextObject _slowMessage = new TextObject("{=1ZiDIanZ}Kaoses Bandits", null);

		private static readonly TextObject _slowPlayerMessage = new TextObject("{=1ZiDIa2Z}Kaoses Player", null);

		private static readonly TextObject _slowPlayerClanMessage = new TextObject("{=1ZiDIa6Z}Player Clan", null);

		private static readonly TextObject _slowMinorMessage = new TextObject("{=1ZiDIa4Z}Kaoses Minor", null);

		private static readonly TextObject _slowKingdomMessage = new TextObject("{=1ZiDIa3Z}Kaoses Kingdom", null);

		private static readonly TextObject _slowVillagerMessage = new TextObject("{=1ZiDIa4Z}Kaoses Villagers", null);

		private static readonly TextObject _slowCaravansMessage = new TextObject("{=1ZiDIa5Z}Kaoses Caravans", null);
	}
}
