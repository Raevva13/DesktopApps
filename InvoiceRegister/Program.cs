using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            Register register = new Register();

            StreamReader readerCompanies = null;
            StreamReader readerInvoices = null;

            try
            {
                //download companies
                readerCompanies = new StreamReader("companies.txt");
                string line = "";
                while ((line = readerCompanies.ReadLine()) != null)
                {
                    string[] values = line.Split(';');
                    string ico = values[0];
                    string title = values[1];
                    string address = values[2];
                    register.AddCompany(new Company(title, address, ico));
                }

                // download invoices
                readerInvoices = new StreamReader("invoices.txt");
                while ((line = readerInvoices.ReadLine()) != null)
                {
                    string[] values = line.Split(';');
                    string code = values[0];
                    string ico = values[1];
                    double amount = double.Parse(values[2]);
                    bool paid = false;
                    if (values[3].ToLower() == "yes")
                    {
                        paid = true;
                    }
                    register.AddInvoice(new Invoice(ico, code, amount, paid));
                }
                register.ListOfDebtCompanies();
            }
            catch (Exception e)
            {
                // when will be exception, program only write information about exception
                Console.WriteLine($"Nastala vyjimka {e.Message}. Program bude ukončen.");
            }
            finally
            {
                // in each case i must close the StreamReader with Close();
                if (readerCompanies != null)
                {
                    readerCompanies.Close();
                }
                if (readerInvoices != null)
                {
                    readerInvoices.Close();
                }
            }
            Console.ReadKey();
        }
    }
}
