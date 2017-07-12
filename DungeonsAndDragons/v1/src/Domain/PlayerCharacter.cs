using System;

namespace DungeonsAndDragons.v1.Domain
{
    public class PlayerCharacter
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int STR { get { return Abilities.Strength; } }
        public int DEX { get { return Abilities.Dexterity; } }
        public int CON { get { return Abilities.Constitution; } }
        public int INT { get { return Abilities.Intelligence; } }
        public int WIS { get { return Abilities.Wisdom; } }
        public int CHA { get { return Abilities.Charisma; } }

        public int Level { get; set; }
        public int HP { get; set; }

        public Race Race { get; set; }
        public Class Class { get; set; }
        public Inventory Inventory { get; set; }

        public Abilities Abilities { get; set; }

        internal void SetStartingAbilities(Abilities startingAbilities)
        {
            Abilities = Race.ApplyAbilityModifiers(startingAbilities);
        }

        internal void SetStartingHP()
        {
            HP = GetStartingHitPoints();
        }

        internal int GetStartingHitPoints()
        {
            return Convert.ToInt32(Class.HitDie) + CalculateAbilityModifier(CON);
        }

        private int CalculateAbilityModifier(int abilityScore)
        {
            return (abilityScore - 10) / 2;
        }
    }
}
