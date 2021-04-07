
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
            this.lstCustomerList = new System.Windows.Forms.ListBox();
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lblCustomerSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateInvoice
            // 
            this.btnCreateInvoice.BackColor = System.Drawing.Color.White;
            this.btnCreateInvoice.Location = new System.Drawing.Point(197, 409);
            this.btnCreateInvoice.Name = "btnCreateInvoice";
            this.btnCreateInvoice.Size = new System.Drawing.Size(176, 52);
            this.btnCreateInvoice.TabIndex = 1;
            this.btnCreateInvoice.Text = "Create Invoice";
            this.btnCreateInvoice.UseVisualStyleBackColor = false;
            // 
            // btnViewInvoices
            // 
            this.btnViewInvoices.BackColor = System.Drawing.Color.White;
            this.btnViewInvoices.Location = new System.Drawing.Point(573, 409);
            this.btnViewInvoices.Name = "btnViewInvoices";
            this.btnViewInvoices.Size = new System.Drawing.Size(176, 52);
            this.btnViewInvoices.TabIndex = 2;
            this.btnViewInvoices.Text = "View Invoices";
            this.btnViewInvoices.UseVisualStyleBackColor = false;
            // 
            // lstCustomerList
            // 
            this.lstCustomerList.FormattingEnabled = true;
            this.lstCustomerList.ItemHeight = 29;
            this.lstCustomerList.Location = new System.Drawing.Point(334, 232);
            this.lstCustomerList.Name = "lstCustomerList";
            this.lstCustomerList.Size = new System.Drawing.Size(265, 91);
            this.lstCustomerList.TabIndex = 3;
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.Location = new System.Drawing.Point(334, 122);
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(265, 35);
            this.txtCustomerSearch.TabIndex = 4;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(684, 561);
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
            this.lblCustomerSearch.Location = new System.Drawing.Point(365, 78);
            this.lblCustomerSearch.Name = "lblCustomerSearch";
            this.lblCustomerSearch.Size = new System.Drawing.Size(199, 29);
            this.lblCustomerSearch.TabIndex = 6;
            this.lblCustomerSearch.Text = "Customer Search";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(932, 631);
            this.Controls.Add(this.lblCustomerSearch);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.txtCustomerSearch);
            this.Controls.Add(this.lstCustomerList);
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
        private System.Windows.Forms.ListBox lstCustomerList;
        private System.Windows.Forms.TextBox txtCustomerSearch;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblCustomerSearch;
    }
}

