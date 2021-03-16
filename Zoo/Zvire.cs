using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Zvire
    {
        public string Nazev { get; set; }
        public int Vek { get; set; }
        public double Vaha { get; set; }

        //public string nazev;
        //public int vek;
        //public double vaha;

        public Zvire(string nazev, int vek, double vaha )
        {
            Nazev = nazev;
            Vek = vek;
            Vaha = vaha;
        }

        public void VypisPopis()
        {
            Console.WriteLine("Nazev: {0}", Nazev);
            Console.WriteLine("Vek: {0}", Vek);
            Console.WriteLine("Vaha: {0}", Vaha);



        }


    }
}
