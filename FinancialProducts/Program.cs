using System;

namespace FinancniProdukty
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vítejte v aplikaci, kde jsou kalkulačky pro několik základních finančních produktů");
            // nextProduct to create a loop
            string nextProduct = "ano";
            do
            {
                //product offer + information on calculations
                Console.WriteLine("Naše portfolio produktů je specifikováno níže, prosím vyberte jeden z produktů [1-5]");
                Console.WriteLine("Produkt číslo 1: JEDNORÁZOVÁ INVESTICE ");
                Console.WriteLine("Produkt číslo 2: KRÁTKODOBÉ SPOŘENÍ ");
                Console.WriteLine("Produkt číslo 3: DLOUHODOBÉ SPOŘENÍ ");
                Console.WriteLine("Produkt číslo 4: KOMBINACE KRÁTKODOBÉHO A DLOUHODOBÉHO SPOŘENÍ ");
                Console.WriteLine("Produkt číslo 5: ÚVĚR A JEHO SPLÁCENÍ ");
                Console.WriteLine("Číslo 6: INFORMACE TÝKAJÍCÍ SE VÝPOČTŮ ");


                int selectProduct = int.Parse(Console.ReadLine());
                double result = 0;
                //switch to choose from various options see above
                switch (selectProduct)
                {
                    case 1:
                        Console.WriteLine("Vybrali jste možnost 1. JEDNORÁZOVÁ INVESTICE");
                        Console.WriteLine("Pro výpočet je potřeba znát několik následujících údajů");
                        result = OneTimeSavings();
                        break;

                    case 2:
                        Console.WriteLine("Vybrali jste možnost 2. KRÁTKODOBÉ SPOŘENÍ ");
                        Console.WriteLine("Pro výpočet je potřeba znát několik následujících údajů");
                        result = ShortSavings();
                        break;

                    case 3:
                        Console.WriteLine("Vybrali jste možnost 3. DLOUHODOBÉ SPOŘENÍ");
                        Console.WriteLine("Pro výpočet je potřeba znát několik následujících údajů: ");
                        result = LongSavings();
                        break;

                    case 4:
                        Console.WriteLine("Vybrali jste možnost 4. KOMBINACE KRÁTKODOBÉHO A DLOUHODOBÉHO SPOŘENÍ");
                        Console.WriteLine("Pro výpočet je potřeba znát několik následujících dat: ");
                        result = CombinateSavings();
                        break;

                    case 5:
                        Console.WriteLine("Vybrali jste možnost 5. ÚVĚR A JEHO SPLÁCENÍ ");
                        Console.WriteLine("Pro výpočet je potřeba znát několik následujících dat: ");
                        result = LoanAndRepayment();
                        break;

                    case 6:
                        // information for calculations
                        Console.WriteLine("1. v uvedených výpočtech není bráno v úvahu zdanění – to znamená, že se vždy jedná o hrubý výnos, který je nutno zdanit.");
                        Console.WriteLine("2. u úvěrů, které slouží na bydlení, není brána v úvahu daňová úleva ze zaplacených úroků.");
                        Console.WriteLine("3. při dosazování úrokových měr / sazeb do výpočtů jsou brány v úvahu zpravidla nominální úrokové míry, to znamená bez zohlednění inflace. ");
                        Console.WriteLine("4. výsledky jsou matematicky zaokrouhleny na celé Kč.");
                        break;
                }

                // if the user enters a non-existent option, the application notifies you of the non-existent option
                if ((selectProduct > 0) && (selectProduct < 7))
                    Console.WriteLine("Vysledek je {0} CZK", Math.Round(result));
                else
                    Console.WriteLine("Neplatná volba");
                // the application asks if the user wishes to view another product - this closes / opens the cycle
                Console.WriteLine("Přejete si vybrat další produkt? [ano/ne]");
                nextProduct = Console.ReadLine();
            } while (nextProduct == "ano");

            Console.WriteLine("Děkujeme za použití naší aplikace s výpočty. Aplikaci je možné ukončit libovolnou klávesou");
            Console.ReadKey();
            // formulas for calculations taken from: http://www.rfpplus.cz/rodinne_finance/financni_matematika.php?fbclid=IwAR3IdBRsI38whxMR9AA36Exv7vUoRxQdOXhhVJENJlQQ4lrhfB3yLcKwWqs
        }



        static double OneTimeSavings()
        {
            Console.Write("Zadejte dobu spoření v letech: ");
            int numberOfYears = int.Parse(Console.ReadLine());

            Console.Write("Zadejte výši jednorázové investice: ");
            int amountOfInvestment = int.Parse(Console.ReadLine());

            Console.Write("Zadejte výši úrokové míry p.a.(zadejte v % bez znaku '%'): ");
            double ratePA = double.Parse(Console.ReadLine());
            double result = amountOfInvestment * Math.Pow((1 + ((ratePA * 0.01 / 12))), (numberOfYears * 12));
            return result;
        }


        static double ShortSavings()
        {
            Console.Write("Počet vkladů během jednoho úrokového období: ");
            double numberOfDeposits = int.Parse(Console.ReadLine());

            Console.Write("Pravidelná výše vkladu nebo splátky úvěru: ");
            double amountOfInvestment = int.Parse(Console.ReadLine());

            Console.Write("Výše roční úrokové míry/sazby: ");
            double ratePA = double.Parse(Console.ReadLine());

            //the whole formula for short-term half-time savings
            double result = numberOfDeposits * amountOfInvestment * (1 + ((numberOfDeposits - 1) / (2 * numberOfDeposits)) * (ratePA * 0.01));
            return result;
        }

        static double LongSavings()
        {
            //savings period in years
            Console.Write("Zadejte, kolik let chcete spořit: ");
            double savingsPeriodInYears = int.Parse(Console.ReadLine());

            // regular amount of the deposit
            Console.Write("Pravidelná výše vkladu nebo splátky úvěru: ");
            double amountOfInvestment = int.Parse(Console.ReadLine());

            //annual interest rate / rate (conversion from percentages to decimals required)
            Console.Write("Výše roční úrokové míry/sazby: ");
            double ratePA = double.Parse(Console.ReadLine());

            //the whole formula for Long term Savings  
            double result = Math.Round(amountOfInvestment * ((Math.Pow((1 + (ratePA * 0.01)), savingsPeriodInYears) - 1) / (ratePA * 0.01)));
            return result;
        }


        static double CombinateSavings()
        {
            // number of deposits for the interest period                        
            Console.Write("Uveďte počet vkladů během jednoho úrokového období: ");
            double numberOfDeposits = int.Parse(Console.ReadLine());

            //deposit amount 
            Console.Write("Uveďte výši vkladu nebo splátek úvěru: ");
            double amountOfDeposits = int.Parse(Console.ReadLine());

            // savings period in years
            Console.Write("Uveďte počet let: ");
            double numberOfYears = int.Parse(Console.ReadLine());

            //annual interest rate (conversion from percentages to decimals required)
            Console.Write("Uveďte výši  roční úrokové míry/ sazby: ");
            double ratePA = double.Parse(Console.ReadLine());

            Console.Write("O jaké připisování úroků se jedná: \n1. MĚSÍČNÍ\n2. ČTVRTLETNÍ\n3. ROČNÍ [1, 2, 3]  ");
            int interest = int.Parse(Console.ReadLine());
            if (interest == 1) //Combinate Savings with monthly interest
            {
                Console.Write("Přejete si do výpočtu zahrnout inflaci? \nV případě započítání inflace získáte NOMINÁLNÍ ÚSPORY \nv případě nezapočítání inflace získáte REÁLNÉ ÚSPORY [ano/ne]: ");
                string withInflation = Console.ReadLine();
                if (withInflation == "ano")
                {
                    Console.Write("Zadejte výši průměrné inflace v % bez znaku '%': ");
                    double inflation = int.Parse(Console.ReadLine());
                    double result = numberOfDeposits * amountOfDeposits * (1 + ((numberOfDeposits - 1) / (2 * numberOfDeposits)) * (((ratePA - inflation) * 0.01) / 12)) * ((Math.Pow((1 + ((ratePA - inflation) * 0.01) / 12), (numberOfYears * 12)) - 1) / (((ratePA - inflation) * 0.01) / 12));
                    return result;
                }
                else //without inflation
                {
                    double result = numberOfDeposits * amountOfDeposits * (1 + ((numberOfDeposits - 1) / (2 * numberOfDeposits)) * ((ratePA * 0.01) / 12)) * ((Math.Pow((1 + (ratePA * 0.01) / 12), (numberOfYears * 12)) - 1) / ((ratePA * 0.01) / 12));
                    return result;
                }
            }

            else if (interest == 2) //Combinate Savings with quarterly interest
            {
                Console.WriteLine("Přejete si do výpočtu zahrnout inflaci? \nV případě započítání inflace získáte NOMINÁLNÍ ÚSPORY \nv případě nezapočítání inflace získáte REÁLNÉ ÚSPORY [ano/ne]");
                string withInflation = Console.ReadLine();
                if (withInflation == "ano") // with inflation
                {
                    Console.Write("Zadejte výši průměrné inflace v % bez znaku '%': ");
                    double inflation = int.Parse(Console.ReadLine());
                    double result = numberOfDeposits * amountOfDeposits * (1 + ((numberOfDeposits - 1) / (2 * numberOfDeposits)) * (((ratePA - inflation) * 0.01) / 4)) * ((Math.Pow((1 + ((ratePA - inflation) * 0.01) / 4), (numberOfYears * 4)) - 1) / (((ratePA - inflation) * 0.01) / 4));
                    return result;

                }
                else // without inflation
                {
                    double result = numberOfDeposits * amountOfDeposits * (1 + ((numberOfDeposits - 1) / (2 * numberOfDeposits)) * ((ratePA * 0.01) / 4)) * ((Math.Pow((1 + (ratePA * 0.01) / 4), (numberOfYears * 4)) - 1) / ((ratePA * 0.01) / 4));
                    return result;
                }
            }
            else if (interest == 3) //Combinate Savings with yearly interest
            {
                Console.WriteLine("Přejete si do výpočtu zahrnout inflaci? \nV případě započítání inflace získáte NOMINÁLNÍ ÚSPORY \nv případě nezapočítání inflace získáte REÁLNÉ ÚSPORY [ano/ne]");
                string withInflation = Console.ReadLine();
                if (withInflation == "ano") //with inflation
                {
                    Console.Write("Zadejte výši průměrné inflace v % bez znaku '%': ");
                    double inflation = int.Parse(Console.ReadLine());
                    double result = numberOfDeposits * amountOfDeposits * (1 + ((numberOfDeposits - 1) / (2 * numberOfDeposits)) * (((ratePA - inflation) * 0.01))) * (Math.Pow((1 + ((ratePA - inflation) * 0.01)), (numberOfYears)) - 1) / ((ratePA - inflation) * 0.01);
                    return result;
                }
                else //without inflation
                {
                    double result = numberOfDeposits * amountOfDeposits * (1 + ((numberOfDeposits - 1) / (2 * numberOfDeposits)) * ((ratePA * 0.01))) * (Math.Pow((1 + (ratePA * 0.01)), (numberOfYears)) - 1) / (ratePA * 0.01);
                    return result;
                }
            }
            else return 0;

        }

        static double LoanAndRepayment()
        {
            //the amount of the loan provided
            Console.Write("Zadejte výši poskytnutého úvěru: ");
            int loanAmount = int.Parse(Console.ReadLine());

            //loan period
            Console.Write("Zadejte počet let: ");
            double numberOfYears = int.Parse(Console.ReadLine());

            //rate p.a.
            Console.Write("Zadejte výši roční úrokové míry/sazby: ");
            double ratePA = double.Parse(Console.ReadLine());

            double result = loanAmount * ((((ratePA * 0.01) / 12) * (Math.Pow((1 + ((ratePA * 0.01) / 12)), (numberOfYears * 12)))) / ((Math.Pow((1 + ((ratePA * 0.01) / 12)), (numberOfYears * 12))) - 1));
            return result;
        }




        //static double ShortHalfTimeSavings(int numberOfDeposits, int amountOfInvestment, double ratePA)
        //{

        //    //short-term half-time savings
        //    double result = numberOfDeposits * amountOfInvestment * (1 + ((numberOfDeposits - 1) / (2 * numberOfDeposits)) * (ratePA * 0.01));
        //    Console.Write("Výsledek pro KRÁTKODOBÉ POLHŮTNÍ SPOŘENÍ je: {0}", result);
        //    return result;


        //}
        //static double ShortPreTermSavings(int numberOfDeposits, int amountOfInvestment, double ratePA)
        //{
        //    // short-term pre-term savings
        //    double result = numberOfDeposits * amountOfInvestment * (1 + ((numberOfDeposits + 1) / (2 * numberOfDeposits)) * (ratePA * 0.01));
        //    Console.Write("Výsledek pro KRÁTKODOBÉ PŘEDLHŮTNÍ SPOŘENÍ je : {0}", result);
        //    return result;
    }

    //static double CombinateSavingsMonthlyInterestWithoutInfation(int numberOfDeposits, int amountOfDeposits, int numberOfYears, double ratePA)
    //{
    //    double result = amountOfDeposits * ((Math.Pow((1 + (ratePA * 0.01) / 12), (numberOfYears * 12))) - 1) / ((ratePA * 0.01) / 12);
    //    return result;
    //}

    //static double CombinateSavingsMonthlyWithInfation(int numberOfDeposits, int amountOfDeposits, int numberOfYears, double ratePA, double inflation)
    //{
    //    double result = numberOfYears * ((Math.Pow((1 + ((ratePA - inflation) * 0.01) / 12), (numberOfYears * 12))) - 1) / (((ratePA - inflation) * 0.01) / 12);
    //    return result;
    //}

    //static double CombinateSavingsQuarterlyWithoutInflation(int numberOfDeposits, int amountOfDeposits, int numberOfYears, double ratePA)
    //{
    //    double result = numberOfDeposits * amountOfDeposits * (1 + ((numberOfDeposits - 1) / (2 * numberOfDeposits)) * (ratePA * 0.01) / 4) * (((Math.Pow((1 + (ratePA * 0.01) / 4), (numberOfYears * 4))) - 1) / ((ratePA * 0.01) / 4));
    //    return result;
    //}
    //static double CombinateSavingsQuarterlyWithInflation(int numberOfDeposits, int amountOfDeposits, int numberOfYears, double ratePA, double inflation)
    //{
    //    double result = numberOfDeposits * amountOfDeposits * (1 + ((numberOfDeposits - 1) / (2 * numberOfDeposits)) * ((ratePA - inflation) * 0.01) / 4) * (((Math.Pow((1 + ((ratePA - inflation) * 0.01) / 4), (numberOfYears * 4))) - 1) / (((ratePA - inflation) * 0.01) / 4));
    //    return result;
    //}

    //static double CombinateSavingsYearlyWithoutInflation(int numberOfDeposits, int amountOfDeposits, int numberOfYears, double ratePA)
    //{
    //    double result = amountOfDeposits * (1 + ((numberOfDeposits - 1) / (2 * numberOfDeposits)) * (ratePA * 0.01)) * (((Math.Pow((1 + (ratePA * 0.01)), numberOfYears)) - 1) / ((ratePA * 0.01)));
    //    return result;
    //}

    //static double CombinateSavingsYearlyWithInflation(int numberOfDeposits, int amountOfDeposits, int numberOfYears, double ratePA, double inflation)
    //{
    //    double result = amountOfDeposits * (1 + ((numberOfDeposits - 1) / (2 * numberOfDeposits)) * ((ratePA - inflation) * 0.01)) * (((Math.Pow((1 + ((ratePA - inflation) * 0.01)), numberOfYears)) - 1) / (((ratePA - inflation) * 0.01)));
    //    return result;
    //}




}



