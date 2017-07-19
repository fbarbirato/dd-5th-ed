using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndDragons.v1.Domain.Races
{
    public class Human : Race
    {
        public override Abilities ApplyAbilityModifiers(Abilities abilities)
        {
            abilities.Strength += 1;
            abilities.Dexterity += 1;
            abilities.Constitution += 1;
            abilities.Intelligence += 1;
            abilities.Wisdom += 1;
            abilities.Charisma += 1;

            return abilities;
        }

        public override void ApplyTraits(PlayerCharacter playerCharacter)
        {
        }
    }
}
