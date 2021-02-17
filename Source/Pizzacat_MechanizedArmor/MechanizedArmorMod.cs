using UnityEngine;
using RimWorld;
using Verse;

namespace Pizzacat_MechanizedArmor
{
    public class MechanizedArmorMod : Mod
    {
        private static MechanizedArmorMod _instance;
        public static MechanizedArmorMod Instance => _instance;

        public static MechanizedArmorModSettings settings;

        public MechanizedArmorMod(ModContentPack content) : base(content)
        {
            _instance = this;
            settings = GetSettings<MechanizedArmorModSettings>();
        }

        public override string SettingsCategory()
        {
            return "Mechanized Armor";
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {
            base.DoSettingsWindowContents(inRect);
            settings.DoSettingsWindowContents(inRect);
        }

        public override void WriteSettings()
        {
            base.WriteSettings();
            settings.UpdateSettings();
        }
    }
}
