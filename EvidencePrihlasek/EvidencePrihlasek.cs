using System;
using System.Collections.Generic;
using System.Text;

namespace StredoskolskePrihlasky
{
    class EvidencePrihlasek
    {
        public List<StudijniObor>Obory { get; private set; }
        public List<Prihlaska>Prihlasky { get; private set; }

        public EvidencePrihlasek(List<StudijniObor>obory)
        {
            Obory = obory;
            Prihlasky = new List<Prihlaska>();
        }

        public void VytvoritPrihlasku()
        {
            try
            {
                Console.WriteLine("\nNOVA PRIHLASKA");
                Console.Write("\tJmeno: ");
                string jmeno = Console.ReadLine();
                Console.Write("\tPrijmeni: ");
                string prijmeni = Console.ReadLine();
                Console.Write("\tDatum narozeni(rok): ");
                int datumRok = int.Parse(Console.ReadLine());
                Console.Write("\t Datum narozeni(měsíc): ");
                int datumMesic = int.Parse(Console.ReadLine());
                Console.Write("\tDatum narozeni (den): ");
                int datumDen = int.Parse(Console.ReadLine());


                StudijniObor obor = VybratObor();
                DateTime datumNarozeni = new DateTime(datumRok, datumMesic, datumDen);

                //ověření, zda přihláška se stejnnými údaji už existuje
                if (!ExistujePrihlaska(jmeno, prijmeni, datumNarozeni, obor))
                {
                    Prihlasky.Add(new Prihlaska(jmeno, prijmeni, datumNarozeni, obor));
                    Console.WriteLine("Prihlaska byla uspesne vytvorena. ");
                }
                else
                {
                    Console.WriteLine("Prihlaska se zadanymi udaji jiz existuje");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Došlo k chybě při vytvareni prihlasky.");
                Console.WriteLine("Text chyby: {0}", e.Message);
            }

        }

        public StudijniObor VybratObor()
        {
            Console.WriteLine("\tVyberte studijni obor: ");
            StudijniObor obor = null;
            for (int i=0; i < Obory.Count; i++)
            {
                Console.WriteLine($"\t\t{i + 1}. {Obory[i].Nazev} ");
            }
            obor = Obory[int.Parse(Console.ReadLine())-1];
            return obor;
        }

        private bool ExistujePrihlaska(string jmeno, string prijmeni, DateTime datumNarozeni, StudijniObor obor)
        {
            foreach (Prihlaska prihlaska in Prihlasky )
            {
                if (prihlaska.Jmeno == jmeno && prihlaska.Prijmeni == prijmeni && prihlaska.DatumNarozeni == datumNarozeni && prihlaska.Obor == obor)
                {
                    return true;
                }
                else
                    return false;
            }
            return false;
        }

        public Prihlaska VyhledejPrihlasku(string kod)
        {
            foreach (Prihlaska prihlaska in Prihlasky)
            {
                if (prihlaska.Kod == kod)
                { return prihlaska; }
                
            }
            return null;
        }

        public List<Prihlaska> VyhledejPrihlasku(StudijniObor obor)
        {
            List<Prihlaska> nalezenePRihlasky = new List<Prihlaska>();
            foreach (Prihlaska prihlaska in Prihlasky)
            {
                if (prihlaska.Obor == obor)
                {
                    nalezenePRihlasky.Add(prihlaska);
                }
            }
            return nalezenePRihlasky;
        }
    }
}
