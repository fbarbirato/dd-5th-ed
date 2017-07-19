using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DungeonsAndDragons.v1.Domain.Tests
{
    [TestClass]
    public class PlayerCharacterCreatorTests
    {
        [TestMethod]
        public void NewCharacter_Human_ShouldAdd1ToEveryAttribute()
        {
            // Arrange
            var creator = new PlayerCharacterCreator();
            var startingAbilities = new Abilities
            {
                Strength = 11,
                Dexterity = 13,
                Constitution = 15,
                Intelligence = 17,
                Wisdom = 18,
                Charisma = 9
            };

            // Act
            var character = creator.NewCharacter("Alaundo The Wise", RaceEnum.Human, ClassEnum.Wizard, startingAbilities);

            // Assert
            Assert.AreEqual(12, character.STR);
            Assert.AreEqual(14, character.DEX);
            Assert.AreEqual(16, character.CON);
            Assert.AreEqual(18, character.INT);
            Assert.AreEqual(19, character.WIS);
            Assert.AreEqual(10, character.CHA);
        }

        [TestMethod]
        public void NewCharacter_HillDwarf_ShouldAdd2ToCONAnd1ToWIS()
        {
            // Arrange
            var creator = new PlayerCharacterCreator();
            var startingAbilities = new Abilities
            {
                Strength = 15,
                Dexterity = 10,
                Constitution = 16,
                Intelligence = 11,
                Wisdom = 17,
                Charisma = 12
            };

            // Act
            var character = creator.NewCharacter("Bruenor", RaceEnum.HillDwarf, ClassEnum.Cleric, startingAbilities);

            // Assert
            Assert.AreEqual(15, character.STR);
            Assert.AreEqual(10, character.DEX);
            Assert.AreEqual(18, character.CON);
            Assert.AreEqual(11, character.INT);
            Assert.AreEqual(18, character.WIS);
            Assert.AreEqual(12, character.CHA);
        }

        [TestMethod]
        public void NewCharacter_WoodElf_ShouldAdd2ToDEXAnd1ToWIS()
        {
            // Arrange
            var creator = new PlayerCharacterCreator();
            var startingAbilities = new Abilities
            {
                Strength = 15,
                Dexterity = 17,
                Constitution = 16,
                Intelligence = 11,
                Wisdom = 17,
                Charisma = 12
            };

            // Act
            var character = creator.NewCharacter("Landal", RaceEnum.WoodElf, ClassEnum.Ranger, startingAbilities);

            // Assert
            Assert.AreEqual(15, character.STR);
            Assert.AreEqual(19, character.DEX);
            Assert.AreEqual(16, character.CON);
            Assert.AreEqual(11, character.INT);
            Assert.AreEqual(18, character.WIS);
            Assert.AreEqual(12, character.CHA);
        }

        [TestMethod]
        public void NewCharacter_Halfling_ShouldAdd2ToDEX()
        {
            // Arrange
            var creator = new PlayerCharacterCreator();
            var startingAbilities = new Abilities
            {
                Strength = 8,
                Dexterity = 17,
                Constitution = 9,
                Intelligence = 15,
                Wisdom = 13,
                Charisma = 14
            };

            // Act
            var character = creator.NewCharacter("Bilbo", RaceEnum.Halfling, ClassEnum.Rogue, startingAbilities);

            // Assert
            Assert.AreEqual(8, character.STR);
            Assert.AreEqual(19, character.DEX);
            Assert.AreEqual(9, character.CON);
            Assert.AreEqual(15, character.INT);
            Assert.AreEqual(13, character.WIS);
            Assert.AreEqual(14, character.CHA);
        }

        [TestMethod]
        [DataRow(RaceEnum.Human, ClassEnum.Fighter, 18, 14)]
        [DataRow(RaceEnum.Human, ClassEnum.Wizard, 10, 6)]
        [DataRow(RaceEnum.Human, ClassEnum.Ranger, 15, 13)]
        [DataRow(RaceEnum.WoodElf, ClassEnum.Cleric, 8, 7)]
        [DataRow(RaceEnum.HillDwarf, ClassEnum.Fighter, 18, 15)]
        [DataRow(RaceEnum.Halfling, ClassEnum.Rogue, 5, 3)]
        [DataRow(RaceEnum.Halfling, ClassEnum.Rogue, 10, 6)]
        [DataRow(RaceEnum.Human, ClassEnum.Fighter, 10, 10)]
        [DataRow(RaceEnum.WoodElf, ClassEnum.Wizard, 3, 2)]
        [DataRow(RaceEnum.WoodElf, ClassEnum.Wizard, 1, 1)]
        public void NewCharacter_GivenClassAndConstitution_ShouldStartWithExpectedHP(
            RaceEnum characterRace, 
            ClassEnum characterClass, 
            int constitution, 
            int expectedStartingHP)
        {
            // Arrange
            var creator = new PlayerCharacterCreator();
            var startingAbilities = new Abilities
            {
                Constitution = constitution,
            };

            // Act
            var character = creator.NewCharacter("Player Name", characterRace, characterClass, startingAbilities);

            // Assert
            Assert.AreEqual(expectedStartingHP, character.HP);
        }
    }
}
