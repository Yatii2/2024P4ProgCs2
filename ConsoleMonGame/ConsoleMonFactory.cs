using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class ConsoleMonFactory
    {
        internal void Load(string datafile)
        {
            // Laad de file in en lees alle regels
            string[] lines = File.ReadAllLines(datafile);

            // Schrijf alle regels naar de console
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
