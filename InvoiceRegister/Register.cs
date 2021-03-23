using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceRegister
{
    class Register
    {
        private Dictionary<string, Company> companies;

        public Register()
        {
            companies = new Dictionary<string, Company>();
        }


        public void AddInvoice(Invoice invoice)
        {
            if (!companies.ContainsKey(invoice.IcoSubscriber))
            {
                throw new Exception("Společnost s IČO: {0} ke které faktura náleží neexistuje v evidenci ");
            }
            Company company = companies[invoice.IcoSubscriber];
            company.AddInvoice(invoice);
        }

        public void AddCompany(Company company)
        {
            companies.Add(company.ICO, company);
        }

        public void ListOfDebtCompanies()
        {
            Console.WriteLine("Vypis dluznych společnosti: ");
            foreach (Company company in companies.Values)
            {
                double amountOwed = company.CountUnpaidAmount();
                if (amountOwed > 0)
                {
                    Console.WriteLine($"{company.Title} {company.Address} {company.ICO}");
                    Console.WriteLine($"\tCelková dlužná částka: {amountOwed}");

                }
            }
        }
    }
}
