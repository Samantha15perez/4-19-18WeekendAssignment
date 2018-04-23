namespace WeekendAssignment
{
    partial class Form1
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
            this.comboBoxCustomerName = new System.Windows.Forms.ComboBox();
            this.dataGridActiveCustomers = new System.Windows.Forms.DataGridView();
            this.textBoxSalesOrderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActiveCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCustomerName
            // 
            this.comboBoxCustomerName.FormattingEnabled = true;
            this.comboBoxCustomerName.Location = new System.Drawing.Point(12, 12);
            this.comboBoxCustomerName.Name = "comboBoxCustomerName";
            this.comboBoxCustomerName.Size = new System.Drawing.Size(266, 21);
            this.comboBoxCustomerName.TabIndex = 0;
            this.comboBoxCustomerName.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomerName_SelectedIndexChanged);
            // 
            // dataGridActiveCustomers
            // 
            this.dataGridActiveCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridActiveCustomers.Location = new System.Drawing.Point(12, 49);
            this.dataGridActiveCustomers.Name = "dataGridActiveCustomers";
            this.dataGridActiveCustomers.Size = new System.Drawing.Size(776, 301);
            this.dataGridActiveCustomers.TabIndex = 1;
            this.dataGridActiveCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridActiveCustomers_CellContentClick);
            // 
            // textBoxSalesOrderID
            // 
            this.textBoxSalesOrderID.Location = new System.Drawing.Point(498, 13);
            this.textBoxSalesOrderID.Name = "textBoxSalesOrderID";
            this.textBoxSalesOrderID.Size = new System.Drawing.Size(181, 20);
            this.textBoxSalesOrderID.TabIndex = 2;
            this.textBoxSalesOrderID.TextChanged += new System.EventHandler(this.textBoxSalesOrderID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SalesOrderID:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(616, 365);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(126, 38);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSalesOrderID);
            this.Controls.Add(this.dataGridActiveCustomers);
            this.Controls.Add(this.comboBoxCustomerName);
            this.Name = "Form1";
            this.Text = "Sales Orders";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActiveCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCustomerName;
        private System.Windows.Forms.DataGridView dataGridActiveCustomers;
        private System.Windows.Forms.TextBox textBoxSalesOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpdate;
    }
}

