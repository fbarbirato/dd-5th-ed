using DungeonsAndDragons.v1.Domain.Races;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndDragons.v1.Domain
{
    public class PlayerCharacterCreator
    {
        private PlayerCharacter Current { get; set; }

        public PlayerCharacter NewCharacter(string name, RaceEnum race)
        {
            var newCharacter = new PlayerCharacter
            {
                Name = name,
                Race = GetRace(race)
            };

            return newCharacter;
        }

        private Race GetRace(RaceEnum race)
        {
            switch (race)
            {
                case RaceEnum.Human :
                    return new Human();
                default :
                    throw new InvalidOperationException();
            }
        }
    }
}
