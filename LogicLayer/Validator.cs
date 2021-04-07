using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortalObjects;


namespace LogicLayer
{
    public class Validator
    {
        public bool IsAlreadyCustomer(List<Customer> customers, string name, string address)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if(customers[i].Name == name.ToLower() && customers[i].Address == address.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

    }
}
