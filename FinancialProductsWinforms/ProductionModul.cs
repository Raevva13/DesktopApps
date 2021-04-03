using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialProductsWinforms.DataHolders;

namespace FinancialProductsWinforms
{

    /// <summary>
    /// Singleton
    /// </summary>
    public class ProductionModul
    {
        private static readonly object lockObject = new object();
        private static ProductionModul _specimen;

        private ProductionModul() { }


        public static ProductionModul Specimen
        {
            get
            {
                lock (lockObject)
                {
                    return _specimen ?? (_specimen = new ProductionModul());
                }
            }


        }
        ///<summary>
        ///One Time investment with input "amountOfInvestment", "savingTime", "interestRate" and output Outcome, OutcomeString
        /// <param name="amountOfInvestment"></param>
        /// <param name="savingTime"></param>
        /// <param name="interestRate"></param>
        /// <returns>Outcome, OutcomeString</returns>
        /// </summary>
        public OutcomeHolder OneTimeInvestment(double amountOfInvestment, double savingTime, double interestRate)
        {
            OutcomeHolder holder = new OutcomeHolder { Outcome = Math.Round(amountOfInvestment * Math.Pow((1 + ((interestRate * 0.01 / 12))), (savingTime * 12))) };
            holder.OutcomeString = $"Při jednorazove investici bude hodnota investice:\n{holder.Outcome} CZK\nvýše investice: {amountOfInvestment} CZK\nurokova mira: {interestRate}%\ndobe sporeni: {savingTime} let";

            return holder;
        }


        ///<summary>
        ///Short Term Savings with input "numberOfDeposits", "amountOfInvestment", "interestRate" and output Outcome, OutcomeString
        /// <param name="numberOfDeposits"></param>
        /// <param name="amountOfInvestment"></param>
        /// <param name="interestRate"></param>
        /// <returns>Outcome, OutcomeString</returns>
        /// </summary>
        public OutcomeHolder ShortTermSavings(double amountOfInvestment, double interestRate, double numberOfDeposits)
        {
            OutcomeHolder holder = new OutcomeHolder { Outcome = Math.Round(numberOfDeposits * amountOfInvestment * (1 + ((numberOfDeposits - 1) / (2 * numberOfDeposits)) * (interestRate * 0.01))) };
            holder.OutcomeString = $"Při krátkodobém spoření bude hodnota spoření:\n{holder.Outcome} CZK\nPočet vkladů: {numberOfDeposits} během úrokového období\nVýše vkladů: {amountOfInvestment} CZK\nÚroková míra: {interestRate}%";

            return holder;
        }

        public OutcomeHolder ShortPreTermSavings(double amountOfInvestment, double interestRate, double numberOfDeposits)
        {
            OutcomeHolder holder = new OutcomeHolder { Outcome = Math.Round(amountOfInvestment / (numberOfDeposits * (1 + (((numberOfDeposits + 1) / (2 * numberOfDeposits)) * (interestRate * 0.01))))) };
            holder.OutcomeString = $"Na začátku každého měsíce musíme ukládat:\n{holder.Outcome} CZK\nnaspořeno na konci roku: {amountOfInvestment} CZK\nÚroková míra: {interestRate}%\nPočet vkladů: {numberOfDeposits}";

            return holder;
        }












        ///<summary>
        ///Long Term Savings with input "amountOfInvestment", "savingTime", "interestRate" and output Outcome, OutcomeString
        /// <param name="amountOfInvestment"></param>
        /// <param name="savingTime"></param>
        /// <param name="interestRate"></param>
        /// <returns>Outcome, OutcomeString</returns>
        /// </summary>
        public OutcomeHolder LongTermSavings(double amountOfInvestment, double savingTime, double interestRate)
        {
            OutcomeHolder holder = new OutcomeHolder { Outcome = Math.Round(amountOfInvestment * ((Math.Pow((1 + (interestRate * 0.01)), savingTime) - 1) / (interestRate * 0.01))) };
            holder.OutcomeString = $"Při dlouhodobém spoření bude hodnota spoření:\n{holder.Outcome} CZK\nvýše vkladů: {amountOfInvestment} CZK\ndoba spoření {savingTime} let\nurokova sazba {interestRate}%";

            return holder;
        }


        ///<summary>
        ///Combinate savings with Monthly  accrual of interest and without inflation with input "amountOfInvestment", "savingTime", "interestRate" and output Outcome, OutcomeString
        /// <param name="amountOfInvestment"></param>
        /// <param name="savingTime"></param>
        /// <param name="interestRate"></param>
        /// <returns>Outcome, OutcomeString</returns>
        /// </summary>
        public OutcomeHolder CombinateSavingsMonthly(double amountOfInvestment, double savingTime, double interestRate)
        {
            OutcomeHolder holder = new OutcomeHolder { Outcome = Math.Round(amountOfInvestment* ((Math.Pow((1 + (interestRate * 0.01) / 12), (savingTime * 12)) - 1) / ((interestRate * 0.01) / 12)))};
            holder.OutcomeString = $"Při kombinovaném spoření s měsíčním připosováním uveru,\nbez zahrnutí inflace bude výsledná hodnota: {holder.Outcome} CZK\nvýše vkladu na konci měsíce: {amountOfInvestment} CZK\nvýše úrokové míry: {interestRate}%\n doba spoření {savingTime} let";

            return holder;
        }

