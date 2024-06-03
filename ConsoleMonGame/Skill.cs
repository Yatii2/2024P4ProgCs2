namespace ConsoleMonGame
{
    internal class Skill
    {
        int damage;
        int energyCost;
        string name;

        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(energyCost);
            target.TakeDamage(damage);
        }
    }
}