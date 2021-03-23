using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceRegister
{
    class Company
    {
        private List<Invoice> invoices;
        public string Title { get; set; }
        public string Address { get; set; }
        public string ICO { get; set; }

        public Company(string title, string address, string ico)
        {
            invoices = new List<Invoice>();
            Title = title;
            Address = address;
            ICO = ico;
        }

        public void AddInvoice(Invoice invoice)
        {
            invoices.Add(invoice);
        }

        public double CountUnpaidAmount()
        {
            double total = 0;
            foreach (Invoice invoice in invoices)
            {
                if (!invoice.Paid)
                {
                    total += invoice.Amount;
                }
            }
            return total;
        }








    }
}
