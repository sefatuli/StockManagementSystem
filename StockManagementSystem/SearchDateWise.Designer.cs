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
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOutDomainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutDomainBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fromdateTimePicker
            // 
            this.fromdateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.fromdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromdateTimePicker.Location = new System.Drawing.Point(216, 26);
            this.fromdateTimePicker.Name = "fromdateTimePicker";
            this.fromdateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.fromdateTimePicker.TabIndex = 0;
            // 
            // todateTimePicker
            // 
            this.todateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.todateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.todateTimePicker.Location = new System.Drawing.Point(217, 66);
            this.todateTimePicker.Name = "todateTimePicker";
            this.todateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.todateTimePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "From Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "To Date";
            // 
            // soldradioButton
            // 
            this.soldradioButton.AutoSize = true;
            this.soldradioButton.Location = new System.Drawing.Point(141, 104);
            this.soldradioButton.Name = "soldradioButton";
            this.soldradioButton.Size = new System.Drawing.Size(54, 21);
            this.soldradioButton.TabIndex = 4;
            this.soldradioButton.TabStop = true;
            this.soldradioButton.Text = "Sold";
            this.soldradioButton.UseVisualStyleBackColor = true;
            // 
            // damagedradioButton
            // 
            this.damagedradioButton.AutoSize = true;
            this.damagedradioButton.Location = new System.Drawing.Point(249, 104);
            this.damagedradioButton.Name = "damagedradioButton";
            this.damagedradioButton.Size = new System.Drawing.Size(87, 21);
            this.damagedradioButton.TabIndex = 5;
            this.damagedradioButton.TabStop = true;
            this.damagedradioButton.Text = "Damaged";
            this.damagedradioButton.UseVisualStyleBackColor = true;
            // 
            // lostradioButton
            // 
            this.lostradioButton.AutoSize = true;
            this.lostradioButton.Location = new System.Drawing.Point(373, 104);
            this.lostradioButton.Name = "lostradioButton";
            this.lostradioButton.Size = new System.Drawing.Size(53, 21);
            this.lostradioButton.TabIndex = 6;
            this.lostradioButton.TabStop = true;
            this.lostradioButton.Text = "Lost";
            this.lostradioButton.UseVisualStyleBackColor = true;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(341, 139);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 36);
            this.searchbutton.TabIndex = 7;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // showDataGridView
            // 
            this.showDataGridView.AutoGenerateColumns = false;
            this.showDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn});
            this.showDataGridView.DataSource = this.stockOutDomainBindingSource;
            this.showDataGridView.Location = new System.Drawing.Point(125, 206);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.Size = new System.Drawing.Size(462, 150);
            this.showDataGridView.TabIndex = 8;
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
            // stockOutDomainBindingSource
            // 
            this.stockOutDomainBindingSource.DataSource = typeof(StockManagementSystem.Models.StockOutDomain);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lostradioButton);
            this.groupBox1.Controls.Add(this.fromdateTimePicker);
            this.groupBox1.Controls.Add(this.searchbutton);
            this.groupBox1.Controls.Add(this.todateTimePicker);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.damagedradioButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.soldradioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(125, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 181);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // SearchDateWise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showDataGridView);
            this.Name = "SearchDateWise";
            this.Text = "Date Wise Report Summary";
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutDomainBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}