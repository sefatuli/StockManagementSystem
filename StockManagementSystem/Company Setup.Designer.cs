namespace StockManagementSystem
{
    partial class Company_Setup
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.companynameTextBox = new System.Windows.Forms.TextBox();
            this.companydataGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companydataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(331, 135);
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
            this.label1.Location = new System.Drawing.Point(96, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company Name";
            // 
            // companynameTextBox
            // 
            this.companynameTextBox.Location = new System.Drawing.Point(199, 83);
            this.companynameTextBox.Name = "companynameTextBox";
            this.companynameTextBox.Size = new System.Drawing.Size(207, 20);
            this.companynameTextBox.TabIndex = 2;
            // 
            // companydataGridView
            // 
            this.companydataGridView.AutoGenerateColumns = false;
            this.companydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companydataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.companydataGridView.DataSource = this.companyBindingSource;
            this.companydataGridView.Location = new System.Drawing.Point(90, 213);
            this.companydataGridView.Name = "companydataGridView";
            this.companydataGridView.Size = new System.Drawing.Size(244, 150);
            this.companydataGridView.TabIndex = 3;
            this.companydataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.companydataGridView_CellContentClick);
            // 
            // SL
            // 
            this.SL.DataPropertyName = "ID";
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(StockManagementSystem.Models.Company);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(517, 86);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 13);
            this.messageLabel.TabIndex = 4;
            // 
            // Company_Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.companydataGridView);
            this.Controls.Add(this.companynameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButton);
            this.Name = "Company_Setup";
            this.Text = "Company_Setup";
            this.Load += new System.EventHandler(this.Company_Setup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companydataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox companynameTextBox;
        private System.Windows.Forms.DataGridView companydataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.Label messageLabel;
    }
}