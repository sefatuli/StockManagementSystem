namespace StockManagementSystem
{
    partial class Category_Setup
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
            this.catnameTextBox = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.categorydataGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.categorydataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(379, 125);
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
            this.label1.Location = new System.Drawing.Point(151, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // catnameTextBox
            // 
            this.catnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catnameTextBox.Location = new System.Drawing.Point(226, 81);
            this.catnameTextBox.Name = "catnameTextBox";
            this.catnameTextBox.Size = new System.Drawing.Size(228, 22);
            this.catnameTextBox.TabIndex = 2;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(499, 84);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 16);
            this.messageLabel.TabIndex = 4;
            // 
            // categorydataGridView
            // 
            this.categorydataGridView.AutoGenerateColumns = false;
            this.categorydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categorydataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.categorydataGridView.DataSource = this.categoryBindingSource;
            this.categorydataGridView.Location = new System.Drawing.Point(154, 209);
            this.categorydataGridView.Name = "categorydataGridView";
            this.categorydataGridView.Size = new System.Drawing.Size(244, 150);
            this.categorydataGridView.TabIndex = 5;
            this.categorydataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categorydataGridView_CellContentClick);
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
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(StockManagementSystem.Models.Category);
            // 
            // Category_Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 439);
            this.Controls.Add(this.categorydataGridView);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.catnameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButton);
            this.Name = "Category_Setup";
            this.Text = "Category_Setup";
            this.Load += new System.EventHandler(this.Category_Setup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categorydataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox catnameTextBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.DataGridView categorydataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoryBindingSource;
    }
}