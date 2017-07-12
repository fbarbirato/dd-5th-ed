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
        public void NewCharacter_Con18_ShouldStartWith14HP()
        {
            // Arrange
            var creator = new PlayerCharacterCreator();
            var startingAbilities = new Abilities
            {
                Constitution = 18,
            };

            // Act
            var character = creator.NewCharacter("Wulfgar", RaceEnum.Human, ClassEnum.Fighter, startingAbilities);

            // Assert
            Assert.AreEqual(14, character.HP);
        }
    }
}
