namespace DungeonsAndDragons.v1.Domain.Races
{
    public class Dwarf : Race
    {
        public override Abilities ApplyAbilityModifiers(Abilities abilities)
        {
            abilities.Constitution += 2;

            return abilities;
        }
    }
}