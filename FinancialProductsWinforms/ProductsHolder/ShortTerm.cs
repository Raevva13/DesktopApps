using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialProductsWinforms.ProductsHolder
{
    public class ShortTerm : ProductBase
    {
        public int  NumberOfDeposits { get; set; }

        public ShortTerm(int amountOfInvestment, double interestRate, int numberOfDeposits) : base (amountOfInvestment, interestRate)
        {
            NumberOfDeposits = numberOfDeposits;
        }

        public override void Compute()
        {
            Outcome = Math.Round(NumberOfDeposits * AmountOfInvestment * (1 + ((NumberOfDeposits - 1) / (2 * NumberOfDeposits)) * (InterestRate * 0.01)));
            OutcomeString = $"Při krátkodobém spoření bude hodnota spoření:\n{Outcome} CZK\nPočet vkladů: {NumberOfDeposits} během úrokového období\nVýše vkladů: {AmountOfInvestment} CZK\nÚroková míra: {InterestRate}%";

        }


    }
}
