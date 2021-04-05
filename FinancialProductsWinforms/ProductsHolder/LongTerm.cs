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
        public LongTerm(double amountOfInvestment, double interestRate, double savingTime) : base (amountOfInvestment, interestRate)
        {
            SavingTime = savingTime;
        }
    }
}
