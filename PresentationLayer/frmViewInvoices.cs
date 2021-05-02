using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using PortalObjects;

namespace PresentationLayer
{
    public partial class frmViewInvoices : Form
    {
        Validator validator = null;
        int current_index;
        List<Invoice> specificInvoices = new List<Invoice>();
        public frmViewInvoices(Validator v, int index)
        {
            validator = v;
            current_index = index;
            specificInvoices = validator.GetSpecificInvoices(current_index);
            InitializeComponent();
        }

        private void frmViewInvoices_Load(object sender, EventArgs e)
        {
          
            lblAccountNumber.Text = validator.CustomerList[current_index].AccountNumber.ToString();
            lblAddress.Text = validator.CustomerList[current_index].Address;
            lblName.Text = validator.CustomerList[current_index].Name;
            lblPhone.Text = validator.CustomerList[current_index].Phone;

            populateInvoiceView();
        }

        private void populateInvoiceView()
        {
           
            for(int i = 0; i < specificInvoices.Count; i++)
            {
                lstInvoices.Items.Add(specificInvoices[i].AccountNumber.ToString());
                lstInvoices.Items[i].SubItems.Add(specificInvoices[i].Date);
                lstInvoices.Items[i].SubItems.Add("$39.00");
            }
        }
    }
}
