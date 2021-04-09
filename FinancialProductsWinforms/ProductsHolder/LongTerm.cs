using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialProductsWinforms.ProductsHolder
{
    public class LongTerm : ProductBase
    {
        public double SavingTime { get; set; }
        public LongTerm(int amountOfInvestment, double interestRate, int savingTime) : base (amountOfInvestment, interestRate)
        {
            SavingTime = savingTime;
        }


        ///<summary>
        ///Long Term Savings with input "amountOfInvestment", "savingTime", "interestRate" and output Outcome, OutcomeString
        /// <param name="amountOfInvestment"></param>
        /// <param name="savingTime"></param>
        /// <param name="interestRate"></param>
        /// <returns>Outcome, OutcomeString</returns>
        /// </summary>
        public override void Compute()
        {
            Outcome = Math.Round(AmountOfInvestment * ((Math.Pow((1 + (InterestRate * 0.01)), SavingTime) - 1) / (InterestRate * 0.01)));
            OutcomeString = $"Při dlouhodobém spoření bude hodnota spoření:\n{Outcome} CZK\nvýše vkladů: {AmountOfInvestment} CZK\ndoba spoření {SavingTime} let\nurokova sazba {InterestRate}%";
        }
    }
}
