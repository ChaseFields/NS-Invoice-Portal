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
        private CustomerAccessor _customerAccessor;
        public bool SaveCustomerData(Customer customer)
        {
            if(_customerAccessor == null)
            {
                _customerAccessor = new CustomerAccessor();
            }

            try
            {
                _customerAccessor.SaveCustomerToList(customer);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public bool IsAlreadyCustomer(List<Customer>customers, string name, string address)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Name == name.ToLower() && customers[i].Address == address.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

    }
}
