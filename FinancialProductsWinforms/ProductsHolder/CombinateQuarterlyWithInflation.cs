using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialProductsWinforms.ProductsHolder
{
    class CombinateQuarterlyWithInflation : ProductBase
    {
        public int SavingTime { get; set; }
        public int NumberOfDeposits { get; set; }
        public double Inflation { get; set; }

        public CombinateQuarterlyWithInflation (int amountOfInvestment, double interestRate, int savingTime, int numberOfDeposits, double inflation) : base (amountOfInvestment, interestRate)
        {
            SavingTime = savingTime;
            NumberOfDeposits = numberOfDeposits;
            Inflation = inflation;
        }


        ///<summary>
        ///Combinate savings with Quarterly accrual of interest and without inflation with input "amountOfInvestment", "savingTime", "interestRate", "numberOfDeposits", "inflation" and output Outcome, OutcomeString
        /// <param name="amountOfInvestment"></param>
        /// <param name="savingTime"></param>
        /// <param name="interestRate"></param>
        /// <param name="numberOfDeposits"></param>
        /// <param name="inflation"></param>
        /// <returns>Outcome, OutcomeString</returns>
        /// </summary>
        public override void Compute()
        {
           Outcome = Math.Round(NumberOfDeposits * AmountOfInvestment * (1 + ((NumberOfDeposits - 1) / (2 * NumberOfDeposits)) * (((InterestRate - Inflation) * 0.01) / 4)) * ((Math.Pow((1 + ((InterestRate - Inflation) * 0.01) / 4), (SavingTime * 4)) - 1) / (((InterestRate - Inflation)) * 0.01) / 4));
            OutcomeString = $"Při kombinovanem sporeni se ctvrtletnim pripisovanim uveru\nse zahrnutim inflace : {Inflation}%\nbude vysledna hodnota: {Outcome} CZK\nvýše vkladu na konci roku: {AmountOfInvestment}CZK\núroková míra: {InterestRate}%\ninflace: {Inflation}\npočet vkladů: {NumberOfDeposits}\n doba spoření: {SavingTime} let ";

        }
    }
}
