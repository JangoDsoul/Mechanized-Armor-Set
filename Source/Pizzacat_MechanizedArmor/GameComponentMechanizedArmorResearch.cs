using RimWorld;
using UnityEngine;
using Verse;

namespace Pizzacat_MechanizedArmor
{
    public class GameComponentMechanizedArmorResearch : GameComponent
    {
        public GameComponentMechanizedArmorResearch(Game game)
        {

        }

        public override void StartedNewGame()
        {
            base.StartedNewGame();

            SetResearchValue();
        }

        public override void LoadedGame()
        {
            base.LoadedGame();

            SetResearchValue();
        }

        private void SetResearchValue()
        {
            MechanizedArmorMod.settings.UpdateSettings();
        }
    }
}
