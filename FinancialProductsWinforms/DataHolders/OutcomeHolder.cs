using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialProductsWinforms.DataHolders
{
    public class OutcomeHolder
    {
        ///<summary>
        ///Financial product outcome
        /// </summary>
        public double Outcome { get; set; }

        ///<summary>
        ///The resulting data string
        /// </summary>
        
        public string OutcomeString { get; set; }


        ///<summary>
        ///Financial product input AmountOfInvestment
        /// </summary>
        public double AmountOfInvestment { get; set; }

        ///<summary>
        ///Financial product input InterestRate
        /// </summary>
        public double InterestRate { get; set; }

        ///<summary>
        ///Financial product input SavingTime
        /// </summary>
        public double SavingTime { get; set; }

        ///<summary>
        ///Financial product input NumberOfDeposits
        /// </summary>
        public double NumberOfDeposits { get; set; }

        ///<summary>
        ///Financial product input inflation
        /// </summary>
        public double Inflation { get; set; }

        public double OutCome { get; set; }

        public string OutComeString { get; set; }





        ///<summary>
        ///Long Term Savings with input "amountOfInvestment", "savingTime", "interestRate" and output Outcome, OutcomeString
        /// <param name="amountOfInvestment"></param>
        /// <param name="savingTime"></param>
        /// <param name="interestRate"></param>
        /// <returns>Outcome, OutcomeString</returns>
        /// </summary>
        public void Compute()
        {
            Outcome = Math.Round(AmountOfInvestment * ((Math.Pow((1 + (InterestRate * 0.01)), SavingTime) - 1) / (InterestRate * 0.01)));
            OutcomeString = $"Při dlouhodobém spoření bude hodnota spoření:\n{Outcome} CZK\nvýše vkladů: {AmountOfInvestment} CZK\ndoba spoření {SavingTime} let\nurokova sazba {InterestRate}%";
        }

    }
}
