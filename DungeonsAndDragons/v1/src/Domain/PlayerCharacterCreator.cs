using DungeonsAndDragons.v1.Domain.Classes;
using DungeonsAndDragons.v1.Domain.Races;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndDragons.v1.Domain
{
    public class PlayerCharacterCreator
    {
        private PlayerCharacter Current { get; set; }

        public PlayerCharacter NewCharacter(string name, RaceEnum race, ClassEnum characterClass, Abilities startingAbilities)
        {
            var newCharacter = new PlayerCharacter();
            newCharacter.Name = name;
            newCharacter.Race = GetRace(race);
            newCharacter.Class = GetClass(characterClass);

            newCharacter.SetStartingAbilities(startingAbilities);
            newCharacter.SetStartingHP();

            return newCharacter;
        }

        private Class GetClass(ClassEnum characterClass)
        {
            switch (characterClass)
            {
                case ClassEnum.Fighter:
                    return new Fighter();
                case ClassEnum.Cleric:
                    return new Cleric();
                case ClassEnum.Wizard:
                    return new Wizard();
                default:
                    throw new InvalidOperationException("Class not defined");
            }
        }

        private Race GetRace(RaceEnum race)
        {
            switch (race)
            {
                case RaceEnum.Human:
                    return new Human();
                case RaceEnum.Dwarf:
                    return new Dwarf();
                default :
                    throw new InvalidOperationException("Race not defined");
            }
        }
    }
}
