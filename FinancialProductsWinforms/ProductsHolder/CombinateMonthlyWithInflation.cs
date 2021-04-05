using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialProductsWinforms.ProductsHolder
{
    class CombinateMonthlyWithInflation : ProductBase
    {
        public double SavingTime { get; set; }
        public double Inflation { get; set; }

        public CombinateMonthlyWithInflation(double amountOfInvestment, double interestRate, double savingTime, double inflation) : base (amountOfInvestment, interestRate)
        {
            SavingTime = savingTime;
            Inflation = inflation;
        }

    }
}
