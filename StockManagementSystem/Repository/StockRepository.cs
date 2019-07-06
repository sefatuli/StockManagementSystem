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
    public class StockRepository
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Server=FARHAD\MSSQLSERVER_F; Database=StockManagementDB;User ID=sa;Password=farhad; Integrated Security=True");

        private string commandString;
        private SqlCommand sqlCommand;

        public DataTable LoadStock(int itemID)
        {
            commandString = @"SELECT I.Name AS Item,S.* FROM StockIn S INNER JOIN Item I ON S.ItemID=I.ID WHERE S.ItemID=" + itemID;
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;

        }

        public int InsertStockIn(StockInDomain stock)
        {
            commandString = @"INSERT INTO StockIn (ItemID, InQty, Date) VALUES (" + stock.ItemID + ", " + stock.InQty + ", '" + stock.Date+ "')";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            return isExecuted;
        }

        public int InsertStockOut(List<StockOutDomain> stockOutList)
        {
            foreach(StockOutDomain stock in stockOutList)
            {
                commandString += @"INSERT INTO StockOut (ItemID, Qty,Status, Date) VALUES (" + stock.ItemID + ", " + stock.Qty + ", '" + stock.Status + "', '" + stock.Date + "')" + Environment.NewLine;
            }
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            return isExecuted;
        }

        //public int UpdateStock(StockIn stock)
        //{
        //    commandString = @"UPDATE StockIn SET Name='" + item.Name + "', ReorderLevel=" + item.ReorderLevel + ", CategoryID=" + item.CategoryID + ", CompanyID=" + item.CompanyID + " Where ID=" + item.ID;
        //    sqlCommand = new SqlCommand(commandString, sqlConnection);

        //    sqlConnection.Open();
        //    int isExecuted;
        //    isExecuted = sqlCommand.ExecuteNonQuery();

        //    sqlConnection.Close();
        //    return isExecuted;
        //}

        public DataTable SearchItem(int catID,int comID)
        {
            string clause = " WHERE ";
            if (catID > 0 && comID > 0)
                clause += "I.CategoryID=" + catID + " AND " + "I.CompanyID=" + comID;
            else if (catID > 0)
                clause += "I.CategoryID=" + catID;
            else
                clause += "I.CompanyID=" + comID;

            commandString = @"SELECT I.ID,I.Name AS Item,CO.Name AS Company,CA.Name AS Category,(Sum(Isnull(InQty,0))-Sum(Isnull(Qty,0))) As Qty,I.ReorderLevel FROM Item I
                            INNER JOIN Categories CA ON I.CategoryID=CA.ID
                            INNER JOIN Companies CO ON CO.ID=I.CompanyID
                            LEFT JOIN StockIn SI ON SI.ItemID=I.ID
                            LEFT JOIN StockOut SO ON SO.ItemID=I.ID"
                            + clause +
                            " GROUP BY I.ID,I.Name,CO.Name,CA.Name,I.ReorderLevel";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;

        }

        public DataTable SearchItem(string type,DateTime fdate,DateTime tdate)
        {
            commandString = @"SELECT I.ID,I.Name As Item,C.Name As Company, Sum(SO.Qty) AS Qty FROM Item I
                            INNER JOIN Companies C ON I.CompanyID=C.ID
                            LEFT JOIN StockOut SO ON SO.ItemID=I.ID
                            WHERE SO.Status='"+type+"' AND (CAST(SO.Date as date) Between '"+fdate+"' and '"+tdate+"') GROUP BY I.ID,I.Name,C.Name";
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
