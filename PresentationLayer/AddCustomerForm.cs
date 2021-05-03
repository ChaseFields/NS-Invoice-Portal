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


            if(txtPhoneNumber.Text.Trim(' ').Length != 12)
            {
                MessageBox.Show("Enter a valid phone number. (555-555-5555)");
                txtPhoneNumber.Focus();
                return;
            }
            if(validator.IsAlreadyCustomer(txtName.Text, txtAddress.Text))
            {
                MessageBox.Show("This customer is already in the customer list.");
                return;
            }
       

            Customer customer = new Customer(txtName.Text, txtAddress.Text, txtPhoneNumber.Text, validator.CustomerList.Count + 1) ;

            validator.SaveCustomerData(customer);
            validator.CustomerList.Add(customer);
           
            txtName.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
            MessageBox.Show("The customer was added.");
            this.DialogResult = DialogResult.Yes;
        } 

        private void txtPhoneNumber_Enter(object sender, EventArgs e)
        {
            txtPhoneNumber.Text = " ";
            txtPhoneNumber.ForeColor = Color.Black;
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            txtPhoneNumber.Text = "xxx-xxx-xxxx";
            txtPhoneNumber.ForeColor = Color.DarkGray;
        }
    } // end of AddCustomerForm
} // end of PresentationLayer
