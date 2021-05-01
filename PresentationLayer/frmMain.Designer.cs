
namespace PresentationLayer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateInvoice = new System.Windows.Forms.Button();
            this.btnViewInvoices = new System.Windows.Forms.Button();
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lblCustomerSearch = new System.Windows.Forms.Label();
            this.lstCustomerView = new System.Windows.Forms.ListView();
            this.colAccountNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnCreateInvoice
            // 
            this.btnCreateInvoice.BackColor = System.Drawing.Color.White;
            this.btnCreateInvoice.Location = new System.Drawing.Point(284, 399);
            this.btnCreateInvoice.Name = "btnCreateInvoice";
            this.btnCreateInvoice.Size = new System.Drawing.Size(176, 52);
            this.btnCreateInvoice.TabIndex = 1;
            this.btnCreateInvoice.Text = "Create Invoice";
            this.btnCreateInvoice.UseVisualStyleBackColor = false;
            this.btnCreateInvoice.Click += new System.EventHandler(this.btnCreateInvoice_Click);
            // 
            // btnViewInvoices
            // 
            this.btnViewInvoices.BackColor = System.Drawing.Color.White;
            this.btnViewInvoices.Location = new System.Drawing.Point(725, 399);
            this.btnViewInvoices.Name = "btnViewInvoices";
            this.btnViewInvoices.Size = new System.Drawing.Size(176, 52);
            this.btnViewInvoices.TabIndex = 2;
            this.btnViewInvoices.Text = "View Invoices";
            this.btnViewInvoices.UseVisualStyleBackColor = false;
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.Location = new System.Drawing.Point(424, 103);
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(265, 35);
            this.txtCustomerSearch.TabIndex = 4;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(498, 530);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(191, 38);
            this.btnAddCustomer.TabIndex = 5;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lblCustomerSearch
            // 
            this.lblCustomerSearch.AutoSize = true;
            this.lblCustomerSearch.Location = new System.Drawing.Point(456, 57);
            this.lblCustomerSearch.Name = "lblCustomerSearch";
            this.lblCustomerSearch.Size = new System.Drawing.Size(199, 29);
            this.lblCustomerSearch.TabIndex = 6;
            this.lblCustomerSearch.Text = "Customer Search";
            // 
            // lstCustomerView
            // 
            this.lstCustomerView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAccountNumber,
            this.colName,
            this.colAddress,
            this.colPhoneNumber});
            this.lstCustomerView.FullRowSelect = true;
            this.lstCustomerView.GridLines = true;
            this.lstCustomerView.HideSelection = false;
            this.lstCustomerView.Location = new System.Drawing.Point(53, 191);
            this.lstCustomerView.Name = "lstCustomerView";
            this.lstCustomerView.Size = new System.Drawing.Size(976, 153);
            this.lstCustomerView.TabIndex = 7;
            this.lstCustomerView.UseCompatibleStateImageBehavior = false;
            this.lstCustomerView.View = System.Windows.Forms.View.Details;
           
            // 
            // colAccountNumber
            // 
            this.colAccountNumber.Text = "Account Number";
            this.colAccountNumber.Width = 199;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 257;
            // 
            // colAddress
            // 
            this.colAddress.Text = "Address";
            this.colAddress.Width = 293;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.Text = "Phone Number";
            this.colPhoneNumber.Width = 235;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1135, 631);
            this.Controls.Add(this.lstCustomerView);
            this.Controls.Add(this.lblCustomerSearch);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.txtCustomerSearch);
            this.Controls.Add(this.btnViewInvoices);
            this.Controls.Add(this.btnCreateInvoice);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NS Invoice Portal";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreateInvoice;
        private System.Windows.Forms.Button btnViewInvoices;
        private System.Windows.Forms.TextBox txtCustomerSearch;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblCustomerSearch;
        private System.Windows.Forms.ListView lstCustomerView;
        private System.Windows.Forms.ColumnHeader colAccountNumber;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.ColumnHeader colPhoneNumber;
    }
}

