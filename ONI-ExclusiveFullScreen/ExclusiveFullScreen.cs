
using Harmony;

using UnityEngine;
using UnityEngine.Internal;

namespace ONI_ExclusiveFullScreen
{

    [HarmonyPatch(typeof(Screen), "SetResolution", new[] { typeof(int), typeof(int), typeof(bool), typeof(int) })]
    internal static class ExclusiveFullScreen
    {
        private static void Prefix(Screen __instance, int width, int height, bool fullscreen, [DefaultValue("0")] int preferredRefreshRate)
        {
            Debug.Log(" === ExclusiveFullScreen === ");

            Screen.SetResolution(width, height, (!fullscreen) ? FullScreenMode.Windowed : FullScreenMode.ExclusiveFullScreen, preferredRefreshRate);
        }
    }
}
