
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
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateInvoice
            // 
            this.btnCreateInvoice.BackColor = System.Drawing.SystemColors.Control;
            this.btnCreateInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateInvoice.ForeColor = System.Drawing.Color.Black;
            this.btnCreateInvoice.Location = new System.Drawing.Point(286, 419);
            this.btnCreateInvoice.Name = "btnCreateInvoice";
            this.btnCreateInvoice.Size = new System.Drawing.Size(156, 54);
            this.btnCreateInvoice.TabIndex = 1;
            this.btnCreateInvoice.Text = "Create Invoice";
            this.btnCreateInvoice.UseVisualStyleBackColor = false;
            this.btnCreateInvoice.Click += new System.EventHandler(this.btnCreateInvoice_Click);
            // 
            // btnViewInvoices
            // 
            this.btnViewInvoices.BackColor = System.Drawing.SystemColors.Control;
            this.btnViewInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInvoices.ForeColor = System.Drawing.Color.Black;
            this.btnViewInvoices.Location = new System.Drawing.Point(677, 417);
            this.btnViewInvoices.Name = "btnViewInvoices";
            this.btnViewInvoices.Size = new System.Drawing.Size(146, 56);
            this.btnViewInvoices.TabIndex = 2;
            this.btnViewInvoices.Text = "View Invoices";
            this.btnViewInvoices.UseVisualStyleBackColor = false;
            this.btnViewInvoices.Click += new System.EventHandler(this.btnViewInvoices_Click);
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.Location = new System.Drawing.Point(427, 81);
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(265, 35);
            this.txtCustomerSearch.TabIndex = 4;
            this.txtCustomerSearch.Enter += new System.EventHandler(this.txtCustomerSearch_Enter);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnAddCustomer.Location = new System.Drawing.Point(478, 528);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(147, 49);
            this.btnAddCustomer.TabIndex = 5;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lblCustomerSearch
            // 
            this.lblCustomerSearch.AutoSize = true;
            this.lblCustomerSearch.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerSearch.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCustomerSearch.Location = new System.Drawing.Point(466, 13);
            this.lblCustomerSearch.Name = "lblCustomerSearch";
            this.lblCustomerSearch.Size = new System.Drawing.Size(226, 32);
            this.lblCustomerSearch.TabIndex = 6;
            this.lblCustomerSearch.Text = "NS Invoice Portal";
            // 
            // lstCustomerView
            // 
            this.lstCustomerView.BackColor = System.Drawing.SystemColors.InactiveCaption;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "Naturescape";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.ForestGreen;
            this.label8.Location = new System.Drawing.Point(12, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Lawn and Landscape Care";
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnCustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerSearch.ForeColor = System.Drawing.Color.Black;
            this.btnCustomerSearch.Location = new System.Drawing.Point(712, 81);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(111, 27);
            this.btnCustomerSearch.TabIndex = 14;
            this.btnCustomerSearch.Text = "Search";
            this.btnCustomerSearch.UseVisualStyleBackColor = false;
            this.btnCustomerSearch.Click += new System.EventHandler(this.btnCustomerSearch_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1157, 631);
            this.Controls.Add(this.btnCustomerSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCustomerSearch;
    }
}

