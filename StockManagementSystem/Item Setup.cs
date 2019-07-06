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
using StockManagementSystem.Models;

namespace StockManagementSystem
{
    public partial class Item_Setup : Form
    {
        ItemManager _itemManager = new ItemManager();
        private Item item;
        public Item_Setup()
        {
            InitializeComponent();
            item = new Item();
        }

        private void Item_Setup_Load(object sender, EventArgs e)
        {
            categoryComboBox.DataSource = _itemManager.LoadCategory();
            companyComboBox.DataSource = _itemManager.LoadCompany();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            item.Name = itemnameTextBox.Text;
            item.ReorderLevel = Convert.ToInt32(reorderTextBox.Text);
            item.CategoryID = Convert.ToInt32(categoryComboBox.SelectedValue);
            item.CompanyID = Convert.ToInt32(companyComboBox.SelectedValue);

            DataTable dt = _itemManager.Search(item);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("You are trying to save a duplicate item!");
                return;
            }

            int isExecuted;
            isExecuted = _itemManager.Insert(item);
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
