namespace StockManagementSystem
{
    partial class Item_Setup
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.itemnameTextBox = new System.Windows.Forms.TextBox();
            this.reorderTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(294, 240);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Company";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Reorder Level";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Stationary",
            "Electronics",
            "Home Appliance",
            "Mobile",
            "TV",
            "Fridge",
            "Food"});
            this.categoryComboBox.Location = new System.Drawing.Point(210, 52);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(159, 21);
            this.categoryComboBox.TabIndex = 5;
            // 
            // companyComboBox
            // 
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Items.AddRange(new object[] {
            "RFL",
            "Uniliver",
            "Samsung",
            "Walton",
            "Kazi Farms"});
            this.companyComboBox.Location = new System.Drawing.Point(210, 95);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(159, 21);
            this.companyComboBox.TabIndex = 6;
            // 
            // itemnameTextBox
            // 
            this.itemnameTextBox.Location = new System.Drawing.Point(210, 142);
            this.itemnameTextBox.Name = "itemnameTextBox";
            this.itemnameTextBox.Size = new System.Drawing.Size(159, 20);
            this.itemnameTextBox.TabIndex = 7;
            // 
            // reorderTextBox
            // 
            this.reorderTextBox.Location = new System.Drawing.Point(210, 197);
            this.reorderTextBox.Name = "reorderTextBox";
            this.reorderTextBox.Size = new System.Drawing.Size(159, 20);
            this.reorderTextBox.TabIndex = 8;
            // 
            // Item_Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 345);
            this.Controls.Add(this.reorderTextBox);
            this.Controls.Add(this.itemnameTextBox);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButton);
            this.Name = "Item_Setup";
            this.Text = "Item_Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.TextBox itemnameTextBox;
        private System.Windows.Forms.TextBox reorderTextBox;
    }
}