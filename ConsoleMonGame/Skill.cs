﻿namespace ConsoleMonGame
{
    internal class Skill
    {
        int damage;
        int energyCost;
        string name;

        internal Element element;
        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(energyCost);
            target.TakeDamage(damage);

            if (target.weakness == element)
            {
                target.TakeDamage(damage / 2);
            }
        }

    }
}