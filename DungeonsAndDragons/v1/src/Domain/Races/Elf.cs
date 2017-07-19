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

            return ApplyAbilityModifiersForSubrace(abilities);
        }

        public abstract Abilities ApplyAbilityModifiersForSubrace(Abilities abilities);
    }
}
