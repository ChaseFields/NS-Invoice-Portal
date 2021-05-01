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

        private InvoiceAccessor _invoiceAccessor = new InvoiceAccessor();
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
                CustomerList = _customerAccessor.RetrieveSavedCustomers();

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
