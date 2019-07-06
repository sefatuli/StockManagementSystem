using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Models;
using StockManagementSystem.Repository;

namespace StockManagementSystem.BLL
{
    public class ItemManager
    {
        CategoryRepository _categoryRepository = new CategoryRepository();
        CompanyRepository _companyRepositor = new CompanyRepository();
        ItemRepository _itemRepository = new ItemRepository();

        public DataTable LoadCategory()
        {
            return _categoryRepository.Display();
        }
        public DataTable LoadCompany()
        {
            return _companyRepositor.Display();
        }
        public int Insert(Item item)
        {
            return _itemRepository.InsertItem(item);
        }
        public int Update(Item item)
        {
            return _itemRepository.UpdateItem(item);
        }

        public DataTable Search(Item item)
        {
            return _itemRepository.SearchItem(item);
        }
    }
}
