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

        private InvoiceAccessor _invoiceAccessor = null;
        public List<Customer> CustomerList { get; private set; }

        public List<Invoice> InvoiceList { get; private set; }

        public Validator()
        {
            try
            {
                if (_customerAccessor == null)
                {
                    _customerAccessor = new CustomerAccessor();
                }
                if(_invoiceAccessor == null)
                {
                    _invoiceAccessor = new InvoiceAccessor();
                }
                CustomerList = _customerAccessor.RetrieveSavedCustomers();
               
                InvoiceList = _invoiceAccessor.RetrieveInvoices();

            }
            catch (Exception ex)
            {

                throw ex;
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

        public bool SaveInvoiceData(Invoice invoice)
        {
            try
            {
                _invoiceAccessor.SaveInvoiceToFile(invoice);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Invoice> GetSpecificInvoices(int index)
        {
            List<Invoice> specificCustomerInvoices = new List<Invoice>();
            for(int i = 0; i < InvoiceList.Count; i++)
            {
                if(InvoiceList[i].AccountNumber == index + 1)
                {
                    specificCustomerInvoices.Add(InvoiceList[i]);
                }
            }

            return specificCustomerInvoices;
        }

 
        /*
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
        */

    }
}
