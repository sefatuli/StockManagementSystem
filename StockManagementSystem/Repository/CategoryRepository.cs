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
    public class CategoryRepository
    {
        string connectionString = @"Server=FARHAD\MSSQLSERVER_F; Database=StockManagementDB;User ID=sa;Password=farhad; Integrated Security=True";
        SqlConnection sqlConnection;

        string commandString;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;

        public CategoryRepository()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public int Insert(Category category)
        {
            int isExecuted = 0;
            try
            {
                commandString = @"INSERT INTO Categories (Name) VALUES('" + category.Name + "')";
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

        public int Update(Category category)
        {
            int isExecuted = 0;
            try
            {
                //2
                sqlCommand = new SqlCommand();
                commandString = "UPDATE Categories SET Name =  '" + category.Name + "' WHERE ID = " + category.ID + "";
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

                commandString = @"SELECT * FROM Categories";
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

        public DataTable SearchCat(Category category)
        {
            commandString = @"SELECT * FROM Categories WHERE Name LIKE '%" + category.Name + "%'";
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
