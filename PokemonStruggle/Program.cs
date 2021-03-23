using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace Arena
{
    class Program
    {
        static void Main(string[] args)
        {

            Cube cube = new Cube(10);
            Pokemon Rattata = new Pokemon("Rattata", 120, 20, 10, cube);
            Pokemon Gastly = new GhostPsychic("Gastly", 60, 20, 15, cube, 30, 45);

            Arena arena = new Arena(Rattata, Gastly, cube);
           

            //zápas
            arena.Struggle();
            Console.ReadKey();

        }
    }
}
