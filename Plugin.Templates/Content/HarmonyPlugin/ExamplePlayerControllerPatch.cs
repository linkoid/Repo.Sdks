﻿using HarmonyLib;
using UnityEngine;

namespace HarmonyPlugin._0;

[HarmonyPatch(typeof(PlayerController))]
static class ExamplePlayerControllerPatch
{
    [HarmonyPrefix, HarmonyPatch("Update")]
    private static void Update_Prefix(PlayerController __instance)
    {
        // Code to execute for each PlayerController *before* Update() is called.
        HarmonyPlugin__0.Logger.LogDebug($"{__instance} Update Prefix");
    }

    [HarmonyPostfix, HarmonyPatch("Update")]
    private static void Update_Postfix(PlayerController __instance)
    {
        // Code to execute for each PlayerController *after* Update() is called.
        HarmonyPlugin__0.Logger.LogDebug($"{__instance} Update Postfix");
    }
}