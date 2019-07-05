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
    public partial class Item_Setup : Form
    {
        private Item_Setup itemSetup;

        public Item_Setup()
        {
            InitializeComponent();
            itemSetup = new Item_Setup();
           // itemSetUpManager = new ItemSetUpManager();

        }

        //private void Item_Setup_Load(object sender, EventArgs e)
        //{
        //    Display();
        //}

        

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string name = "";
            if (SaveButton.Text.Equals("Save"))
            {
                name = itemnameTextBox.Text;
                if(String.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Name Field is Empty");
                }
               // Insert(name);

            }
        }

       
    }
}
