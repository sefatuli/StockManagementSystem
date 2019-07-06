using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class Item
    {
        private int id;
        private string name;
        private int reorderLevel;
        private int categoryId;
        private int companyId;


        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int ReorderLevel
        {
            get { return reorderLevel; }
            set { reorderLevel = value; }
        }
        public int CategoryID
        {
            get { return categoryId; }
            set { categoryId = value; }
        }
        public int CompanyID
        {
            get { return companyId; }
            set { companyId = value; }
        }
    }
}
