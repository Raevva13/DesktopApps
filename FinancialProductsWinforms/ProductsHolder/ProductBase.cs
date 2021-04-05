using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialProductsWinforms.ProductsHolder
{
    public abstract class ProductBase
    {
        public double AmountOfInvestment { get; set; }
        public double InterestRate { get; set; }

        protected ProductBase(double amountOfInvestment, double interestRate)
        {
            AmountOfInvestment = amountOfInvestment;
            InterestRate = interestRate;
        }
    }
}
