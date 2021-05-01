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
        private string customerPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//NSCustomers//";
        private string filename = "customers.txt";


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
              
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
                lstCustomerView.Items[i].SubItems.Add(validator.
                    CustomerList[i].Address);
                lstCustomerView.Items[i].SubItems.Add(validator.CustomerList[i].Phone);
            }
        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
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
            
            frmAddInvoice frmAddInvoice = new frmAddInvoice(validator, index);
            DialogResult result = frmAddInvoice.ShowDialog();
        }
    }
}
