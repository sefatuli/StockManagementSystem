using StockManagementSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Models;

namespace StockManagementSystem
{
    public partial class StockIn : Form
    {
        StockManager _stockManager = new StockManager();
        private StockInDomain stockIn;
        public StockIn()
        {
            InitializeComponent();
            stockIn = new StockInDomain();
        }

        private void StockIn_Load(object sender, EventArgs e)
        {
            categoryComboBox.DataSource = _stockManager.LoadCategory();
            companyComboBox.DataSource = _stockManager.LoadCompany();
        }

        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (companyComboBox.Text != "")
                itemComboBox.DataSource = _stockManager.LoadItem(Convert.ToInt32(categoryComboBox.SelectedValue), Convert.ToInt32(companyComboBox.SelectedValue));
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.Text != "")
                itemComboBox.DataSource = _stockManager.LoadItem(Convert.ToInt32(categoryComboBox.SelectedValue), Convert.ToInt32(companyComboBox.SelectedValue));
        }

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable itemdt = _stockManager.LoadItem(Convert.ToInt32(itemComboBox.SelectedValue));

            if (itemdt.Rows.Count > 0)
            {
                reoederTextBox.Text = itemdt.Rows[0]["ReorderLevel"].ToString();
                availableqntyTextBox.Text = itemdt.Rows[0]["AvailableQty"].ToString();
            }
            stockinDataGridView.DataSource = _stockManager.LoadStock(Convert.ToInt32(itemComboBox.SelectedValue));
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            stockIn.ItemID = Convert.ToInt32(itemComboBox.SelectedValue);
            stockIn.InQty = Convert.ToInt32(stockinqntyTextBox.Text);
            stockIn.Date = DateTime.Now.ToString("yyyy-MM-dd");

            int isExecuted;
            isExecuted = _stockManager.InsertStockIn(stockIn);
            if (isExecuted > 0)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved!!");
            }
        }
    }
}
