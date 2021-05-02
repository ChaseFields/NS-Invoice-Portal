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
            StringBuilder invoiceDataString = new StringBuilder();
            PropertyInfo[] properties = invoice.GetType().GetProperties();
            foreach(PropertyInfo info in properties)
            {
                invoiceDataString.Append(string.Format("{0},{1}:", info.Name, info.GetValue(invoice, null)));
            }

            try
            {
                using (StreamWriter fileWriter = new StreamWriter(invoicePath + filename, true))
                {

                    fileWriter.WriteLine(invoiceDataString.ToString());
                    fileWriter.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Invoice> RetrieveInvoices()
        {
            List<Invoice> invoices = new List<Invoice>();
            
            char[] separators = { ':' };
            
            try
            {
                StreamReader reader = new StreamReader(invoicePath + filename);

                while(!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    
                    if(line == "")
                    {
                        continue;
                    }

                    string[] invoiceFields = line.Split(separators);
                    
                    Invoice invoice = new Invoice();
              

                    invoice.AccountNumber = int.Parse(invoiceFields[0].Substring(invoiceFields[0].IndexOf(",") + 1));
                    
                    invoice.Liquid = bool.Parse(invoiceFields[1].Substring(invoiceFields[1].IndexOf(",") + 1));

                    invoice.Granular = bool.Parse(invoiceFields[2].Substring(invoiceFields[2].IndexOf(",") + 1));

                    invoice.Blanket = bool.Parse(invoiceFields[3].Substring(invoiceFields[3].IndexOf(",") + 1));

                    invoice.Spot = bool.Parse(invoiceFields[4].Substring(invoiceFields[4].IndexOf(",") + 1));

                    invoice.SpotPercentage = int.Parse(invoiceFields[5].Substring(invoiceFields[5].IndexOf(",") + 1));

                    invoice.Frick34 = bool.Parse(invoiceFields[6].Substring(invoiceFields[6].IndexOf(",") + 1));

                    invoice.Frick15 = bool.Parse(invoiceFields[7].Substring(invoiceFields[7].IndexOf(",") + 1));

                    invoice.Granico34 = bool.Parse(invoiceFields[8].Substring(invoiceFields[8].IndexOf(",") + 1));

                    invoice.Naturescape363 = bool.Parse(invoiceFields[9].Substring(invoiceFields[9].IndexOf(",") + 1));

                    invoice.CavalcadeWFert = bool.Parse(invoiceFields[10].Substring(invoiceFields[10].IndexOf(",") + 1));

                    invoice.Cavalcade4L = bool.Parse(invoiceFields[11].Substring(invoiceFields[11].IndexOf(",") + 1));

                    invoice.Prodiamine = bool.Parse(invoiceFields[12].Substring(invoiceFields[12].IndexOf(",") + 1));

                    invoice.Triad = bool.Parse(invoiceFields[13].Substring(invoiceFields[13].IndexOf(",") + 1));

                    invoice.PropertyComments = invoiceFields[14].Substring(invoiceFields[14].IndexOf(",") + 1);

                    invoice.ServiceComments = invoiceFields[15].Substring(invoiceFields[15].IndexOf(",") + 1);

                    invoice.Date = invoiceFields[16].Substring(invoiceFields[16].IndexOf(",") + 1);


                    invoices.Add(invoice);
                }

                reader.Close();
            }

            catch (Exception ex)
            {

                throw ex;
            }
           
            return invoices;
        }
    }
}
