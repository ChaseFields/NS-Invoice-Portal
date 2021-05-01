using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PortalObjects;
using System.Reflection;

namespace DataAccessLayer
{
    public class InvoiceAccessor
    {
        private string invoicePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\NSCustomers\\";
        private string filename = "invoices.txt";

        public InvoiceAccessor()
        {
            if(!File.Exists(invoicePath + filename))
            {
                File.Create(invoicePath + filename);
            }
        }

        public void SaveInvoiceToFile(Invoice invoice)
        {
           
            try
            {
                using (StreamWriter fileWriter = new StreamWriter(invoicePath + filename, true))
                {
       
                   
                    fileWriter.WriteLine(invoice.AccountNumber.ToString() + "\t");

                    fileWriter.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            


        }
    }
}
