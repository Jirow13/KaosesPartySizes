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
            if (!(KaosesPartySizesSettings.Instance is { } instance))
                return true;
            __result = instance.LootersMaximumNoLooterParties;
            return false;
        }

        static bool Prepare() => KaosesPartySizesSettings.Instance is { } instance && instance.EnableHideoutTweaks;
    }

    [HarmonyPatch(typeof(DefaultBanditDensityModel), "get_NumberOfMinimumBanditPartiesInAHideoutToInfestIt")]
    public class NumberOfMinimumBanditPartiesInAHideoutToInfestItPatch
    {
        static bool Prefix(ref int __result)
        {
            if (!(KaosesPartySizesSettings.Instance is { } instance))
                return true;
            __result = instance.NumberOfMinimumBanditPartiesInAHideoutToInfestIt;
            return false;
        }

        static bool Prepare() => KaosesPartySizesSettings.Instance is { } instance && instance.EnableHideoutTweaks;
    }

    [HarmonyPatch(typeof(DefaultBanditDensityModel), "get_NumberOfMaximumBanditPartiesInEachHideout")]
    public class NumberOfMaximumBanditPartiesInEachHideoutPatch
    {
        static bool Prefix(ref int __result)
        {
            if (!(KaosesPartySizesSettings.Instance is { } instance))
                return true;
            __result = instance.NumberOfMaximumBanditPartiesInEachHideout;
            return false;
        }

        static bool Prepare() => KaosesPartySizesSettings.Instance is { } instance && instance.EnableHideoutTweaks;

    }

    [HarmonyPatch(typeof(DefaultBanditDensityModel), "get_NumberOfMaximumBanditPartiesAroundEachHideout")]
    public class NumberOfMaximumBanditPartiesAroundEachHideoutPatch
    {
        static bool Prefix(ref int __result)
        {
            if (!(KaosesPartySizesSettings.Instance is { } instance))
                return true;
            __result = instance.NumberOfMaximumBanditPartiesAroundEachHideout;
            return false;
        }

        static bool Prepare() => KaosesPartySizesSettings.Instance is { } instance && instance.EnableHideoutTweaks;
    }

    [HarmonyPatch(typeof(DefaultBanditDensityModel), "get_NumberOfMaximumHideoutsAtEachBanditFaction")]
    public class NumberOfMaximumHideoutsAtEachBanditFactionPatch
    {
        static bool Prefix(ref int __result)
        {
            if (!(KaosesPartySizesSettings.Instance is { } instance))
                return true;
            __result = instance.NumberOfMaximumHideoutsAtEachBanditFaction;
            return false;
        }

        static bool Prepare() => KaosesPartySizesSettings.Instance is { } instance && instance.EnableHideoutTweaks;
    }

    [HarmonyPatch(typeof(DefaultBanditDensityModel), "get_NumberOfInitialHideoutsAtEachBanditFaction")]
    public class NumberOfInitialHideoutsAtEachBanditFactionPatch
    {
        static bool Prefix(ref int __result)
        {
            if (!(KaosesPartySizesSettings.Instance is { } instance))
                return true;
            __result = instance.NumberOfInitialHideoutsAtEachBanditFaction;
            return false;
        }

        static bool Prepare() => KaosesPartySizesSettings.Instance is { } instance && instance.EnableHideoutTweaks;
    }

    /* Duplicates Bannerlord Tweaks
    [HarmonyPatch(typeof(DefaultBanditDensityModel), "get_PlayerMaximumTroopCountForHideoutMission")]
    public class PlayerMaximumTroopCountForHideoutMissionPatch
    {
        static bool Prefix(ref int __result)
        {
            __result = Math.Min(instance.PlayerMaximumTroopCountForHideoutMission, 90);
            return false;
        }

        static bool Prepare()
        {
            return instance.EnableHideoutTweaks;
        }
    }
    */

}
