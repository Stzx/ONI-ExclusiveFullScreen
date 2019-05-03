using System;

using Harmony;

using UnityEngine;

using Internal = UnityEngine.Internal;

namespace ONI_ExclusiveFullScreen
{

    [HarmonyPatch(typeof(DistributionPlatform), "Initialize", new Type[0])]
    internal static class HarmonyPatchDistributionPlatform
    {
        private static bool Prefix()
        {
            Screen.fullScreenMode = (Screen.fullScreen) ? FullScreenMode.ExclusiveFullScreen : FullScreenMode.Windowed;

            return true;
        }
    }

    [HarmonyPatch(typeof(Screen), "SetResolution", new[] { typeof(int), typeof(int), typeof(bool), typeof(int) })]
    internal static class HarmonyPatchScreen
    {
        private static bool Prefix(Screen __instance, int width, int height, bool fullscreen, [Internal.DefaultValue("0")] int preferredRefreshRate)
        {
            Screen.SetResolution(width, height, (fullscreen) ? FullScreenMode.ExclusiveFullScreen : FullScreenMode.Windowed, preferredRefreshRate);

            return false;
        }
    }
}
