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
    class CategoryManager
    {
        CategoryRepository categoryRepository;

        public CategoryManager()
        {
            categoryRepository = new CategoryRepository();
        }
        public int Update(Category category)
        {
            return categoryRepository.Update(category);
        }
        public int Insert(Category category)
        {
            return categoryRepository.Insert(category);
        }
        public DataTable Display(Category category)
        {
            return categoryRepository.Display();
        }

        public DataTable SearchCat(Category category)
        {
            return categoryRepository.SearchCat(category);
        }
    }
}
