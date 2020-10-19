using HarmonyLib;
using KaosesPartySizes.Settings;
using System;
using TaleWorlds.CampaignSystem.SandBox.GameComponents.Map;


namespace KaosesPartySizes.Patches
{
    [HarmonyPatch(typeof(DefaultBanditDensityModel), "get_NumberOfMaximumLooterParties")]
    public class NumberOfMaximumLooterPartiesPatch
    {
        static bool Prefix(ref int __result)
        {
            __result = KaosesPartySizesSettings.Instance.lootersMaximumNoLooterParties;
            return false;
        }

        static bool Prepare()
        {
            return KaosesPartySizesSettings.Instance.EnableHideoutTweaks;
        }
    }

    [HarmonyPatch(typeof(DefaultBanditDensityModel), "get_NumberOfMinimumBanditPartiesInAHideoutToInfestIt")]
    public class NumberOfMinimumBanditPartiesInAHideoutToInfestItPatch
    {
        static bool Prefix(ref int __result)
        {
            __result = KaosesPartySizesSettings.Instance.NumberOfMinimumBanditPartiesInAHideoutToInfestIt;
            return false;
        }

        static bool Prepare()
        {
            return KaosesPartySizesSettings.Instance.EnableHideoutTweaks;
        }
    }

    [HarmonyPatch(typeof(DefaultBanditDensityModel), "get_NumberOfMaximumBanditPartiesInEachHideout")]
    public class NumberOfMaximumBanditPartiesInEachHideoutPatch
    {
        static bool Prefix(ref int __result)
        {
            __result = KaosesPartySizesSettings.Instance.NumberOfMaximumBanditPartiesInEachHideout;
            return false;
        }

        static bool Prepare()
        {
            return KaosesPartySizesSettings.Instance.EnableHideoutTweaks;
        }
    }

    [HarmonyPatch(typeof(DefaultBanditDensityModel), "get_NumberOfMaximumBanditPartiesAroundEachHideout")]
    public class NumberOfMaximumBanditPartiesAroundEachHideoutPatch
    {
        static bool Prefix(ref int __result)
        {
            __result = KaosesPartySizesSettings.Instance.NumberOfMaximumBanditPartiesAroundEachHideout;
            return false;
        }

        static bool Prepare()
        {
            return KaosesPartySizesSettings.Instance.EnableHideoutTweaks;
        }
    }

    [HarmonyPatch(typeof(DefaultBanditDensityModel), "get_NumberOfMaximumHideoutsAtEachBanditFaction")]
    public class NumberOfMaximumHideoutsAtEachBanditFactionPatch
    {
        static bool Prefix(ref int __result)
        {
            __result = KaosesPartySizesSettings.Instance.NumberOfMaximumHideoutsAtEachBanditFaction;
            return false;
        }

        static bool Prepare()
        {
            return KaosesPartySizesSettings.Instance.EnableHideoutTweaks;
        }
    }

    [HarmonyPatch(typeof(DefaultBanditDensityModel), "get_NumberOfInitialHideoutsAtEachBanditFaction")]
    public class NumberOfInitialHideoutsAtEachBanditFactionPatch
    {
        static bool Prefix(ref int __result)
        {
            __result = KaosesPartySizesSettings.Instance.NumberOfInitialHideoutsAtEachBanditFaction;
            return false;
        }

        static bool Prepare()
        {
            return KaosesPartySizesSettings.Instance.EnableHideoutTweaks;
        }
    }

    /*
    [HarmonyPatch(typeof(DefaultBanditDensityModel), "get_PlayerMaximumTroopCountForHideoutMission")]
    public class PlayerMaximumTroopCountForHideoutMissionPatch
    {
        static bool Prefix(ref int __result)
        {
            __result = Math.Min(KaosesPartySizesSettings.Instance.PlayerMaximumTroopCountForHideoutMission, 80);
            return false;
        }

        static bool Prepare()
        {
            return KaosesPartySizesSettings.Instance.EnableHideoutTweaks;
        }
    }
    */

}
