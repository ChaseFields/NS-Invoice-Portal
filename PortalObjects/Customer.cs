using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalObjects
{
    [Serializable]
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

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
        }

        public string Phone
        {
            get
            {
                return _phone;
            }
        }

        public List<Invoice> Invoices
        {
            get
            {
                return _invoices;
            }
            set
            {
                _invoices = value;
            }
        }



    } // end of Customer
} // end of PortalObjects
