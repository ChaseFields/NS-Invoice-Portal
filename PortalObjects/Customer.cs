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
        private int _accountNumber;

        public Customer(string name, string address, string phone, int accountNumber)
        {
            _name = name;
            _address = address;
            _phone = phone;
            _accountNumber = accountNumber;
            
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

        public int AccountNumber
        {
            get
            {
                return _accountNumber;
            }
            set
            {
                _accountNumber = value;
            }
        }



    } // end of Customer
} // end of PortalObjects
