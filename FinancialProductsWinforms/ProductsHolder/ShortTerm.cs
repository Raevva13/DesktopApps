using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialProductsWinforms.ProductsHolder
{
    public class ShortTerm : ProductBase
    {
        public double NumberOfDeposits { get; set; }

        public ShortTerm(double amountOfInvestment, double interestRate, double numberOfDeposits) : base (amountOfInvestment, interestRate)
        {
            NumberOfDeposits = numberOfDeposits;
        }


    }
}
