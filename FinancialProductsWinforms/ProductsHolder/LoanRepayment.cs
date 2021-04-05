using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialProductsWinforms.ProductsHolder
{
    class LoanRepayment : ProductBase
    {
        public double SavingTime { get; set; }
        public LoanRepayment(double amountOfInvestment, double interestRate, double savingTime):base(amountOfInvestment,interestRate)
        {
            SavingTime = savingTime;
        }
    }
}
