using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalObjects
{
    public class Customer
    {
        private string _name;
        private string _address;
        private string _phone;
        private List<Invoice> _invoices = new List<Invoice>();

        public Customer(string name, string address, string phone)
        {
            _name = name;
            _address = address;
            _phone = phone;
        }

        public string Name { get; }

        public string Address { get; }
     
        public string Phone { get; }

        public List<Invoice> Invoices { get; private set; }



    } // end of Customer
} // end of PortalObjects
