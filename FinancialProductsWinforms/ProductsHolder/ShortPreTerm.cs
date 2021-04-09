using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialProductsWinforms.ProductsHolder
{
    public class ShortPreTerm : ProductBase
    {
        public int NumberOfDeposits { get; set; }

        public ShortPreTerm(int amountOfInvestment, double interestRate, int numberOfDeposits) : base (amountOfInvestment, interestRate)
        {
            NumberOfDeposits = numberOfDeposits;
        }


        public override void Compute()
        {
            Outcome = Math.Round(AmountOfInvestment / (NumberOfDeposits * (1 + (((NumberOfDeposits + 1) / (2 * NumberOfDeposits)) * (InterestRate * 0.01)))));
            OutcomeString = $"Na začátku každého měsíce musíme ukládat:\n{Outcome} CZK\nnaspořeno na konci roku: {AmountOfInvestment} CZK\nÚroková míra: {InterestRate}%\nPočet vkladů: {NumberOfDeposits}";
        }
    }
}
