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
    public class StockManager
    {
        CategoryRepository _categoryRepository = new CategoryRepository();
        CompanyRepository _companyRepositor = new CompanyRepository();
        ItemRepository _itemRepository = new ItemRepository();
        StockRepository _stockRepository = new StockRepository();

        public DataTable LoadCategory()
        {
            return _categoryRepository.Display();
        }
        public DataTable LoadCompany()
        {
            return _companyRepositor.Display();
        }
        public DataTable LoadItem(int catID, int comID)
        {
            return _itemRepository.SearchItem(catID, comID);
        }
        public DataTable LoadItem(int itemID)
        {
            return _itemRepository.LoadItem(itemID);
        }
        public DataTable LoadStock(int itemID)
        {
            return _stockRepository.LoadStock(itemID);
        }
        public int InsertStockIn(StockInDomain stock)
        {
            return _stockRepository.InsertStockIn(stock);
        }
        public int InsertStockOut(List<StockOutDomain> stockOutList)
        {
            return _stockRepository.InsertStockOut(stockOutList);
        }

        public DataTable SearchItem(int catID,int comID)
        {
            return _stockRepository.SearchItem(catID,comID);
        }
        public DataTable SearchItem(string type, DateTime fdate, DateTime tdate)
        {
            return _stockRepository.SearchItem(type, fdate, tdate);
        }
    }
}
