﻿using System.Linq.Expressions;

namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        internal int health;
        internal int energy;
        internal string name;

        internal Element weakness;
        internal void TakeDamage(int damage)
        {
            health -= damage;
        }
        internal void DepleteEnergy(int energy)
        {
            this.energy = energy;
        }
        private List<Skill> skills = new List<Skill>();
    }
}