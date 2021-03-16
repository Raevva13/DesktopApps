using System;

namespace Obsahy
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vitejte v matematicke aplikaci, vyberte obrazec, jehiz obsah chcete vypocitat\nVyberte prosim moznost od 1. 3.");
            Console.WriteLine("1. obsah ctverce");
            Console.WriteLine("2. obsah obdelniku");
            Console.WriteLine("3. obsah kruhu");
            Console.WriteLine("4. obsah trojuhelniku");




            int vybranaMoznost = int.Parse(Console.ReadLine());

            switch (vybranaMoznost)
            {
                case 1:
                    Console.WriteLine("VYPOCET OBSAHU CTVERCE \nZadejte delku strany: ");
                    double delkastrany = double.Parse(Console.ReadLine());
                    double obsahCtvr = ObsahCtverce(delkastrany);
                    Console.WriteLine("obsah ctverce o delce strany {0} je: {1} cm. ", delkastrany, obsahCtvr);
                    break;
                case 2:
                    Console.WriteLine("\nVYPOCET OBSAHU OBDELNIKU\nZadejte delku jedne strany: ");
                    double jednastrana = double.Parse(Console.ReadLine());
                    Console.Write("zadejte delku druhe strany: ");
                    double druhastrana = double.Parse(Console.ReadLine());
                    double obsahObd = ObsahObdelniku(jednastrana, druhastrana);
                    Console.WriteLine("obsah obdelniku o delce stran {0} a {1} je  {2}", jednastrana, druhastrana, obsahObd);
                    break;
                case 3:
                    Console.WriteLine("\nVYPOCET OBSAHU KRUHU\nZadejde polomer: ");
                    double polomerKruhu = double.Parse(Console.ReadLine());
                    double obsahKrh = ObsahKruhu(polomerKruhu);
                    Console.WriteLine("Obsah kruhu o polomeru {0} je {1}", polomerKruhu, obsahKrh);
                    break;
                default:
                    Console.WriteLine("Neznama moznost");
                    break;
                case 4:
                    Console.WriteLine("\nVYPOCET OBSAHU TROJUHELNIKU\nZadejte delku strany: ");
                    double spodniStrana = double.Parse(Console.ReadLine());
                    Console.WriteLine("Zadejte vysku trojuhelniku: ");
                    double vyskaTroj = double.Parse(Console.ReadLine());
                    double obsahTroj = ObsahTrojuhelniku(spodniStrana, vyskaTroj);
                    Console.WriteLine("Obsah trojuhelniku o delce spodni casti {0} a vysce trojuhelniku {1} je {2}", spodniStrana, vyskaTroj, obsahTroj);
                    break;

            }


            Console.ReadKey();
        }

        static double ObsahCtverce(double strana)
        {
            if (strana == 0)
            {
                Console.WriteLine("Je nam lito, takovyto obrazec neexistuje");
            }

            return strana * strana;
        }

        static double ObsahObdelniku(double stranaA, double stranaB)
        {
            if (stranaA == 0 || stranaB == 0)
            {
                Console.WriteLine("Je nám líto, takovýto obrzec bohužel neexistuje");
            }
            return stranaA * stranaB;
        }


        static double ObsahKruhu(double polomer)
        {
            if (polomer == 0)
            {
                Console.WriteLine("Je nam lito, kruh o polomeru 0 nemuze existovat");
            }
            return (Math.PI * Math.Pow(polomer, 2));
        }

        static double ObsahTrojuhelniku(double delkaStrany, double vyskaTroj)
        {
            if (delkaStrany == 0 || vyskaTroj == 0)
            {
                Console.WriteLine("Je nam lito tento obrazec neexistuje");
            }
            return (delkaStrany * vyskaTroj) / 2;
        }
    }
}
