using StockManagementSystem.BLL;
using StockManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class StockOut : Form
    {
        StockManager _stockManager = new StockManager();
        private StockOutDomain stockOut;

        List<StockOutDomain> stockOutList = new List<StockOutDomain>();
        public StockOut()
        {
            InitializeComponent();
            stockOut = new StockOutDomain();
        }

        private void StockOut_Load(object sender, EventArgs e)
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
                reorderLevelTextBox.Text = itemdt.Rows[0]["ReorderLevel"].ToString();
                availableQuantityTextBox.Text = itemdt.Rows[0]["AvailableQty"].ToString();
            }
        }

        private void stockOutAddButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(stockOutQuantityTextBox.Text.Trim()) <= Convert.ToInt32(reorderLevelTextBox.Text.Trim()))
            {
                MessageBox.Show("Please restock " + itemComboBox.Text + "item.");
                stockOutQuantityTextBox.Text = "";
                return;

            }
            StockOutDomain stockOutDomain = new StockOutDomain();

            stockOutDomain.ItemID = Convert.ToInt32(itemComboBox.SelectedValue);
            stockOutDomain.Qty = Convert.ToInt32(stockOutQuantityTextBox.Text);
            stockOutDomain.Item = itemComboBox.Text;
            stockOutDomain.Company = companyComboBox.Text;

            stockOutList.Add(stockOutDomain);

            showDataGridView.DataSource = null;
            showDataGridView.DataSource = stockOutList;
            stockOutQuantityTextBox.Text = "";
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            foreach(StockOutDomain sod in stockOutList)
            {
                sod.Date= DateTime.Now.ToString("yyyy-MM-dd");
                sod.Status = "Sold";
            }

            int isExecuted;
            isExecuted = _stockManager.InsertStockOut(stockOutList);
            if (isExecuted > 0)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved!!");
            }
        }

        private void lostButton_Click(object sender, EventArgs e)
        {
            foreach (StockOutDomain sod in stockOutList)
            {
                sod.Date = DateTime.Now.ToString("yyyy-MM-dd");
                sod.Status = "Lost";
            }

            int isExecuted;
            isExecuted = _stockManager.InsertStockOut(stockOutList);
            if (isExecuted > 0)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved!!");
            }
        }

        private void damageButton_Click(object sender, EventArgs e)
        {
            foreach (StockOutDomain sod in stockOutList)
            {
                sod.Date = DateTime.Now.ToString("yyyy-MM-dd");
                sod.Status = "Damage";
            }

            int isExecuted;
            isExecuted = _stockManager.InsertStockOut(stockOutList);
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
