using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WeekendAssignment
{
    public partial class Form1 : Form
    {
        SqlStoredProcedures dataWorks = new SqlStoredProcedures();

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridActiveCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridActiveCustomers.Rows[e.RowIndex];
                textBoxSalesOrderID.Text = row.Cells[0].Value.ToString();
            }
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //int CustomerID = int.Parse(textBoxSalesOrderID.Text.ToString());

                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            const string connString = @"Server=PL8\MTCDB;Database=AdventureWorks2012;Trusted_Connection=True;User ID=AdvWorks2012;Password=123456;";
            SqlConnection sqlConn = new SqlConnection(connString);

            dataGridActiveCustomers.DataSource = dataWorks.dtSODBCPREVIEW();



            SqlDataAdapter sqlDa = new SqlDataAdapter("NameAndCustomerid", sqlConn);
                DataTable dtNameAndCustomerID = new DataTable();
                int CustomerID;
                string CustomerName;

                try
                {
                    sqlDa.Fill(dtNameAndCustomerID);

                    foreach (DataRow drNameAndCustomerID in dtNameAndCustomerID.Rows)
                    {
                        CustomerID = int.Parse(drNameAndCustomerID.ItemArray[1].ToString());
                        CustomerName = drNameAndCustomerID.ItemArray[0].ToString();
                        comboBoxCustomerName.Items.Add(new cboObject(CustomerID, CustomerName));
                        
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error ...");
                }
            
        }

        public class cboObject
        {
            int cID;
            string cName;

            public cboObject(int CustomerID, string CustomerName)
            {
                cID = CustomerID;
                cName = CustomerName;
            }

            public string CustomerName
            {
                get { return cName; }
                set { cName = value; }
            }

            public int CustomerID
            {
                get { return cID; }
                set { cID = value; }
               
            }

            public override string ToString()
            {
                return this.CustomerName;
                
            }
        }

        private void textBoxSalesOrderID_TextChanged(object sender, EventArgs e)
        {

        }


        private void comboBoxCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                cboObject currentObject = (cboObject)comboBoxCustomerName.SelectedItem;
                int SelectedCustomerID = currentObject.CustomerID;

                try
                {

                    dataGridActiveCustomers.DataSource = dataWorks.dtSalesorderDetailsByCustomer(SelectedCustomerID);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error ...");
                }
            
            }
    } }


