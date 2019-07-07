using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Models;

namespace StockManagementSystem.Repository
{
    public class ItemRepository
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Server=DESKTOP-1AALRD2; Database=StockManagementDB;User ID=sa;Password=farhad; Integrated Security=True");

        private string commandString;
        private SqlCommand sqlCommand;

        public int InsertItem(Item item)
        {
            commandString = @"INSERT INTO Item (Name, ReorderLevel, CategoryID, CompanyID) VALUES ('" + item.Name + "', " + item.ReorderLevel + ", " + item.CategoryID + ", " + item.CompanyID + ")";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();
                       
            sqlConnection.Close();
            return isExecuted;
        }

        public int UpdateItem(Item item)
        {
            commandString = @"UPDATE Item SET Name='" + item.Name + "', ReorderLevel=" + item.ReorderLevel + ", CategoryID=" + item.CategoryID + ", CompanyID=" + item.CompanyID + " Where ID=" + item.ID;
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            return isExecuted;
        }

        public DataTable SearchItem(Item item)
        {
            commandString = @"SELECT * FROM Item WHERE Name LIKE '%" + item.Name + "%'";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;

        }

        public DataTable SearchItem(int catID,int comID)
        {
            commandString = @"SELECT * FROM Item WHERE CategoryID="+catID+" AND CompanyID="+comID;
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;

        }

        public DataTable LoadItem(int itemID)
        {
            commandString = @"SELECT I.*,(Sum(IsNULL(InQty,0))-Sum(Isnull(Qty,0))) As AvailableQty FROM Item I LEFT JOIN StockIn S ON I.ID=S.ItemID LEFT JOIN StockOut SO ON SO.ItemID=I.ID WHERE I.ID=" + itemID + " GROUP BY I.ID,I.Name,I.ReorderLevel,I.CategoryID,I.CompanyID";
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
