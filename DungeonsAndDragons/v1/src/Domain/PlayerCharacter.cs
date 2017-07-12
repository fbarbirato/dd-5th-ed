using System;

namespace DungeonsAndDragons.v1.Domain
{
    public class PlayerCharacter
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public int Level { get; set; }

        public Race Race { get; set; }
        public Class Class { get; set; }
        public Inventory Inventory { get; set; }

        public int GetStartingHitPoints()
        {
            return Convert.ToInt32(Class.HitDie) + CalculateModifier(Constitution);
        }

        private int CalculateModifier(int attribute)
        {
            return (attribute - 10) / 2;
        }
    }
}
