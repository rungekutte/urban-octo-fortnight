namespace SecurityRating
{
    partial class EmpAddForm
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
            this.security_blanksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.security_blanksDataSet = new SecurityRating.security_blanksDataSet();
            this.EmployeesTableAdapter = new SecurityRating.security_blanksDataSetTableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.security_blanksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.security_blanksDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // myDataTableBindingSource
            // 
            this.security_blanksBindingSource.DataMember = "Employees";
            this.security_blanksBindingSource.DataSource = this.security_blanksDataSet;
            // 
            // myDBDataSet
            // 
            this.security_blanksDataSet.DataSetName = "security_blanksDataSet";
            this.security_blanksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmployeesTableAdapter
            // 
            this.EmployeesTableAdapter.ClearBeforeFill = true;
            //

            this.empLnametextBox = new System.Windows.Forms.TextBox();
            this.empFnametextBox = new System.Windows.Forms.TextBox();
            this.empMnametextBox = new System.Windows.Forms.TextBox();
            this.empLnamelabel = new System.Windows.Forms.Label();
            this.empFnamelabel = new System.Windows.Forms.Label();
            this.empMnamelabel = new System.Windows.Forms.Label();
            this.empAddbuttonOK = new System.Windows.Forms.Button();
            this.empAddbuttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // empLnametextBox
            // 
            this.empLnametextBox.Location = new System.Drawing.Point(77, 19);
            this.empLnametextBox.Name = "empLnametextBox";
            this.empLnametextBox.Size = new System.Drawing.Size(167, 20);
            this.empLnametextBox.TabIndex = 0;
            // 
            // empFnametextBox
            // 
            this.empFnametextBox.Location = new System.Drawing.Point(77, 45);
            this.empFnametextBox.Name = "empFnametextBox";
            this.empFnametextBox.Size = new System.Drawing.Size(167, 20);
            this.empFnametextBox.TabIndex = 1;
            // 
            // empMnametextBox
            // 
            this.empMnametextBox.Location = new System.Drawing.Point(77, 71);
            this.empMnametextBox.Name = "empMnametextBox";
            this.empMnametextBox.Size = new System.Drawing.Size(167, 20);
            this.empMnametextBox.TabIndex = 2;
            // 
            // empLnamelabel
            // 
            this.empLnamelabel.AutoSize = true;
            this.empLnamelabel.Location = new System.Drawing.Point(15, 19);
            this.empLnamelabel.Name = "empLnamelabel";
            this.empLnamelabel.Size = new System.Drawing.Size(56, 13);
            this.empLnamelabel.TabIndex = 3;
            this.empLnamelabel.Text = "Фамилия";
            // 
            // empFnamelabel
            // 
            this.empFnamelabel.AutoSize = true;
            this.empFnamelabel.Location = new System.Drawing.Point(42, 48);
            this.empFnamelabel.Name = "empFnamelabel";
            this.empFnamelabel.Size = new System.Drawing.Size(29, 13);
            this.empFnamelabel.TabIndex = 5;
            this.empFnamelabel.Text = "Имя";
            // 
            // empMnamelabel
            // 
            this.empMnamelabel.AutoSize = true;
            this.empMnamelabel.Location = new System.Drawing.Point(17, 74);
            this.empMnamelabel.Name = "empMnamelabel";
            this.empMnamelabel.Size = new System.Drawing.Size(54, 13);
            this.empMnamelabel.TabIndex = 4;
            this.empMnamelabel.Text = "Отчество";
            // 
            // empAddbuttonOK
            // 
            this.empAddbuttonOK.Location = new System.Drawing.Point(77, 108);
            this.empAddbuttonOK.Name = "empAddbuttonOK";
            this.empAddbuttonOK.Size = new System.Drawing.Size(75, 23);
            this.empAddbuttonOK.TabIndex = 6;
            this.empAddbuttonOK.Text = "OK";
            this.empAddbuttonOK.UseVisualStyleBackColor = true;
            this.empAddbuttonOK.Click += new System.EventHandler(this.empAddbuttonOK_Click);
            // 
            // empAddbuttonCancel
            // 
            this.empAddbuttonCancel.Location = new System.Drawing.Point(169, 108);
            this.empAddbuttonCancel.Name = "empAddbuttonCancel";
            this.empAddbuttonCancel.Size = new System.Drawing.Size(75, 23);
            this.empAddbuttonCancel.TabIndex = 7;
            this.empAddbuttonCancel.Text = "Отмена";
            this.empAddbuttonCancel.UseVisualStyleBackColor = true;
            this.empAddbuttonCancel.Click += new System.EventHandler(this.empAddbuttonCancel_Click);
            // 
            // EmpAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 143);
            this.Controls.Add(this.empAddbuttonCancel);
            this.Controls.Add(this.empAddbuttonOK);
            this.Controls.Add(this.empFnamelabel);
            this.Controls.Add(this.empMnamelabel);
            this.Controls.Add(this.empLnamelabel);
            this.Controls.Add(this.empFnametextBox);
            this.Controls.Add(this.empLnametextBox);
            this.Controls.Add(this.empMnametextBox);
            this.Name = "EmpAddForm";
            this.Text = "Добавление сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private security_blanksDataSet security_blanksDataSet;
        private System.Windows.Forms.BindingSource security_blanksBindingSource;
        private security_blanksDataSetTableAdapters.EmployeesTableAdapter EmployeesTableAdapter;
        private System.Windows.Forms.TextBox empLnametextBox;
        private System.Windows.Forms.TextBox empFnametextBox;
        private System.Windows.Forms.TextBox empMnametextBox;
        private System.Windows.Forms.Label empLnamelabel;
        private System.Windows.Forms.Label empMnamelabel;
        private System.Windows.Forms.Label empFnamelabel;
        private System.Windows.Forms.Button empAddbuttonOK;
        private System.Windows.Forms.Button empAddbuttonCancel;
    }
}