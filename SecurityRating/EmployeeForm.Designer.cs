namespace SecurityRating
{
    partial class EmployeeForm
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
            this.empdataGridView = new System.Windows.Forms.DataGridView();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.security_blanksDataSet = new SecurityRating.security_blanksDataSet();
            this.employeesTableAdapter = new SecurityRating.security_blanksDataSetTableAdapters.EmployeesTableAdapter();
            this.EmpAddButton = new System.Windows.Forms.Button();
            this.EmpEditButton = new System.Windows.Forms.Button();
            this.EmpDeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.empdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.security_blanksDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // empdataGridView
            // 
            this.empdataGridView.AutoGenerateColumns = false;
            this.empdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lnameDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.mnameDataGridViewTextBoxColumn});
            this.empdataGridView.DataSource = this.employeesBindingSource;
            this.empdataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.empdataGridView.Location = new System.Drawing.Point(0, 0);
            this.empdataGridView.Name = "empdataGridView";
            this.empdataGridView.Size = new System.Drawing.Size(343, 247);
            this.empdataGridView.TabIndex = 0;
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // mnameDataGridViewTextBoxColumn
            // 
            this.mnameDataGridViewTextBoxColumn.DataPropertyName = "mname";
            this.mnameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.mnameDataGridViewTextBoxColumn.Name = "mnameDataGridViewTextBoxColumn";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.security_blanksDataSet;
            // 
            // security_blanksDataSet
            // 
            this.security_blanksDataSet.DataSetName = "security_blanksDataSet";
            this.security_blanksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // EmpAddButton
            // 
            this.EmpAddButton.Location = new System.Drawing.Point(12, 253);
            this.EmpAddButton.Name = "EmpAddButton";
            this.EmpAddButton.Size = new System.Drawing.Size(95, 23);
            this.EmpAddButton.TabIndex = 1;
            this.EmpAddButton.Text = "Добавить";
            this.EmpAddButton.UseVisualStyleBackColor = true;
            this.EmpAddButton.Click += new System.EventHandler(this.EmpAddButton_Click);
            // 
            // EmpEditButton
            // 
            this.EmpEditButton.Location = new System.Drawing.Point(123, 253);
            this.EmpEditButton.Name = "EmpEditButton";
            this.EmpEditButton.Size = new System.Drawing.Size(95, 23);
            this.EmpEditButton.TabIndex = 2;
            this.EmpEditButton.Text = "Редактировать";
            this.EmpEditButton.UseVisualStyleBackColor = true;
            this.EmpEditButton.Click += new System.EventHandler(this.EmpEditButton_Click);
            // 
            // EmpDeleteButton
            // 
            this.EmpDeleteButton.Location = new System.Drawing.Point(236, 253);
            this.EmpDeleteButton.Name = "EmpDeleteButton";
            this.EmpDeleteButton.Size = new System.Drawing.Size(95, 23);
            this.EmpDeleteButton.TabIndex = 3;
            this.EmpDeleteButton.Text = "Удалить";
            this.EmpDeleteButton.UseVisualStyleBackColor = true;
            this.EmpDeleteButton.Click += new System.EventHandler(this.EmpDeleteButton_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 284);
            this.Controls.Add(this.EmpDeleteButton);
            this.Controls.Add(this.EmpEditButton);
            this.Controls.Add(this.EmpAddButton);
            this.Controls.Add(this.empdataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EmployeeForm";
            this.Text = "Реестр сотрудников";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.security_blanksDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView empdataGridView;
        private security_blanksDataSet security_blanksDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private security_blanksDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button EmpAddButton;
        private System.Windows.Forms.Button EmpEditButton;
        private System.Windows.Forms.Button EmpDeleteButton;

    }
}