﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndDragons.v1.Domain.Races
{
    public class WoodElf : Elf
    {
        public override Abilities ApplyAbilityModifiersFromSubrace(Abilities abilities)
        {
            abilities.Wisdom += 1;

            return abilities;
        }

        public override void ApplyTraitsFromSubrace(PlayerCharacter playerCharacter)
        {
        }
    }
}
