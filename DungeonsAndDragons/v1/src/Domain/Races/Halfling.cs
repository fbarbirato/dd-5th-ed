using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndDragons.v1.Domain.Races
{
    public class Halfling : Race
    {
        public override Abilities ApplyAbilityModifiers(Abilities abilities)
        {
            abilities.Dexterity += 2;
            return abilities;
        }
    }
}
