using RimWorld;
using UnityEngine;
using Verse;

namespace Pizzacat_MechanizedArmor
{
    public class MechanizedArmorModSettings : ModSettings
    {
        public TechLevel techLevel = TechLevel.Industrial;

        public override void ExposeData()
        {
            base.ExposeData();

            Scribe_Values.Look(ref techLevel, "techLevel", TechLevel.Industrial);
        }

        public void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listing_Standard = new Listing_Standard();
            listing_Standard.ColumnWidth = (inRect.width - 34f) / 2f;

            listing_Standard.Begin(inRect);

            listing_Standard.Label("Pizzacat_MechanizedArmor_Tech_Level_Label".Translate());
            if (listing_Standard.RadioButton_NewTemp("Pizzacat_MechanizedArmor_Tech_Level_Medieval_Label".Translate(), techLevel == TechLevel.Medieval, 8f))
                techLevel = TechLevel.Medieval;
            if (listing_Standard.RadioButton_NewTemp("Pizzacat_MechanizedArmor_Tech_Level_Industrial_Label".Translate(), techLevel == TechLevel.Industrial, 8f))
                techLevel = TechLevel.Industrial;

            listing_Standard.End();
        }

        public void UpdateSettings()
        {
            ResearchProjectDef researchProjectDef = DefDatabase<ResearchProjectDef>.GetNamed("Pizzacat_MechanizedArmor_Tech_Project_Name".Translate());

            if (researchProjectDef != null)
            {
                researchProjectDef.techLevel = techLevel;
            }
        }
    }
}
