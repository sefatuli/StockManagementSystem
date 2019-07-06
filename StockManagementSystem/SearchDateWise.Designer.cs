namespace StockManagementSystem
{
    partial class SearchDateWise
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
            this.components = new System.ComponentModel.Container();
            this.fromdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.todateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.soldradioButton = new System.Windows.Forms.RadioButton();
            this.damagedradioButton = new System.Windows.Forms.RadioButton();
            this.lostradioButton = new System.Windows.Forms.RadioButton();
            this.searchbutton = new System.Windows.Forms.Button();
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.stockOutDomainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutDomainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fromdateTimePicker
            // 
            this.fromdateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.fromdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromdateTimePicker.Location = new System.Drawing.Point(259, 34);
            this.fromdateTimePicker.Name = "fromdateTimePicker";
            this.fromdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fromdateTimePicker.TabIndex = 0;
            // 
            // todateTimePicker
            // 
            this.todateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.todateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.todateTimePicker.Location = new System.Drawing.Point(259, 87);
            this.todateTimePicker.Name = "todateTimePicker";
            this.todateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.todateTimePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To Date";
            // 
            // soldradioButton
            // 
            this.soldradioButton.AutoSize = true;
            this.soldradioButton.Location = new System.Drawing.Point(179, 157);
            this.soldradioButton.Name = "soldradioButton";
            this.soldradioButton.Size = new System.Drawing.Size(46, 17);
            this.soldradioButton.TabIndex = 4;
            this.soldradioButton.TabStop = true;
            this.soldradioButton.Text = "Sold";
            this.soldradioButton.UseVisualStyleBackColor = true;
            // 
            // damagedradioButton
            // 
            this.damagedradioButton.AutoSize = true;
            this.damagedradioButton.Location = new System.Drawing.Point(287, 157);
            this.damagedradioButton.Name = "damagedradioButton";
            this.damagedradioButton.Size = new System.Drawing.Size(71, 17);
            this.damagedradioButton.TabIndex = 5;
            this.damagedradioButton.TabStop = true;
            this.damagedradioButton.Text = "Damaged";
            this.damagedradioButton.UseVisualStyleBackColor = true;
            // 
            // lostradioButton
            // 
            this.lostradioButton.AutoSize = true;
            this.lostradioButton.Location = new System.Drawing.Point(411, 157);
            this.lostradioButton.Name = "lostradioButton";
            this.lostradioButton.Size = new System.Drawing.Size(45, 17);
            this.lostradioButton.TabIndex = 6;
            this.lostradioButton.TabStop = true;
            this.lostradioButton.Text = "Lost";
            this.lostradioButton.UseVisualStyleBackColor = true;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(387, 200);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 7;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // showDataGridView
            // 
            this.showDataGridView.AutoGenerateColumns = false;
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn});
            this.showDataGridView.DataSource = this.stockOutDomainBindingSource;
            this.showDataGridView.Location = new System.Drawing.Point(111, 229);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.Size = new System.Drawing.Size(425, 150);
            this.showDataGridView.TabIndex = 8;
            // 
            // stockOutDomainBindingSource
            // 
            this.stockOutDomainBindingSource.DataSource = typeof(StockManagementSystem.Models.StockOutDomain);
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Sold/Damaged/Lost Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // SearchDateWise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showDataGridView);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.lostradioButton);
            this.Controls.Add(this.damagedradioButton);
            this.Controls.Add(this.soldradioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.todateTimePicker);
            this.Controls.Add(this.fromdateTimePicker);
            this.Name = "SearchDateWise";
            this.Text = "SearchDateWise";
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutDomainBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fromdateTimePicker;
        private System.Windows.Forms.DateTimePicker todateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton soldradioButton;
        private System.Windows.Forms.RadioButton damagedradioButton;
        private System.Windows.Forms.RadioButton lostradioButton;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.BindingSource stockOutDomainBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
    }
}