using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PortalObjects;
using LogicLayer;

namespace PresentationLayer
{
    public partial class AddCustomerForm : Form
    {
        private List<Customer> customers = new List<Customer>();
        private Validator validator = null;


        public AddCustomerForm(Validator v)
        {
            validator = v;

            InitializeComponent();
        } 

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

            if(txtName.Text == "")
            {
                MessageBox.Show("Enter the customer's full name.");
                txtName.Focus();
                return;
            }
            if(txtAddress.Text == "")
            {
                MessageBox.Show("Enter the customer address.");
                txtAddress.Focus();
                return;
            }
            if(txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Enter a valid phone number");
                txtPhoneNumber.Focus();
                return;
            }
            
            if(validator.IsAlreadyCustomer(txtName.Text, txtAddress.Text))
            {
                MessageBox.Show("The customer is already in the customer list.");
                return;
            }


            Customer customer = new Customer(txtName.Text, txtAddress.Text, txtPhoneNumber.Text, validator.RestoreCustomerData().Count + 1) ;

            validator.SaveCustomerData(customer);
           
            txtName.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
            MessageBox.Show("The customer was added.");
        }

  
    } // end of AddCustomerForm
} // end of PresentationLayer
