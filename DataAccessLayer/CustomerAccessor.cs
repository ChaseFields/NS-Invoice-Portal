using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PortalObjects;

namespace DataAccessLayer
{
    public class CustomerAccessor
    {
        private string customerPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\NSCustomers\\";
        private string filename = "customers.txt";
       
        
        public CustomerAccessor()
        {
            string path = customerPath;

            try
            {

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);

                }

                if(!File.Exists(path + filename))
                {
                    File.Create(path + filename);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        
        public void SaveCustomerToList(Customer customer)
        {
           
            try
            {
                using (StreamWriter fileWriter = new StreamWriter(customerPath + filename, true))
                {
                    fileWriter.WriteLine(customer.Name + "\t" +
                                     customer.Address + "\t" +
                                     customer.Phone + "\t" +
                                     customer.AccountNumber.ToString());

                    fileWriter.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }

           
        }

        public List<Customer> RetrieveSavedCustomers()
        {
            List<Customer> customers = new List<Customer>();

            char[] seperators = { '\t' };

            try
            {
                using (StreamReader fileReader = new StreamReader(customerPath + filename))
                {
                    while (!fileReader.EndOfStream)
                    {
                        string line = fileReader.ReadLine();
                        if(line == " ")
                        {
                            continue;
                        }
                       
                        string[] customerFields = line.Split(seperators);


                        string name = customerFields[0];
                        string address = customerFields[1];
                        string phone = customerFields[2];
                        string accountNumber = customerFields[3];

                        Customer customer = new Customer(name, address, phone, int.Parse(accountNumber));
                        customers.Add(customer);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return customers;
        }
    }
}

