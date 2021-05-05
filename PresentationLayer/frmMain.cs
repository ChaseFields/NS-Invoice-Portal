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
using System.IO;

namespace PresentationLayer
{
    public partial class frmMain : Form
    {
        private Validator validator = new Validator();
        
    
        public frmMain()
        {
            InitializeComponent();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            txtCustomerSearch.Text = "Search By Customer Name.";
            txtCustomerSearch.ForeColor = Color.DarkGray;

            try
            {
             
                DisplayCustomerList();
            }
            catch (Exception ex)
            {

                MessageBox.Show("There was a problem loading the customer list." + "\n\n" + ex.Message);
            } 
            
         }
             

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm(validator);
            DialogResult result = addCustomerForm.ShowDialog();
            if(result == DialogResult.Yes)
            {
                DisplayCustomerList();
            }
            
        }

        
        private void DisplayCustomerList()
        {
            lstCustomerView.Items.Clear();

            
            for (int i = 0; i < validator.CustomerList.Count; i++)
            {
                lstCustomerView.Items.Add(validator.CustomerList[i].AccountNumber.ToString());
                lstCustomerView.Items[i].SubItems.Add(validator.CustomerList[i].Name);
                lstCustomerView.Items[i].SubItems.Add(validator.CustomerList[i].Address);
                lstCustomerView.Items[i].SubItems.Add(validator.CustomerList[i].Phone);
            }
        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            if(lstCustomerView.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select a customer.");
                return;
            }

            string customerAccount = lstCustomerView.SelectedItems[0].Text;
          
            int index = 0;

            for (int i = 0; i < validator.CustomerList.Count; i++)
            {
                if(validator.CustomerList[i].AccountNumber.ToString() == customerAccount)
                {
                    index = i;
                    break;
                }
            }

       
            frmAddInvoice frmAddInvoice = new frmAddInvoice(validator, index);
            DialogResult result = frmAddInvoice.ShowDialog();
        }

        private void btnViewInvoices_Click(object sender, EventArgs e)
        {
  
            if (lstCustomerView.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select a customer.");
                return;
            }

            string customerAccount = lstCustomerView.SelectedItems[0].Text;

            int index = 0;

            for (int i = 0; i < validator.CustomerList.Count; i++)
            {
                if (validator.CustomerList[i].AccountNumber.ToString() == customerAccount)
                {
                    index = i;
                    break;
                }
            }

            if(validator.GetSpecificInvoices(index).Count == 0)
            {
                MessageBox.Show("There are currently no invoices for this customer.");
                return;
            }

            frmViewInvoices frmViewInvoices = new frmViewInvoices(validator, index);
            DialogResult result = frmViewInvoices.ShowDialog();

        }

       
        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (txtCustomerSearch.Text == "")
            {
                return;
            }
            for (int i = 0; i < validator.CustomerList.Count; i++)
            {

                if (validator.CustomerList[i].Name.Equals(txtCustomerSearch.Text))
                {
                    lstCustomerView.Items[i].Selected = true;
                    lstCustomerView.Select();
                    found = true;
                }

            }
            if(!found)
            {
                MessageBox.Show("The customer was not found. You must enter first and last name.");
                txtCustomerSearch.Clear();
                return;
            }
        }

        private void txtCustomerSearch_Enter(object sender, EventArgs e)
        {
            txtCustomerSearch.Text = "";
            txtCustomerSearch.ForeColor = Color.Black;
            for(int i = 0; i < lstCustomerView.Items.Count; i++)
            {
                if(lstCustomerView.Items[i].Selected)
                {
                    lstCustomerView.Items[i].Selected = false;
                }
            }
        }
    }
}
