using System;
using System.Collections.Generic;
using System.Text;

namespace StredoskolskePrihlasky
{
    class Prihlaska
    {

        // celkový počet vytvořených objektů typu Přihláška
        private static int vytvorenoPrihlasek = 0;


        public string Kod { get; private set; }
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }
        public DateTime DatumNarozeni { get; private set; }
        public StudijniObor Obor { get; private set; }

        public Prihlaska(string jmeno, string prijmeni, DateTime datumNarozeni, StudijniObor obor)
        {
            vytvorenoPrihlasek++;
            Kod = String.Format($"Prihlaska_{vytvorenoPrihlasek}");

            Jmeno = jmeno;
            Prijmeni = prijmeni;
            DatumNarozeni = datumNarozeni;
            Obor = obor;
        }

        public void VypisInformace()
        {
            Console.WriteLine($"PRIHLASKA - {Jmeno} {Prijmeni}");
            Console.WriteLine($"Datum narozeni: {DatumNarozeni.Year} {DatumNarozeni.Month}. {DatumNarozeni.Day}.");
            Console.WriteLine($"Obor: {Obor.Nazev}");
            Console.WriteLine($"Kod: {Kod}");
        }

        
    }
    
}
