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
    class CompanyManager
    {
        CompanyRepository companyRepository;

        public CompanyManager()
        {
            companyRepository = new CompanyRepository();
        }

        public int Update(Company company)
        {
            return companyRepository.Update(company);
        }
        public int Insert(Company company)
        {
            return companyRepository.Insert(company);
        }
        public DataTable Display(Company company)
        {
            return companyRepository.Display();
        }

        public DataTable SearchCat(Company company)
        {
            return companyRepository.SearchCat(company);
        }
    }
}
