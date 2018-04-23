using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using WeekendAssignment;


namespace WeekendAssignment
{
    class SqlStoredProcedures
    {
        //double check login information works
        const string connDefault = @"Server=PL8\MTCDB;Database=AdventureWorks2012;Trusted_Connection=True;User ID=AdvWorks2012;Password=123456;";
        SqlConnection sqlConn;

        private bool DBConnect(String ConnectString = "")
        {
            bool returnValue;

            // If no connection string was specified, use the default.
            // if (ConnectionString.Length == 0)
            //     ConnectionString = connDefault;

            try
            {
                // Open the connection to SQL Server. conndefault = AdventureWorks2012
                sqlConn = new SqlConnection(connDefault);
                sqlConn.Open();
                returnValue = true;
            }
            catch (Exception ex)
            {
                // If there was an error, return false and throw it back.
                returnValue = false;
                throw ex;
            }

            return returnValue;
        }


        public DataTable dtNameAndCustomerid()
        {
            DataTable dtNameAndCustomerid = new DataTable();

            try
            {
                if (DBConnect())
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter("NameAndCustomerid", sqlConn);
                    sqlDA.Fill(dtNameAndCustomerid);
                }
                else
                {
                    throw new Exception("Could not load data set.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dtNameAndCustomerid;
        }

        public DataTable dtSalesorderDetailsByCustomer(int CustomerID)
        {
            DataTable dtSalesorderDetailsByCustomer = new DataTable();

            try
            {
                if (DBConnect())
                {
                    SqlCommand InsertSourceCmd = new SqlCommand("SalesOrderDetailsByCustomer", sqlConn);
                    InsertSourceCmd.CommandType = CommandType.StoredProcedure;

                    InsertSourceCmd.Parameters.AddWithValue("@Customerid", CustomerID);

                    SqlDataAdapter ComboBoxDataAdapter = new SqlDataAdapter(InsertSourceCmd);
                    ComboBoxDataAdapter.Fill(dtSalesorderDetailsByCustomer);

                }
                else
                {
                    throw new Exception("Could not load data set.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dtSalesorderDetailsByCustomer;
        }




       

        public DataTable dtSODBCPREVIEW()
        {
            DataTable dtSODBCPREVIEW = new DataTable();

            try
            {
                if (DBConnect())
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter("SODBCPREVIEW", sqlConn);
                    sqlDA.Fill(dtSODBCPREVIEW);
                }
                else
                {
                    throw new Exception("Could not load data set.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dtSODBCPREVIEW;
        }

        


    }
}
