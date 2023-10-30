using Il2Cpp;
using MelonLoader;
using HarmonyLib;

namespace NoMoreCabinFever
{
    class Implementation : MelonMod
    {
        public override void OnInitializeMelon()
        {
            //...
        }

        [HarmonyPatch(typeof(CabinFever), nameof(CabinFever.UpdateCabinFeverTimeTracker))]
        internal class CabinFever_UpdateCabinFeverTimeTracker
        {
            public static void Prefix(ref CabinFever __instance)
            {
                __instance.CabinFeverEnd();
                __instance.ClearCabinFeverRisk();
            }
        }
    }
}