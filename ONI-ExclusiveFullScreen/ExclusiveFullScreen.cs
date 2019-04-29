
using Harmony;
using UnityEngine;

namespace ONI_ExclusiveFullScreen
{

    [HarmonyPatch(typeof(Screen), "SetResolution", new[] { typeof(int), typeof(int), typeof(bool), typeof(int) })]
    internal static class ExclusiveFullScreen
    {
        static void Prefix(Screen __instance, int width, int height, bool fullscreen, int preferredRefreshRate)
        {
            Screen.SetResolution(width, height, fullscreen ? FullScreenMode.ExclusiveFullScreen : FullScreenMode.Windowed, preferredRefreshRate);
        }
    }
}
