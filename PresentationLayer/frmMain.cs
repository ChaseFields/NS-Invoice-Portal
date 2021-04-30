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

        private List<Customer> _customers = new List<Customer>();
        private Validator validator = new Validator();
        private string customerPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//NSCustomers//";
        private string filename = "customers.txt";


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            txtCustomerSearch.Text = "Search Customer Name";
            txtCustomerSearch.ForeColor = Color.LightGray;

           
            try
            {
             
                _customers = validator.RestoreCustomerData();
                DisplayCustomerList(_customers);
    
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("There was a problem loading the customer list." + "\n\n" + ex.Message);
            } 
            
         }
             

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            _customers = validator.RestoreCustomerData();
            AddCustomerForm addCustomerForm = new AddCustomerForm(validator);
            
        }

        
        private void DisplayCustomerList(List<Customer> customers)
        {
            lstCustomerView.Items.Clear();

            for (int i = 0; i < customers.Count; i++)
            {
                lstCustomerView.Items.Add(customers[i].Name);
                lstCustomerView.Items[i].SubItems.Add(customers[i].Address);
                lstCustomerView.Items[i].SubItems.Add(customers[i].Phone);
                lstCustomerView.Items[i].SubItems.Add(customers[i].AccountNumber.ToString());
            }
        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {

        }
    }
}
