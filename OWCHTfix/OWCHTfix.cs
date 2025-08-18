using System.Reflection;
using HarmonyLib;
using OWML.Common;
using OWML.ModHelper;

namespace OWCHTfix
{
    public class OWCHTfix : ModBehaviour
    {
        public static OWCHTfix Instance;

        private void Start()
        {
            var api = ModHelper.Interaction.TryGetModApi<ILocalizationAPI>("xen.LocalizationUtility");
            api.RegisterLanguage(this, "ChineseFixed", "assets/Translation.xml");
            api.AddLanguageFont(this, "ChineseFixed", "assets/pingfanghk-semibold", "assets/pingfanghk-semibold.otf");
        }
    }
}
