// ==== ./Source/DebugPatches.cs ====
using HarmonyLib;
using RimWorld;
using Verse;

namespace BetterRimworlds
{
    [HarmonyPatch(typeof(MainMenuDrawer), "DoMainMenuControls")]
    public static class Patch_MainMenuDrawer_Debug
    {
        private static bool _logged;

        public static void Prefix()
        {
            if (_logged)
                return;

            if (LanguageDatabase.activeLanguage?.folderName != RimworldBengaliMod.Language)
                return;

            _logged = true;

            if (RimworldBengaliMod.Bootstrap.LoadedFont == null)
            {
                Log.Warning(
                    $"[BetterRimworlds:{RimworldBengaliMod.Language}] " +
                    "DebugPatch: LoadedFont is null."
                );
                return;
            }

            Log.Message(
                $"[BetterRimworlds:{RimworldBengaliMod.Language}] DebugPatch: " +
                $"ActiveLanguage={LanguageDatabase.activeLanguage?.folderName}, " +
                $"Font={RimworldBengaliMod.Bootstrap.LoadedFont.name}, " +
                $"dynamic={RimworldBengaliMod.Bootstrap.LoadedFont.dynamic}"
            );
        }
    }
}