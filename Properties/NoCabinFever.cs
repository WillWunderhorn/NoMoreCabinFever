using MelonLoader;

namespace NoMoreCabinFever
{

    public class NoCabinFever : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Original mod by: " + BuildInfo.OriginalAuthor + " Recreated by: " + BuildInfo.ModAuthor);
        }
    }
}
