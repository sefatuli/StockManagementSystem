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
    public partial class Category_Setup : Form
    {
        Category category;

        CategoryManager categoryManager;
        public Category_Setup()
        {
            InitializeComponent();
            category = new Category();
            categoryManager = new CategoryManager();

        }

        private void Category_Setup_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string name = "";
            if (SaveButton.Text.Equals("Save"))
            {
                name = catnameTextBox.Text;
                if (String.IsNullOrEmpty(name))
                {
                    messageLabel.Text = "Name Field is Empty";
                    return;
                }
                Insert(name);
            }
            else
            {
                name = catnameTextBox.Text;
                if (String.IsNullOrEmpty(name))
                {
                    messageLabel.Text = "Name Field is Empty";
                    return;
                }
                Update(name);
                SaveButton.Text = "Save";
            }
            catnameTextBox.Text = "";
            Display();
        }

        private void Insert(string name)
        {

            category.Name = name;
            DataTable data = categoryManager.SearchCat(category);
            if (data.Rows.Count == 0)
            {
                int isExecuted = 0;
                isExecuted = categoryManager.Insert(category);
                if (isExecuted > 0)
                {
                    messageLabel.Text = "Saved Successfully";
                }
                else
                {
                    messageLabel.Text = "Save Failed!";
                }
            }
            else
            {
                messageLabel.Text = "Category Already Exist";
            }

        }
        private void Update(string name)
        {
            category.Name = name;
            int isExecuted = 0;
            isExecuted = categoryManager.Update(category);
            if (isExecuted > 0)
            {
                messageLabel.Text = "Updated Successfully";
            }
            else
            {
                messageLabel.Text = "Update Failed!";
            }
        }
        private void Display()
        {
            categorydataGridView.DataSource =categoryManager.Display(category);
            foreach (DataGridViewRow row in categorydataGridView.Rows)
                row.Cells["SL"].Value = (row.Index + 1).ToString();
            categorydataGridView.RowHeadersVisible = false;

        }
        
        private void categorydataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (categorydataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                categorydataGridView.CurrentRow.Selected = true;
                catnameTextBox.Text = categorydataGridView.Rows[e.RowIndex].Cells["nameDataGridViewTextBoxColumn"].FormattedValue.ToString();
                category.ID= Convert.ToInt32(categorydataGridView.Rows[e.RowIndex].Cells["iDDataGridViewTextBoxColumn"].FormattedValue);
                SaveButton.Text = "Update";
            }
        }
    }
}
