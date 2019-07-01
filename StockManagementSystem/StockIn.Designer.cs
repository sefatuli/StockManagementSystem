namespace StockManagementSystem
{
    partial class StockIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.availableQuantityTextBox = new System.Windows.Forms.TextBox();
            this.stockInQuantityTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Reoder Level";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Available Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Stock In Quantity";
            // 
            // companyComboBox
            // 
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(135, 36);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(190, 21);
            this.companyComboBox.TabIndex = 7;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(135, 79);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(190, 21);
            this.categoryComboBox.TabIndex = 8;
            // 
            // itemComboBox
            // 
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(135, 118);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(190, 21);
            this.itemComboBox.TabIndex = 9;
            // 
            // reorderLevelTextBox
            // 
            this.reorderLevelTextBox.Location = new System.Drawing.Point(135, 177);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.Size = new System.Drawing.Size(190, 20);
            this.reorderLevelTextBox.TabIndex = 10;
            // 
            // availableQuantityTextBox
            // 
            this.availableQuantityTextBox.Location = new System.Drawing.Point(135, 222);
            this.availableQuantityTextBox.Name = "availableQuantityTextBox";
            this.availableQuantityTextBox.Size = new System.Drawing.Size(190, 20);
            this.availableQuantityTextBox.TabIndex = 11;
            // 
            // stockInQuantityTextBox
            // 
            this.stockInQuantityTextBox.Location = new System.Drawing.Point(135, 269);
            this.stockInQuantityTextBox.Name = "stockInQuantityTextBox";
            this.stockInQuantityTextBox.Size = new System.Drawing.Size(190, 20);
            this.stockInQuantityTextBox.TabIndex = 12;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(417, 282);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.Item,
            this.Date,
            this.Quantity,
            this.Action});
            this.dataGridView.Location = new System.Drawing.Point(172, 333);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(546, 143);
            this.dataGridView.TabIndex = 14;
            // 
            // Sl
            // 
            this.Sl.HeaderText = "Sl No.";
            this.Sl.Name = "Sl";
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            // 
            // StockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 488);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.stockInQuantityTextBox);
            this.Controls.Add(this.availableQuantityTextBox);
            this.Controls.Add(this.reorderLevelTextBox);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StockIn";
            this.Text = "StockIn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.TextBox reorderLevelTextBox;
        private System.Windows.Forms.TextBox availableQuantityTextBox;
        private System.Windows.Forms.TextBox stockInQuantityTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
    }
}