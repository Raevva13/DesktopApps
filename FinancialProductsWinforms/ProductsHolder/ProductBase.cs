using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialProductsWinforms.ProductsHolder
{
    public abstract class ProductBase
    {
        public int AmountOfInvestment { get; set; }
        public double InterestRate { get; set; }

        public double Outcome { get; set; }

        public string OutcomeString { get; set; }
            
           

        protected ProductBase(int amountOfInvestment, double interestRate)
        {
            AmountOfInvestment = amountOfInvestment;
            InterestRate = interestRate;
        }

        public abstract void Compute();
    }
}
