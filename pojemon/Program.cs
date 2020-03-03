using pokémon;
using System;

namespace pojemon
{
    class Program
    {
        static void Main(string[] args)
        {
            pokemon poke1 = new pokemon();
            pokemon poke2 = new pokemon();

            poke1.Naam = "Bulbasaur";
            poke1.HP_Base = 45;
            poke1.Attack_Base = 49;
            poke1.Defense_Base = 49;
            poke1.SpecialAttack_Base = 65;
            poke1.SpecialDefense_Base = 65;
            poke1.Speed_Base = 45;


            poke2.Naam = "Charmander";
            poke2.HP_Base = 39;
            poke2.Attack_Base = 52;
            poke2.Defense_Base = 43;
            poke2.SpecialAttack_Base = 60;
            poke2.SpecialDefense_Base = 50;
            poke2.Speed_Base = 65;
            for (int i = 0; i < 5; i++)
            {
                poke2.Verhooglevel();

            }
           

            /*Console.WriteLine($"Bulbasaur heeft een average:{poke1.Average} en een total van {poke1.Total}");
            Console.WriteLine($"Charmander is nu level {poke2.Level} en heeft een average:{poke2.Average} en een total van {poke2.Total} en full stat HP{poke2.HP_Full}");*/
            poke2.ShowInfo();
        }
    }
}
