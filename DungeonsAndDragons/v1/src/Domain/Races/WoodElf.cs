using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndDragons.v1.Domain.Races
{
    public class WoodElf : Elf
    {
        public override Abilities ApplyAbilityModifiersForSubrace(Abilities abilities)
        {
            abilities.Wisdom += 1;

            return abilities;
        }
    }
}
