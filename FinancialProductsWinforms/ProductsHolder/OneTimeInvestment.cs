using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinancialProductsWinforms.ProductsHolder
{
    public class OneTimeInvestment : ProductBase
    {
        public int SavingTime { get; set; }

        public OneTimeInvestment(int amountOfInvestment, double interestRate, int savingTime) : base(amountOfInvestment, interestRate)
        {
            SavingTime = savingTime;

        }


        ///<summary>
        ///One Time investment with input "amountOfInvestment", "savingTime", "interestRate" and output Outcome, OutcomeString
        /// <param name="amountOfInvestment"></param>
        /// <param name="savingTime"></param>
        /// <param name="interestRate"></param>
        /// <returns>Outcome, OutcomeString</returns>
        /// </summary>
        public override void Compute()
        {
            Outcome = Math.Round(AmountOfInvestment * Math.Pow((1 + ((InterestRate * 0.01 / 12))), (SavingTime * 12)));

            OutcomeString = $"Při jednorazove investici bude hodnota investice:\n{Outcome} CZK\nvýše investice: {AmountOfInvestment} CZK\nurokova mira: {InterestRate}%\ndobe sporeni: {SavingTime} let";

        }
    }
}
