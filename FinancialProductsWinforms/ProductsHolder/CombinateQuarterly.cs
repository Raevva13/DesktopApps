using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialProductsWinforms.ProductsHolder
{
    class CombinateQuarterly : ProductBase
    {
        public int SavingTime { get; set; }
        public int NumberOfDeposits { get; set; }

        public CombinateQuarterly (int amountOfInvestment, double interestRate, int savingTime, int numberOfDeposits) : base (amountOfInvestment, interestRate)
        {
            SavingTime = savingTime;
            NumberOfDeposits = numberOfDeposits;
        }


        ///<summary>
        ///Combinate savings with Quarterly accrual of interest and without inflation with input "amountOfInvestment", "savingTime", "interestRate", "numberOfDeposits" and output Outcome, OutcomeString
        /// <param name="amountOfInvestment"></param>
        /// <param name="savingTime"></param>
        /// <param name="interestRate"></param>
        /// <param name="numberOfDeposits"></param>
        /// <returns>Outcome, OutcomeString</returns>
        /// </summary>
        public override void Compute()
        {
            Outcome = Math.Round(NumberOfDeposits * AmountOfInvestment * (1 + ((NumberOfDeposits - 1) / (2 * NumberOfDeposits)) * ((InterestRate * 0.01) / 4)) * ((Math.Pow((1 + (InterestRate * 0.01) / 4), (SavingTime * 4)) - 1) / ((InterestRate * 0.01) / 4)));
            OutcomeString = $"Při kombinovanem sporeni se ctvrtletnim pripisovanim uveru,\nbez zahrnuti inflace bude vysledna hodnota: {Outcome} CZK\nvýše vkladu na konci roku: {AmountOfInvestment} CZK\núroková míra: {InterestRate}%\npočtu vkladů: {NumberOfDeposits}\n době spoření: {SavingTime} let ";
        }
    }
}
