using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class StockOutDomain
    {
        private int id;
        private int itemId;
        private int qty;
        private string status;
        private string date;


        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public int ItemID
        {
            get { return itemId; }
            set { itemId = value; }
        }
        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public String Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Item { get; set; }
        public string Company { get; set; }
        public string Category { get; set; }
        public string ReorderLevel { get; set; }

    }
}
