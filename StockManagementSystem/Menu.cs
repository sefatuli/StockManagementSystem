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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category_Setup category_Setup = new Category_Setup();
            category_Setup.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Company_Setup company_Setup = new Company_Setup();
            company_Setup.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Item_Setup item_Setup = new Item_Setup();
            item_Setup.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StockIn stockIn = new StockIn();
            stockIn.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StockOut stockOut = new StockOut();
            stockOut.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SearchAndSummery searchAndSummery = new SearchAndSummery();
            searchAndSummery.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SearchDateWise searchDateWise = new SearchDateWise();
            searchDateWise.ShowDialog();
        }
    }
}
