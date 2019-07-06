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
    public partial class SearchDateWise : Form
    {
        StockManager _stockManager = new StockManager();
        public SearchDateWise()
        {
            InitializeComponent();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            DateTime fromDate = Convert.ToDateTime(fromdateTimePicker.Value.ToShortDateString());
            DateTime toDate = Convert.ToDateTime(todateTimePicker.Value.ToShortDateString());

            if (soldradioButton.Checked)
            {
                dt = _stockManager.SearchItem("Sold", fromDate, toDate);
            }
            if (damagedradioButton.Checked)
            {
                dt = _stockManager.SearchItem("Damage", fromDate, toDate);
            }
            if (lostradioButton.Checked)
            {
                dt = _stockManager.SearchItem("Lost", fromDate, toDate);
            }


            if (dt.Rows.Count > 0)
            {
                showDataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No data fount!");
            }
        }
    }
}
