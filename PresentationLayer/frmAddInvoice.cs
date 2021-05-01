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
    public partial class frmAddInvoice : Form
    {
        private int current_index;
        private Validator validator = null;
        public frmAddInvoice(Validator v, int index)
        {
            validator = v;
            current_index = index;
            
            InitializeComponent();
        }

        private void frmAddInvoice_Load(object sender, EventArgs e)
        {
            lblCustomerName.Text = validator.CustomerList[current_index].Name;
            lblAccountNumber.Text = validator.CustomerList[current_index].AccountNumber.ToString();
            lblCustomerAddress.Text = validator.CustomerList[current_index].Address;
            lblCustomerPhone.Text = validator.CustomerList[current_index].Phone;
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();

            invoice.AccountNumber = current_index;
          
            if(chkGranularApplication.Checked)
            {
                invoice.Granular = true;
            }
            if(chkLiquidApplication.Checked)
            {
                invoice.Liquid = true;
            }
            if(chkSpot.Checked && txtSpot.Text == "")
            {
                MessageBox.Show("You must enter a percentage if you checked a spot spray.");
                return;
            }
            if(chkSpot.Checked)
            {
                invoice.Spot = true;
                invoice.SpotPercentage = int.Parse(txtSpot.Text);
            }
            if(chkBlanket.Checked)
            {
                invoice.Blanket = true;
            }
            if(chkFrick34.Checked)
            {
                invoice.Frick34 = true;
            }
            if(chkFrick15.Checked)
            {
                invoice.Frick15 = true;
            }
            if(chkGranico.Checked)
            {
                invoice.Granico34 = true;
            }
            if(chkNaturescape.Checked)
            {
                invoice.Naturescape363 = true;
            }
            if(chkCavalcadeWFert.Checked)
            {
                invoice.CavalcadeWFert = true;
            }
            if(chkCavalcadeWoutFert.Checked)
            {
                invoice.Cavalcade4L = true;
            }
            if(chkProdiamine.Checked)
            {
                invoice.Prodiamine = true;
            }
            if(chkTriad.Checked)
            {
                invoice.Triad = true;
            }

            invoice.ServiceComments = txtServiceComments.Text;
            invoice.PropertyComments = txtPropertyComments.Text;

            validator.SaveInvoiceData(invoice);
        }
    }
}
