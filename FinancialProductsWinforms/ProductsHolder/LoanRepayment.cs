using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialProductsWinforms.ProductsHolder
{
    class LoanRepayment : ProductBase
    {
        public int SavingTime { get; set; }
        public LoanRepayment(int amountOfInvestment, double interestRate, int savingTime):base(amountOfInvestment,interestRate)
        {
            SavingTime = savingTime;
        }


        ///<summary>
        ///Loan Repayment with input "amountOfInvestment", "savingTime", "interestRate" and output Outcome, OutcomeString
        /// <param name="amountOfInvestment"></param>
        /// <param name="savingTime"></param>
        /// <param name="interestRate"></param>
        /// <returns>Outcome, OutcomeString</returns>
        /// </summary>
        public override void Compute()
        {
            Outcome = Math.Round(AmountOfInvestment * ((((InterestRate * 0.01) / 12) * (Math.Pow((1 + ((InterestRate * 0.01) / 12)), (SavingTime * 12)))) / ((Math.Pow((1 + ((InterestRate * 0.01) / 12)), (SavingTime * 12))) - 1)));
            OutcomeString = $"Měsíční splátky úvěru ve výši: {AmountOfInvestment} CZK\ndoba poskytnutí: {SavingTime} let\nÚroková sazba: {InterestRate}%\nbudou činit měsíční splátky ve výši: {Outcome} CZK";
        }
    }
}
