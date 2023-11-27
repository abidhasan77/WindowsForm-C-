using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseryDataAccessLayer.Operations
{
  public  class OTesting
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9RFDGE4;Initial Catalog=TheNurseryManagementSystem;Integrated Security=True");
        public DataTable TestIDPasword(string id, string password)
        {
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from TEmployee where ID = '" + id + "' and Passwoard = '" + password + "'", connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }

        public bool AvailablitiyIDPassword(string id, string password)
        {
            bool flag;

            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from TEmployee where ID = '" + id + "' and Passwoard = '" + password + "'", connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                flag = true;
            }

            else
            {
                flag = false;
            }
            connection.Close();
            return flag;
        }
    }
}