        ///<summary>
        ///Combinate savings with Monthly  accrual of interest and with inflation with input "amountOfInvestment", "savingTime", "interestRate", "inflation" and output Outcome, OutcomeString
        /// <param name="amountOfInvestment"></param>
        /// <param name="savingTime"></param>
        /// <param name="interestRate"></param>
        /// <param name="inflation"></param>
        /// <returns>Outcome, OutcomeString</returns>
        /// </summary>
        public OutcomeHolder CombinateSavingsMonthlyWithInflation(double amountOfInvestment, double savingTime, double interestRate, double inflation)
        {
            OutcomeHolder holder = new OutcomeHolder { Outcome = Math.Round(amountOfInvestment * ((Math.Pow((1 + ((interestRate - inflation) * 0.01) / 12), (savingTime * 12)) - 1) / (((interestRate - inflation) * 0.01) / 12))) };
            holder.OutcomeString = $"Při kombinovaném spoření s měsíčním připosováním uveru,\nse zahrnutím inflace bude výsledná hodnota: {holder.Outcome} CZK\nvýše vkladu na konci měsíce: {amountOfInvestment} CZK\nvýše úrokové míry: {interestRate}%\n doba spoření {savingTime} let";

            return holder;
        }


        ///<summary>
        ///Combinate savings with Quarterly accrual of interest and without inflation with input "amountOfInvestment", "savingTime", "interestRate", "numberOfDeposits" and output Outcome, OutcomeString
        /// <param name="amountOfInvestment"></param>
        /// <param name="savingTime"></param>
        /// <param name="interestRate"></param>
        /// <param name="numberOfDeposits"></param>
        /// <returns>Outcome, OutcomeString</returns>
        /// </summary>
        public OutcomeHolder CombinateSavingsQuarterly( double amountOfInvestment, double savingTime, double interestRate, double numberOfDeposits)
        {
            OutcomeHolder holder = new OutcomeHolder { Outcome = Math.Round(numberOfDeposits * amountOfInvestment * (1 + ((numberOfDeposits - 1) / (2 * numberOfDeposits)) * ((interestRate * 0.01) / 4)) * ((Math.Pow((1 + (interestRate * 0.01) / 4), (savingTime * 4)) - 1) / ((interestRate * 0.01) / 4))) };
            holder.OutcomeString = $"Při kombinovanem sporeni se ctvrtletnim pripisovanim uveru,\nbez zahrnuti inflace bude vysledna hodnota: {holder.Outcome} CZK\nvýše vkladu na konci roku: {amountOfInvestment} CZK\núroková míra: {interestRate}%\npočtu vkladů: {numberOfDeposits}\n době spoření: {savingTime} let ";

            return holder;  
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
        public OutcomeHolder CombinateSavingsQuarterlyWithInflation(double amountOfInvestment, double savingTime, double interestRate, double numberOfDeposits, double inflation)
        {
            OutcomeHolder holder = new OutcomeHolder { Outcome = Math.Round(numberOfDeposits * amountOfInvestment * (1 + ((numberOfDeposits - 1) / (2 * numberOfDeposits)) * (((interestRate - inflation) * 0.01) / 4)) * ((Math.Pow((1 + ((interestRate - inflation) * 0.01) / 4), (savingTime * 4)) - 1) / (((interestRate - inflation)) * 0.01) / 4)) };
            holder.OutcomeString = $"Při kombinovanem sporeni se ctvrtletnim pripisovanim uveru\nse zahrnutim inflace bude vysledna hodnota: {holder.Outcome} CZK\nvýše vkladu na konci roku: {amountOfInvestment}CZK\núroková míra: {interestRate}%\ninflace: {inflation}\npočet vkladů: {numberOfDeposits}\n doba spoření: {savingTime} let ";

            return holder;
        }
        ///<summary>
        ///Loan Repayment with input "amountOfInvestment", "savingTime", "interestRate" and output Outcome, OutcomeString
        /// <param name="amountOfInvestment"></param>
        /// <param name="savingTime"></param>
        /// <param name="interestRate"></param>
        /// <returns>Outcome, OutcomeString</returns>
        /// </summary>
        public OutcomeHolder LoanRepayment(double amountOfInvestment, double savingTime, double interestRate)
        {
            OutcomeHolder holder = new OutcomeHolder { Outcome = Math.Round(amountOfInvestment * ((((interestRate * 0.01) / 12) * (Math.Pow((1 + ((interestRate * 0.01) / 12)), (savingTime * 12)))) / ((Math.Pow((1 + ((interestRate * 0.01) / 12)), (savingTime * 12))) - 1))) };
            holder.OutcomeString = $"Měsíční splátky úvěru ve výši: {amountOfInvestment} CZK\ndoba poskytnutí: {savingTime} let\nÚroková sazba: {interestRate}%\nbudou činit měsíční splátky ve výši: {holder.Outcome} CZK";

            return holder;
        }
    }
}




