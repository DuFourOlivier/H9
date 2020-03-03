using System;
using poketester;
namespace poketester
{
    class Program
    {
        static void Main(string[] args)
        {
            pokemon aPoke = new pokemon();
            Console.WriteLine("Geef naam:");
            aPoke.Naam = Console.ReadLine();
            Console.WriteLine("Geef hp:");
            aPoke.HP_Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef speed:");
            aPoke.Speed_Base = Convert.ToInt32(Console.ReadLine());

            

            aPoke.ShowInfo();

            Console.WriteLine("Tot welke level wilt u levelen?");
            int levels = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < levels; i++)
            {
                aPoke.Verhooglevel();
            }
            Console.WriteLine($"Na {levels} keer het level te verhogen:");
            aPoke.ShowInfo();
        }
    }
}
