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
        List<Invoice> specificInvoices;
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
            lstInvoices.Items.Clear();
            for (int i = 0; i < specificInvoices.Count; i++)
            {
                lstInvoices.Items.Add(specificInvoices[i].InvoiceNumber.ToString());
                lstInvoices.Items[i].SubItems.Add(specificInvoices[i].Date);
                lstInvoices.Items[i].SubItems.Add("$39.00");
            }
        }

        private void lstInvoices_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            string invoiceNumber = lstInvoices.SelectedItems[0].Text;
            int invoice_index;

            for (int i = 0; i < specificInvoices.Count; i++)
            {
                if (specificInvoices[i].InvoiceNumber.ToString() == invoiceNumber)
                {
                    invoice_index = i;

                    frmShowInvoice invoiceForm = new frmShowInvoice(validator, current_index, invoice_index);
                    invoiceForm.ShowDialog();
                }

            }
        }
    }
}
