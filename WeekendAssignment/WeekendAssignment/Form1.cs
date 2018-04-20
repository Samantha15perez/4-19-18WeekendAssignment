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

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int CustomerID = int.Parse(textBoxSalesOrderID.Text.ToString());

                dataGridActiveCustomers.DataSource = dataWorks.dtSalesorderDetailsByCustomer(CustomerID);
                comboBoxCustomerName.DataSource = dataWorks.dtNameAndCustomerid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }
        }

        private void comboBoxCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const string connString = @"Server=PL8\MTCDB;Database=AdventureWorks2012;Trusted_Connection=True;User ID=AdvWorks2012;Password=123456;";
            SqlConnection sqlConn = new SqlConnection(connString);


            //im throwing things around until they work don't judge me

            
                SqlDataAdapter sqlDa = new SqlDataAdapter("NameAndCustomerid", sqlConn);
                DataTable dtNameAndCustomerID = new DataTable();
                int CustomerID;
                string CustomerName;

                try
                {
                    sqlDa.Fill(dtNameAndCustomerID);

                    foreach (DataRow drVendor in dtNameAndCustomerID.Rows)
                    {
                        CustomerID = int.Parse(drVendor.ItemArray[0].ToString());
                        CustomerName = drVendor.ItemArray[1].ToString();
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

    } }


