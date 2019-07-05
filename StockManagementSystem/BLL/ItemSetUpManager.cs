using StockManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Models;
namespace StockManagementSystem.BLL
{
    class ItemSetUpManager
    {
        ItemSetUpRepository itemSetUpRepository;

        public ItemSetUpManager()
        {
            itemSetUpRepository = new ItemSetUpRepository();
        }

        public int Insert(Item_Setup item_Setup)
        {
            return itemSetUpRepository.Insert(item_Setup);
        }
    }
}
