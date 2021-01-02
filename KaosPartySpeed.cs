using System;
using Helpers;
using KaosesPartySizes.Settings;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.SandBox.GameComponents.Map;
using TaleWorlds.Core;
using TaleWorlds.Localization;

// Jiros ToDo: Convert this to Harmony so updates to DefaultPartySpeedCalculatingModel don't wreck the mod.
// Jiros ToDo: Factor in new speed changes and perks as well.
// 2020-12-31 - v1.5.6.1

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

			if (KaosesPartySizesSettings.Instance is { } instance)
			{
				TerrainType faceTerrainType = Campaign.Current.MapSceneWrapper.GetFaceTerrainType(mobileParty.CurrentNavigationFace);
				if (faceTerrainType == TerrainType.Forest)
				{
					explainedNumber.AddFactor(-0.3f, _movingInForest);
					PerkHelper.AddFeatBonusForPerson(DefaultFeats.Cultural.BattanianForestAgility, mobileParty.Leader, ref explainedNumber);
				}

				else
				{
					if (faceTerrainType == TerrainType.Water || faceTerrainType == TerrainType.River || faceTerrainType == TerrainType.Bridge || faceTerrainType == TerrainType.ShallowRiver)
					{
						explainedNumber.AddFactor(-0.3f, _fordEffect);
					}
				}
				
				if (Campaign.Current.IsNight)
				{
					explainedNumber.AddFactor(-0.25f, _night);
				}
				
				if (faceTerrainType == TerrainType.Snow)
				{
					explainedNumber.AddFactor(-0.1f, _snow);
					if (party.Leader != null)
					{
						PerkHelper.AddFeatBonusForPerson(DefaultFeats.Cultural.SturgianSnowAgility, party.Leader, ref explainedNumber);
					}
				}

				if (mobileParty.IsActive)
				{
					bool partyTypeFound = false;
					if (mobileParty.StringId.Contains("Looter") && instance.LooterSpeedReductiontEnabled)
					{
						explainedNumber.Add(instance.CaravanSpeedReductionAmount, _slowMessage);
						partyTypeFound = true;
					}
					if (mobileParty.StringId.Contains("Caravan"))
					{
						if (mobileParty.StringId.Contains("elite") && instance.EliteCaravanSpeedReductiontEnabled)
						{
							explainedNumber.Add(instance.EliteCaravanSpeedReductionAmount, _slowCaravansMessage);
						}
						else
						{
							bool CaravanSpeedReductiontEnabled = instance.CaravanSpeedReductiontEnabled;
							if (CaravanSpeedReductiontEnabled)
							{
								explainedNumber.Add(instance.CaravanSpeedReductionAmount, _slowCaravansMessage);
							}
						}
						partyTypeFound = true;
					}

					if (mobileParty.StringId.Contains("Desert") && instance.DesertSpeedReductiontEnabled)
					{
						explainedNumber.Add(instance.DesertSpeedReductionAmount, _slowMessage);
						partyTypeFound = true;
					}

					if (mobileParty.StringId.Contains("forest") && instance.ForestSpeedReductiontEnabled)
					{
						explainedNumber.Add(instance.ForestSpeedReductionAmount, _slowMessage);
						partyTypeFound = true;
					}

					if (mobileParty.StringId.Contains("mountain") && instance.MountainSpeedReductiontEnabled)
					{
						explainedNumber.Add(instance.MountainSpeedReductionAmount, _slowMessage);
						partyTypeFound = true;
					}

					if (mobileParty.StringId.Contains("raider") && instance.SeaRaiderSpeedReductiontEnabled)
					{
						explainedNumber.Add(instance.SeaRaiderSpeedReductionAmount, _slowMessage);
						partyTypeFound = true;
					}

					if (mobileParty.StringId.Contains("Steppe") && instance.SteppeSpeedReductiontEnabled)
					{
						explainedNumber.Add(instance.SteppeSpeedReductionAmount, _slowMessage);
						partyTypeFound = true;
					}

					if (mobileParty.StringId.Contains("Villager") && instance.VillagerSpeedReductiontEnabled)
					{
						explainedNumber.Add(instance.VillagerSpeedReductionAmount, _slowVillagerMessage);
						partyTypeFound = true;
					}

					if (mobileParty.StringId.Contains("lord_") && instance.KingdomSpeedReductiontEnabled)
					{
						explainedNumber.Add(instance.KingdomSpeedReductionAmount, _slowKingdomMessage);
						partyTypeFound = true;
					}

					if (mobileParty.StringId.Contains("troops_of") && instance.OtherKingdomSpeedReductionEnabled)
					{
						explainedNumber.Add(instance.OtherKingdomSpeedReductionAmount, _slowMinorMessage);
						partyTypeFound = true;
					}

					if (mobileParty.IsMainParty && instance.PlayerSpeedReductiontEnabled)
					{
						explainedNumber.Add(instance.PlayerSpeedReductionAmount, _slowPlayerMessage);
						partyTypeFound = true;
					}

					if (!mobileParty.IsMainParty && !mobileParty.StringId.Contains("player_") && !mobileParty.StringId.Contains("militias_") && !mobileParty.StringId.Contains("garrison_"))
					{

						if (!partyTypeFound && !mobileParty.IsLeaderless)
						{
							Hero hero = mobileParty.LeaderHero;
							if (hero != null)
							{
								Clan clan = hero.Clan;
								Clan PlayerClan = Clan.PlayerClan;

								if (clan == PlayerClan && instance.PlayerCompanionSpeedReductiontEnabled)
								{
									explainedNumber.Add(instance.PlayerCompanionSpeedReductionAmount, _slowPlayerClanMessage);
								}
								else
								{
									bool OtherKingdomSpeedReductionEnabled = instance.OtherKingdomSpeedReductionEnabled;
									if (OtherKingdomSpeedReductionEnabled)
									{
										explainedNumber.Add(instance.OtherKingdomSpeedReductionAmount, _slowMinorMessage);
									}
								}
							}
						}
					}
				}
				explainedNumber.LimitMin(instance.KaosesMininumSpeedAmount);
			}
			return explainedNumber.ResultNumber;
		}

		private static readonly TextObject _movingInForest = new TextObject("{=rTFaZCdY}Forest", null);

		private static readonly TextObject _fordEffect = new TextObject("{=NT5fwUuJ}Fording", null);

		private static readonly TextObject _night = new TextObject("{=fAxjyMt5}Night", null);

		private static readonly TextObject _snow = new TextObject("{=vLjgcdgB}Snow", null);

		//private static readonly TextObject _sturgiaSnowBonus = new TextObject("{=0VfEGekD}Sturgia Snow Bonus", null);

		private static readonly TextObject _slowMessage = new TextObject("{=1ZiDIanZ}Kaoses Bandits", null);

		private static readonly TextObject _slowPlayerMessage = new TextObject("{=1ZiDIa2Z}Kaoses Player", null);

		private static readonly TextObject _slowPlayerClanMessage = new TextObject("{=1ZiDIa6Z}Player Clan", null);

		private static readonly TextObject _slowMinorMessage = new TextObject("{=1ZiDIa4Z}Kaoses Minor", null);

		private static readonly TextObject _slowKingdomMessage = new TextObject("{=1ZiDIa3Z}Kaoses Kingdom", null);

		private static readonly TextObject _slowVillagerMessage = new TextObject("{=1ZiDIa4Z}Kaoses Villagers", null);

		private static readonly TextObject _slowCaravansMessage = new TextObject("{=1ZiDIa5Z}Kaoses Caravans", null);
	}
}
