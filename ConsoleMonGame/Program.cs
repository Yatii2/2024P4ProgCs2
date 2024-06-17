namespace ConsoleMonGame
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ConsoleMon Console = new ConsoleMon();
            Skill skill = new Skill();
            TestConsoleMonFunctions();
            TestFactoryFunctions();
        }
        static void TestConsoleMonFunctions()
        {
            Console.WriteLine("TestConsoleMonFunctions");
            ConsoleMon mon = new ConsoleMon();
            mon.TakeDamage(100);
            mon.DepleteEnergy(20);

            Console.WriteLine(mon.health == -100);

            Console.WriteLine(mon.energy == -20);
        }

        static void TestFactoryFunctions()
        {
            Console.WriteLine("TestFactoryFunctions");
            ConsoleMonFactory factory = new ConsoleMonFactory();
            factory.Load("monsterdata.txt");
        }


    }
}
