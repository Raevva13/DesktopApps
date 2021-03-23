using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace StredoskolskePrihlasky
{
    class Program
    {
        static void Main(string[] args)
        {



            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader("studenti.txt");
                Console.WriteLine("Obsah souboru: ");
                string radek = "";
                while ((radek = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(radek);
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Došlo k neocekavane exception: {0}", e.Message);
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }












            //připravíme si testovací data - studijní obory
            List<StudijniObor> obory = new List<StudijniObor>();
            obory.Add(new StudijniObor(" Informační technologie"));
            obory.Add(new StudijniObor("Strojirenstvi"));
            obory.Add(new StudijniObor("Elektrotechnika"));

            EvidencePrihlasek evidence = new EvidencePrihlasek(obory);

            //main menu aplikace
            int volbaHlavniMenu = 0;
            do
            {
                try
                {
                    //vypis hlavniho menu palikace
                    Console.WriteLine("\n\nHLAVNI MENU");
                    Console.WriteLine("\t1. Nova prihlaska");
                    Console.WriteLine("\t2. Vyhledavani prihlasky");
                    Console.WriteLine("\t3. Vypis prihlasek");
                    Console.WriteLine("\t4. Konec programu");
                    Console.Write("\tVaše volba: ");
                    volbaHlavniMenu = int.Parse(Console.ReadLine());
                    //vyberte možnost
                    switch (volbaHlavniMenu)
                    {
                        //create nove prihlasky
                        case 1:
                            evidence.VytvoritPrihlasku();
                            break;
                        // vyhledávání přihlášek dle kodu
                        case 2:
                            Console.WriteLine("Zadejte kod hledane prihlasky: ");
                            string kod = Console.ReadLine();
                            Prihlaska prihlaska = evidence.VyhledejPrihlasku(kod);
                            if (prihlaska != null)
                            {
                                Console.WriteLine("Prihlaska nalezena: ");
                                prihlaska.VypisInformace();
                            }
                            else
                            {
                                Console.WriteLine($"Prihlaska s kodem {kod} nebyla nalezena");
                            }
                            break;

                        case 3:
                            //vypis prihlasek podle studijniho oboru
                            StudijniObor obor = evidence.VybratObor();
                            List<Prihlaska> prihlasky = evidence.VyhledejPrihlasku(obor);
                            if (prihlasky.Count > 0)
                            {
                                foreach (Prihlaska p in prihlasky)
                                {
                                    Console.WriteLine("NALEZENE PRIHLASKY");
                                    p.VypisInformace();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nebyly nalezeny zadne prihlasky");
                            }

                            break;

                        // Aplikace bude ukoncena, neprovede se zadna operace

                        case 4:
                            break;

                        default:
                            Console.WriteLine("Neznama volba");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Došlo k chybě při volbě možnosti z menu.");
                    Console.WriteLine("Text chyby: {0}", e.Message);
                    volbaHlavniMenu = 0;
                }
                //volba ukončení programu
            } while (volbaHlavniMenu != 4);









        }
    }
}
