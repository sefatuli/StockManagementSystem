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
    public partial class Company_Setup : Form
    {
        Company company;
        CompanyManager companyManager;
        public Company_Setup()
        {
            InitializeComponent();
            company = new Company();
            companyManager = new CompanyManager();
        }

        private void Company_Setup_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string name = "";
            if (SaveButton.Text.Equals("Save"))
            {
                name = companynameTextBox.Text;
                if (String.IsNullOrEmpty(name))
                {
                    messageLabel.Text = "Name Field is Empty";
                    return;
                }
                Insert(name);
            }
            else
            {
                name = companynameTextBox.Text;
                if (String.IsNullOrEmpty(name))
                {
                    messageLabel.Text = "Name Field is Empty";
                    return;
                }
                Update(name);
                SaveButton.Text = "Save";
            }
            companynameTextBox.Text = "";
            Display();
        }

        private void Insert(string name)
        {

            company.Name = name;
            DataTable data = companyManager.SearchCat(company);
            if (data.Rows.Count == 0)
            {
                int isExecuted = 0;
                isExecuted = companyManager.Insert(company);
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
            company.Name = name;
            int isExecuted = 0;
            isExecuted = companyManager.Update(company);
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
            companydataGridView.DataSource = companyManager.Display(company);
            foreach (DataGridViewRow row in companydataGridView.Rows)
                row.Cells["SL"].Value = (row.Index + 1).ToString();
            companydataGridView.RowHeadersVisible = false;

        }

       

        private void companydataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (companydataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                companydataGridView.CurrentRow.Selected = true;
                companynameTextBox.Text = companydataGridView.Rows[e.RowIndex].Cells["nameDataGridViewTextBoxColumn"].FormattedValue.ToString();
                company.ID = Convert.ToInt32(companydataGridView.Rows[e.RowIndex].Cells["iDDataGridViewTextBoxColumn"].FormattedValue);
                SaveButton.Text = "Update";
            }
        }
    }
}
