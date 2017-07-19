namespace DungeonsAndDragons.v1.Domain.Races
{
    public abstract class Dwarf : Race
    {
        public override Abilities ApplyAbilityModifiers(Abilities abilities)
        {
            abilities.Constitution += 2;

            return ApplyAbilityModifiersForSubrace(abilities);
        }

        public abstract Abilities ApplyAbilityModifiersForSubrace(Abilities abilities);
    }
}