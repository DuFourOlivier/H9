using pokémon;
using System;

namespace pojemon
{
    class Program
    {
        static void Main(string[] args)
        {
            pokemon Bulbasaur = new pokemon();
            pokemon Charmander = new pokemon();
            

            Bulbasaur.HP_Base = 45;
            Bulbasaur.Attack_Base = 49;
            Bulbasaur.Defense_Base = 49;
            Bulbasaur.SpecialAttack_Base = 65;
            Bulbasaur.SpecialDefense_Base = 65;
            Bulbasaur.Speed_Base = 45;
           


            Charmander.HP_Base = 39;
            Charmander.Attack_Base = 52;
            Charmander.Defense_Base = 43;
            Charmander.SpecialAttack_Base = 60;
            Charmander.SpecialDefense_Base = 50;
            Charmander.Speed_Base = 65;

            Console.WriteLine($"Bulbasaur heeft een average:{Bulbasaur.Average} en een total van {Bulbasaur.Total}");
            Console.WriteLine($"Charmander heeft een average:{Charmander.Average} en een total van {Charmander.Total}");
        }
    }
}
