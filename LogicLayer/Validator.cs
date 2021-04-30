using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortalObjects;
using DataAccessLayer;



namespace LogicLayer
{
    public class Validator
    {
        private CustomerAccessor _customerAccessor = null;

        public Validator()
        {
            try
            {
                if (_customerAccessor == null)
                {
                    _customerAccessor = new CustomerAccessor();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }



        public bool SaveCustomerData(Customer customer)
        {


            try
            {
                _customerAccessor.SaveCustomerToList(customer);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Customer> RestoreCustomerData()
        {
            List<Customer> customers;

            try
            {
                customers = _customerAccessor.RetrieveSavedCustomers();
            }
            catch (Exception)
            {

                throw;
            }

            return customers;
        }
        public bool IsAlreadyCustomer(string name, string address)
        {

            List<Customer> customers = _customerAccessor.RetrieveSavedCustomers();

            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Name == name && customers[i].Address == address)
                {

                    return true;
                }
            }
            return false;
        }

        /*
        public string CreateAccountNumber()
        {
            
            string accountNumber;
            List<Customer> customers = _customerAccessor.RetrieveSavedCustomers();
            Random random = new Random();
            int min = 1;
            int max = 10000;
            accountNumber = random.Next(min, max).ToString();
            foreach(Customer customer in customers)
            {
                if(customer.AccountNumber == accountNumber)
                {
                    accountNumber = random.Next(min, max).ToString();
                }
            }
            return accountNumber;
        }
        */
    }
}
