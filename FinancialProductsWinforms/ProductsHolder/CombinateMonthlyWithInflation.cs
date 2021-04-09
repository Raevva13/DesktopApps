using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialProductsWinforms.ProductsHolder
{
    class CombinateMonthlyWithInflation : ProductBase
    {
        public int SavingTime { get; set; }
        public double Inflation { get; set; }

        public CombinateMonthlyWithInflation(int amountOfInvestment, double interestRate, int savingTime, double inflation) : base (amountOfInvestment, interestRate)
        {
            SavingTime = savingTime;
            Inflation = inflation;
        }



        ///<summary>
        ///Combinate savings with Monthly  accrual of interest and with inflation with input "amountOfInvestment", "savingTime", "interestRate", "inflation" and output Outcome, OutcomeString
        /// <param name="amountOfInvestment"></param>
        /// <param name="savingTime"></param>
        /// <param name="interestRate"></param>
        /// <param name="inflation"></param>
        /// <returns>Outcome, OutcomeString</returns>
        /// </summary>
        public override void Compute()
        {
            Outcome = Math.Round(AmountOfInvestment * ((Math.Pow((1 + ((InterestRate - Inflation) * 0.01) / 12), (SavingTime * 12)) - 1) / (((InterestRate - Inflation) * 0.01) / 12)));
            OutcomeString = $"Při kombinovaném spoření s měsíčním připosováním uveru,\nse zahrnutím inflace: {Inflation}\nbude výsledná hodnota: {Outcome} CZK\nvýše vkladu na konci měsíce: {AmountOfInvestment} CZK\nvýše úrokové míry: {InterestRate}%\n doba spoření {SavingTime} let";
        }
    }
}
