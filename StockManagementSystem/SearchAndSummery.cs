using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.BLL;

namespace StockManagementSystem
{
    public partial class SearchAndSummery : Form
    {
        StockManager _stockManager = new StockManager();
        public SearchAndSummery()
        {
            InitializeComponent();
        }

        private void SearchAndSummery_Load(object sender, EventArgs e)
        {
            categoryComboBox.DataSource = _stockManager.LoadCategory();
            companyComboBox.DataSource = _stockManager.LoadCompany();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataTable dt = _stockManager.SearchItem(Convert.ToInt32(categoryComboBox.SelectedValue), Convert.ToInt32(companyComboBox.SelectedValue));
            if (dt.Rows.Count > 0)
            {
                resultDataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No data found!");
            }
        }
    }
}
