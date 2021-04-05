using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialProductsWinforms.ProductsHolder
{
    class CombinateQuarterlyWithInflation : ProductBase
    {
        public double SavingTime { get; set; }
        public double NumberOfDeposits { get; set; }
        public double Inflation { get; set; }

        public CombinateQuarterlyWithInflation (double amountOfInvestment, double interestRate, double savingTime, double numberOfDeposits, double inflation) : base (amountOfInvestment, interestRate)
        {
            SavingTime = savingTime;
            NumberOfDeposits = numberOfDeposits;
            Inflation = inflation;
        }
    }
}
