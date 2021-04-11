using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using PortalObjects;

namespace DataAccessLayer
{
    public class CustomerAccessor
    {
        private string customerPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private string customerFolder = "NSCustomers";
        private string filename = "customers.bin";
        private List<Customer> customers = new List<Customer>();


        // The constructor creates the save location
        public CustomerAccessor()
        {
            string path = customerPath + "\\" + customerFolder ;

            try
            {
                if(!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SaveCustomerToList(Customer customer)
        {
            string path = customerPath + "\\" + customerFolder + "\\" + filename;
            
    
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            
            try
             {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
                customers.Add(customer);
                formatter.Serialize(stream, customers);
                stream.Close();
             }
             catch (Exception)
             {
                throw;
             }
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                var customers = (List<Customer>)formatter.Deserialize(stream);
                String name = customers[0].Name;

            }
            catch (Exception)
            {

                throw;
            }
        
        }
    }
}
