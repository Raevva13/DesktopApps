using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;



namespace Arena
{
    /// <summary>
    /// Třída reprezentuje hrací kostku
    /// </summary>
    class Cube
    {
        /// <summary>
        /// Generátor náhodných čísel
        /// </summary>
        private Random random;
        /// <summary>
        /// Počet stěn kostky
        /// </summary>
        private int numberOfWalles;
        public Cube()
        {
            numberOfWalles = 6;
            random = new Random();
        }
        public Cube(int numberOfWalles)
        {
            this.numberOfWalles = numberOfWalles;
            random = new Random();
        }
        public int ReturnNumberOfWalles()
        {
            return numberOfWalles;
        }


        /// <summary>
        /// Vykoná hod kostkou
        /// </summary>
        /// <returns>Číslo od 1 do počtu stěn</returns>
        public int Toss()
        {
            return random.Next(1, numberOfWalles + 1);
        }

        /// <summary>
        /// Vrací textovou reprezentaci kostky
        /// </summary>
        /// <returns>Textová reprezentace kostky</returns>
        public override string ToString()
        {
            return String.Format("Kostka s {0} stěnami", numberOfWalles);
        }

    }

}
