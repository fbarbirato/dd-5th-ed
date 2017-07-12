using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DungeonsAndDragons.v1.Domain.Classes;

namespace DungeonsAndDragons.v1.Domain.Tests
{
    [TestClass]
    public class PlayerCharacterTests
    {
        [TestMethod]
        public void GetMaxHitPoints_FighterWithCon18_Returns14()
        {
            // Arrange
            var character = new PlayerCharacter();
            character.Class = new Fighter();
            character.Constitution = 18;

            // Act
            var hp = character.GetStartingHitPoints();

            // Assert
            Assert.AreEqual(14, hp);
        }
    }
}
