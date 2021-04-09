using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialProductsWinforms.ProductsHolder
{
    public class CombinateMonthly : ProductBase
    {
        public int SavingTime { get; set; }

        public CombinateMonthly (int amountOfInvestment, double interestRate, int savingTime) : base(amountOfInvestment, interestRate)
        {
            SavingTime = savingTime; 
        }


        ///<summary>
        ///Combinate savings with Monthly  accrual of interest and without inflation with input "amountOfInvestment", "savingTime", "interestRate" and output Outcome, OutcomeString
        /// <param name="amountOfInvestment"></param>
        /// <param name="savingTime"></param>
        /// <param name="interestRate"></param>
        /// <returns>Outcome, OutcomeString</returns>
        /// </summary>
        public override void Compute()
        {
            Outcome = Math.Round(AmountOfInvestment * ((Math.Pow((1 + (InterestRate * 0.01) / 12), (SavingTime * 12)) - 1) / ((InterestRate * 0.01) / 12)));
            OutcomeString = $"Při kombinovaném spoření s měsíčním připosováním uveru,\nbez zahrnutí inflace bude výsledná hodnota: {Outcome} CZK\nvýše vkladu na konci měsíce: {AmountOfInvestment} CZK\nvýše úrokové míry: {InterestRate}%\n doba spoření {SavingTime} let";
        }

    }
}
