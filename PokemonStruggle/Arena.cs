using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace Arena
{
    class Arena
    {
        private Pokemon pokemon1;
        private Pokemon pokemon2;
        private Cube cube;

        public Arena(Pokemon pokemon1, Pokemon pokemon2, Cube cube)
        {
            this.pokemon1 = pokemon1;
            this.pokemon2 = pokemon2;
            this.cube = cube;
        }

        private void Drawn()
        {
            Console.Clear();
            Console.WriteLine("______________________ Aréna ______________________\n");
            Console.WriteLine("Pokemoni: :\n");
            WritePokemon(pokemon1);
            Console.WriteLine();
            WritePokemon(pokemon2);
            Console.WriteLine();
            //Console.WriteLine($"{pokemon1}, {pokemon1.GraphicLife()}");
            //Console.WriteLine($"{pokemon2}, {pokemon2.GraphicLife()}");
        }

        private void WritePokemon(Pokemon p)
        {
            Console.WriteLine(p);
            Console.Write("Život: ");
            Console.WriteLine(p.GraphicLife());
            if (p is GhostPsychic)
            {
                Console.Write("Mana: ");
                Console.WriteLine(((GhostPsychic)p).GraphicMana());
            }
        }


        private void WriteAMessage(string message)
        {
            Console.WriteLine(message);
            Thread.Sleep(600);
        }

        public void Struggle()
        {


            Pokemon p1 = pokemon1;
            Pokemon p2 = pokemon2;
            Console.WriteLine("Vítejte v aréně ");
            Console.WriteLine($"Dnes se utkají {pokemon1} proti {pokemon2}\n");

            bool beginPokemon2 = (cube.Toss() <= cube.ReturnNumberOfWalles()/2);
            if (beginPokemon2)
            {
                p1 = pokemon2;
                p2 = pokemon1;
            }
            Console.WriteLine($"Začínat bude pokemon {p1}. \nZápas může začát.");
            Console.ReadKey();

            //cyklus s bojem do konce

               while (p1.Alive() && p2.Alive())
               {
                pokemon1.Offensive(pokemon2);
                Drawn();
                WriteAMessage(p1.ReturnLastMessage()); //zpráva o útoku
                WriteAMessage(p2.ReturnLastMessage()); // zpráva o obraně
                    if (p2.Alive())
                {
                    p2.Offensive(pokemon1);
                    Drawn();
                    WriteAMessage(p2.ReturnLastMessage()); // zpráva o útoku
                    WriteAMessage(p1.ReturnLastMessage()); // zpráva o obraně
                }


                Console.WriteLine();

               }

        }




    }
}
