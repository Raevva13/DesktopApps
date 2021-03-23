using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceRegister
{
    class Invoice
    {
        public string IcoSubscriber { get; set; }
        public string Code { get; set; }
        public double Amount { get; set; }
        public bool Paid { get; set; }

        public Invoice(string icoSubscriber, string code, double amount, bool paid)
        {
            IcoSubscriber = icoSubscriber;
            Code = code;
            Amount = amount;
            Paid = paid;
        }
    }
}
