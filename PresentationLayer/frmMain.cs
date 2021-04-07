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
    public partial class frmMain : Form
    {

        private List<Customer> _customers = new List<Customer>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtCustomerSearch.Text = "Search Customer Name";
            txtCustomerSearch.ForeColor = Color.LightGray;

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm form = new AddCustomerForm();
            form.Show();
        }
    }
}
