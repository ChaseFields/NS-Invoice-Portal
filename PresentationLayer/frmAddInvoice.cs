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
            lblInvoiceNumber.Text = (validator.InvoiceList.Count + 1).ToString();
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();

            invoice.AccountNumber = current_index + 1;

          
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

            if(!CheckForm())
            {
                return;
            }
            validator.SaveInvoiceData(invoice);
            ClearForm(this);

            MessageBox.Show("The invoice was saved.");
            this.DialogResult = DialogResult.Yes;
        }

        private void ClearForm(Control control)
        {
            
            // return null if typecast is not possible
            CheckBox chk = control as CheckBox;

            // recursively call clear form, until all controls that are checkboxes are cleared. 
            if(chk == null)
            {
                foreach (Control member in control.Controls)
                {
                    ClearForm(member);
                }
            }
            else
            {
                chk.Checked = false;
            }
            
            txtPropertyComments.Clear();
            txtServiceComments.Clear();
            txtSpot.Clear(); 
        }

        private bool CheckForm()
        {
 
            if(!chkBlanket.Checked && !chkLiquidApplication.Checked 
                && !chkGranularApplication.Checked && !chkSpot.Checked)
            {
                MessageBox.Show("You must select an application type.");
                return false;
                
            }

            if(!chkNaturescape.Checked && !chkGranico.Checked && 
                !chkFrick15.Checked && !chkFrick34.Checked)
            {
                MessageBox.Show("You must select a fertilizer application.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
