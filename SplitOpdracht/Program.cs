using System;
using System.IO;

namespace SplitOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string content = File.ReadAllText("stringsplit.txt");

           
            string[] keyvalue = content.Split(':');

         
            Console.WriteLine("Key: " + keyvalue[0]);
            Console.WriteLine("Value: " + keyvalue[1]);

          
            string[] cijfersPerVak = keyvalue[1].Split(',');

    
            foreach (string vak in cijfersPerVak)
            {
                Console.WriteLine(vak);
            }
        }
    }
}
