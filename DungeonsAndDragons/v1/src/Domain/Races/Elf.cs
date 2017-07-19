using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndDragons.v1.Domain.Races
{
    public abstract class Elf : Race
    {
        public override Abilities ApplyAbilityModifiers(Abilities abilities)
        {
            abilities.Dexterity += 2;

            return ApplyAbilityModifiersFromSubrace(abilities);
        }

        public abstract Abilities ApplyAbilityModifiersFromSubrace(Abilities abilities);

        public override void ApplyTraits(PlayerCharacter playerCharacter)
        {
            ApplyTraitsFromSubrace(playerCharacter);
        }

        public abstract void ApplyTraitsFromSubrace(PlayerCharacter playerCharacter);
    }
}
