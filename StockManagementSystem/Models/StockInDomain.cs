using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class StockInDomain
    {
        private int id;
        private int itemId;
        private int inQty;
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
        public int InQty
        {
            get { return inQty; }
            set { inQty = value; }
        }
        public String Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Item { get; set; }
    }
}
