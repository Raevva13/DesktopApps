using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class ZOO
    {
   
        private List<Zvire> zvirata;

        public ZOO()
        {
            zvirata = new List<Zvire>();
        }

        public void PridatZvire()
        {
            Console.WriteLine("ZADANI NOVEHO ZVIRETE");
            Console.Write("Nazev: ");
            string nazev = Console.ReadLine();
            Console.Write("Vek: ");
            int vek = int.Parse(Console.ReadLine());
            Console.Write("Vaha: ");
            double vaha = int.Parse(Console.ReadLine());

            Zvire zvire = new Zvire(nazev, vek, vaha);

            zvirata.Add(zvire);
        }
        public void VypisZvirat()
        {
            Console.WriteLine("VYPIS ZVIRAT");
            foreach (Zvire zvire in zvirata)
            {
                zvire.VypisPopis();
            }
        }

        public void SmazatZvire()
        {
            Console.WriteLine("SMAZANI ZVIRETE");
            int indexKeSmazani = VybratIndexZvirete();
            if (indexKeSmazani >= 0 )
            {

                Console.WriteLine("Zvire: {0} smazano. ", zvirata[indexKeSmazani].Nazev);
            }
            
        }

        public int VybratIndexZvirete()
        {
            for (int i = 0; i < zvirata.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, zvirata[i].Nazev);
            }
            Console.Write("Poradove cislo pro smazani: ");
            int index = int.Parse(Console.ReadLine()) - 1;
            if (index >= 0 && index < zvirata.Count)
            {
                return index;
            }
            else
            {
                Console.WriteLine("Spatne poradove cislo.");
                return -1;
            }
        }
        public void UpravitZvire()
        {
            Console.WriteLine("UPRAVA ZVIRETE");
            int indexUpravit = VybratIndexZvirete();
            if (indexUpravit >= 0)
            {
                Zvire zvire = zvirata[indexUpravit];
                Console.WriteLine("Aktualni nazev: {0}\n Chcete upravit? A/N", zvire.Nazev);
                if (Console.ReadLine().ToLower() == "a")
                {
                    Console.Write("Novy nazev: ");
                    zvire.Nazev = Console.ReadLine();
                }
                Console.WriteLine("Aktualni vek: {0}\n Chcete upravit? A/N", zvire.Vek);
                if (Console.ReadLine().ToLower()=="a")
                {
                    Console.Write("Novy vek: ");
                    zvire.Vek = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Aktualni vaha: {0}\n Chcete upravit? A/N", zvire.Vaha);
                if(Console.ReadLine().ToLower()== "a")
                {
                    Console.Write(" Nova vaha: ");
                    zvire.Vaha = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("Uprava dkoncena");

            }
        }

        //private List<Zamestnanec> zamestnanci;
        //public ZOO()
        //{
        //    zamestnanci = new List<Zamestnanci>();
        //}

        //public void PridatZamestnance()
        //{
        //    Console.WriteLine("ZADANI NOVEHO ZAMESTNANCE ");
        //    Console.Write("Jmeno: ");
        //    string jmeno = Console.ReadLine();
        //    Console.Write("Prijmeni: ");
        //    string prijmeni = Console.ReadLine();
        //    Console.Write("Datum narozeni: ");
        //    DateTime datumNarozeni = DateTime.Parse(Console.ReadLine());
        //    Console.Write("Plat: ");
        //    int plat = int.Parse(Console.ReadLine());
        //    Console.Write("Nazev pozice: ");
        //    string nazevPozice = Console.ReadLine();
        //}


       


    }
}

        
        

