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
    public class ItemSetUpRepository
    {
     
            string connectionString = @"Server=DESKTOP-LNRI3TI; Database=StockManagementDB; 
                      Integrated Security=True";
            SqlConnection sqlConnection;

            string commandString;
            SqlCommand sqlCommand;
         SqlDataAdapter sqlDataAdapter;
            DataTable dataTable;

            public ItemSetUpRepository()
            {
                sqlConnection = new SqlConnection(connectionString);
            }
        public int Insert(Item_Setup item_Setup)
        {
            int isExecuted = 0;
            try
            {
                commandString = @"INSERT INTO Item_Setup (Name) VALUES('" + item_Setup.Name + "')";
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


    }
}
