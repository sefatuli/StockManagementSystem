using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Models;

namespace StockManagementSystem.Repository
{
    public class CompanyRepository
    {
        string connectionString = @"Server=FARHAD\MSSQLSERVER_F; Database=StockManagementDB;User ID=sa;Password=farhad; Integrated Security=True";
        SqlConnection sqlConnection;

        string commandString;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;


        public CompanyRepository()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public int Insert(Company company)
        {
            int isExecuted = 0;
            try
            {
                commandString = @"INSERT INTO Companies (Name) VALUES('" + company.Name + "')";
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;

                sqlConnection.Open();
                isExecuted = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return isExecuted;
        }

        public int Update(Company company)
        {
            int isExecuted = 0;
            try
            {
                //2
                sqlCommand = new SqlCommand();
                commandString = "UPDATE Companies SET Name =  '" + company.Name + "' WHERE ID = " + company.ID + "";
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                isExecuted = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return isExecuted;
        }
        public DataTable Display()
        {
            try
            {

                commandString = @"SELECT * FROM Companies";
                sqlCommand = new SqlCommand(commandString, sqlConnection);
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter();

                sqlDataAdapter.SelectCommand = sqlCommand;
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return dataTable;
        }

        public DataTable SearchCat(Company company)
        {
            commandString = @"SELECT * FROM Companies WHERE Name LIKE '%" + company.Name + "%'";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;

        }
    }
}
