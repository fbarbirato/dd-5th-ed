using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndDragons.v1.Domain
{
    public abstract class Race
    {
        public abstract Abilities ApplyAbilityModifiers(Abilities abilities);

        public abstract void ApplyTraits(PlayerCharacter playerCharacter);
    }
}
