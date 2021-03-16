using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            ZOO zoo = new ZOO();
            int volbaMenu = 0;

                    do
                    {
                        Console.WriteLine("HLAVNI MENU EVIDENCE ZVIRAT");
                        Console.WriteLine("\t 1. Pridat zvire");
                        Console.WriteLine("\t 2. Vypsat zvirata");
                        Console.WriteLine("\t 3. Smazat zvire");
                        Console.WriteLine("\t 4. Upravit zvire");
                        Console.WriteLine("\t 5. Ukoncit program");
                        volbaMenu = int.Parse(Console.ReadLine());
                        switch (volbaMenu)
                        {
                            case 1:
                                zoo.PridatZvire();
                                break;

                            case 2:
                                zoo.VypisZvirat();
                                break;

                            case 3:
                                zoo.SmazatZvire();
                                break;

                            case 4:
                                zoo.UpravitZvire();
                                break;


                        }
                    }
                    while (volbaMenu != 5);
              


              











        }

        //switch (volbaMenu)
        //{
        //    case 1:
        //        Console.WriteLine("Vybrali jste evidenci zvirat");
        //do
        //{
        //    Console.WriteLine("HLAVNI MENU");
        //    Console.WriteLine("\t 1. Pridat zvire");
        //    Console.WriteLine("\t 2. Vypsat zvirata");
        //    Console.WriteLine("\t 3. Smazat zvire");
        //    Console.WriteLine("\t 4. Upravit zvire");
        //    Console.WriteLine("\t 5. Ukoncit program");
        //    volbaMenu = int.Parse(Console.ReadLine());


        //    switch (volbaMenu)
        //    {
        //        case 1:
        //            zoo.PridatZvire();
        //            break;

        //        case 2:
        //            zoo.VypisZvirat();
        //            break;

        //        case 3:
        //            zoo.SmazatZvire();
        //            break;

        //        case 4:
        //            zoo.UpravitZvire();
        //            break;


        //    }
        //}
        //while (volbaMenu != 5);



        //case 2:
        //    Console.WriteLine("Vybrali jste evidenci zamestnancu");

        //    do
        //    {
        //        Console.WriteLine("PODMENU EVIDENCE ZAMESTNANCU");
        //        Console.WriteLine("\t 1. Pridat zamestnance");
        //        Console.WriteLine("\t 2. Vypsat zamestnane");
        //        Console.WriteLine("\t 3. Smazat zamestnance");
        //        Console.WriteLine("\t 4. Upravit zamestnance");
        //        Console.WriteLine("\t 5. Ukoncit program");
        //        volbaMenuZamestnanci = int.Parse(Console.ReadLine());

        //        switch (volbaMenuZamestnanci)
        //        {
        //            case 1:
        //                zoo.PridatZamestnance();
        //                break;

        //            case 2:
        //                zoo.KartaZamestnance();
        //                break;

        //                //case 3:
        //                //    zoo.SmazatZvire();
        //                //    break;

        //                //case 4:
        //                //    zoo.UpravitZvire();
        //                //    break;


    }
}
                    //while (volbaMenuZamestnanci != 3);
                    //break;

                    //break;

          
            
            

        
   

