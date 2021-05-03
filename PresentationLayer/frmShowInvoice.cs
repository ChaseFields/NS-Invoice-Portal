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
    public partial class frmShowInvoice : Form
    {
        Validator validataor = null;
        int _customerIndex;
        int _invoiceIndex;
        List<Invoice> selectedCustomerInvoices;
       
        public frmShowInvoice(Validator v, int customerIndex, int invoiceIndex)
        {
            validataor = v;
            _customerIndex = customerIndex;
            _invoiceIndex = invoiceIndex;
            selectedCustomerInvoices = validataor.GetSpecificInvoices(_customerIndex);
            InitializeComponent();

        }


        private void frmShowInvoice_Load(object sender, EventArgs e)
        {
            // set customer info on invoice.
            lblAccountNumber.Text = validataor.CustomerList[_customerIndex].AccountNumber.ToString();
            lblCustomerAddress.Text = validataor.CustomerList[_customerIndex].Address;
            lblCustomerPhone.Text = validataor.CustomerList[_customerIndex].Phone;
            lblCustomerName.Text = validataor.CustomerList[_customerIndex].Name;
            lblInvoiceNumber.Text = selectedCustomerInvoices[_invoiceIndex].InvoiceNumber.ToString();

            // rebuild invoice form from invoice object
            chkGranularApplication.Checked = selectedCustomerInvoices[_invoiceIndex].Granular;
            chkLiquidApplication.Checked = selectedCustomerInvoices[_invoiceIndex].Liquid;
            chkSpot.Checked = selectedCustomerInvoices[_invoiceIndex].Spot;

            if(selectedCustomerInvoices[_invoiceIndex].SpotPercentage != 0)
            {
                txtSpot.Text = selectedCustomerInvoices[_invoiceIndex].SpotPercentage.ToString();
            }
            chkBlanket.Checked = selectedCustomerInvoices[_invoiceIndex].Blanket;
            chkFrick34.Checked = selectedCustomerInvoices[_invoiceIndex].Frick34;
            chkGranico.Checked = selectedCustomerInvoices[_invoiceIndex].Granico34;
            chkNaturescape.Checked = selectedCustomerInvoices[_invoiceIndex].Naturescape363;
            chkFrick15.Checked = selectedCustomerInvoices[_invoiceIndex].Frick15;
            chkCavalcadeWFert.Checked = selectedCustomerInvoices[_invoiceIndex].CavalcadeWFert;
            chkCavalcadeWoutFert.Checked = selectedCustomerInvoices[_invoiceIndex].Cavalcade4L;
            chkProdiamine.Checked = selectedCustomerInvoices[_invoiceIndex].Prodiamine;
            chkTriad.Checked = selectedCustomerInvoices[_invoiceIndex].Triad;
            txtPropertyComments.Text = selectedCustomerInvoices[_invoiceIndex].PropertyComments;
            txtServiceComments.Text = selectedCustomerInvoices[_invoiceIndex].ServiceComments;
        }
    }
}
