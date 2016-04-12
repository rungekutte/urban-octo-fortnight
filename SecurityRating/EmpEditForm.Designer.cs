namespace SecurityRating
{
    partial class EmpEditForm
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
            this.empEditbuttonCancel = new System.Windows.Forms.Button();
            this.empEditbuttonOK = new System.Windows.Forms.Button();
            this.empFnamelabel = new System.Windows.Forms.Label();
            this.empMnamelabel = new System.Windows.Forms.Label();
            this.empLnamelabel = new System.Windows.Forms.Label();
            this.empFnametextBox = new System.Windows.Forms.TextBox();
            this.empLnametextBox = new System.Windows.Forms.TextBox();
            this.empMnametextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // empEditbuttonCancel
            // 
            this.empEditbuttonCancel.Location = new System.Drawing.Point(180, 101);
            this.empEditbuttonCancel.Name = "empEditbuttonCancel";
            this.empEditbuttonCancel.Size = new System.Drawing.Size(75, 23);
            this.empEditbuttonCancel.TabIndex = 15;
            this.empEditbuttonCancel.Text = "Отмена";
            this.empEditbuttonCancel.UseVisualStyleBackColor = true;
            this.empEditbuttonCancel.Click += new System.EventHandler(this.empEditbuttonCancel_Click);
            // 
            // empEditbuttonOK
            // 
            this.empEditbuttonOK.Location = new System.Drawing.Point(88, 101);
            this.empEditbuttonOK.Name = "empEditbuttonOK";
            this.empEditbuttonOK.Size = new System.Drawing.Size(75, 23);
            this.empEditbuttonOK.TabIndex = 14;
            this.empEditbuttonOK.Text = "OK";
            this.empEditbuttonOK.UseVisualStyleBackColor = true;
            this.empEditbuttonOK.Click += new System.EventHandler(this.empEditbuttonOK_Click);
            // 
            // empFnamelabel
            // 
            this.empFnamelabel.AutoSize = true;
            this.empFnamelabel.Location = new System.Drawing.Point(53, 41);
            this.empFnamelabel.Name = "empFnamelabel";
            this.empFnamelabel.Size = new System.Drawing.Size(29, 13);
            this.empFnamelabel.TabIndex = 13;
            this.empFnamelabel.Text = "Имя";
            // 
            // empMnamelabel
            // 
            this.empMnamelabel.AutoSize = true;
            this.empMnamelabel.Location = new System.Drawing.Point(28, 67);
            this.empMnamelabel.Name = "empMnamelabel";
            this.empMnamelabel.Size = new System.Drawing.Size(54, 13);
            this.empMnamelabel.TabIndex = 12;
            this.empMnamelabel.Text = "Отчество";
            // 
            // empLnamelabel
            // 
            this.empLnamelabel.AutoSize = true;
            this.empLnamelabel.Location = new System.Drawing.Point(26, 12);
            this.empLnamelabel.Name = "empLnamelabel";
            this.empLnamelabel.Size = new System.Drawing.Size(56, 13);
            this.empLnamelabel.TabIndex = 11;
            this.empLnamelabel.Text = "Фамилия";
            // 
            // empFnametextBox
            // 
            this.empFnametextBox.Location = new System.Drawing.Point(88, 38);
            this.empFnametextBox.Name = "empFnametextBox";
            this.empFnametextBox.Size = new System.Drawing.Size(167, 20);
            this.empFnametextBox.TabIndex = 9;
            // 
            // empLnametextBox
            // 
            this.empLnametextBox.Location = new System.Drawing.Point(88, 12);
            this.empLnametextBox.Name = "empLnametextBox";
            this.empLnametextBox.Size = new System.Drawing.Size(167, 20);
            this.empLnametextBox.TabIndex = 8;
            // 
            // empMnametextBox
            // 
            this.empMnametextBox.Location = new System.Drawing.Point(88, 64);
            this.empMnametextBox.Name = "empMnametextBox";
            this.empMnametextBox.Size = new System.Drawing.Size(167, 20);
            this.empMnametextBox.TabIndex = 10;
            // 
            // EmpEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 143);
            this.Controls.Add(this.empEditbuttonCancel);
            this.Controls.Add(this.empEditbuttonOK);
            this.Controls.Add(this.empFnamelabel);
            this.Controls.Add(this.empMnamelabel);
            this.Controls.Add(this.empLnamelabel);
            this.Controls.Add(this.empFnametextBox);
            this.Controls.Add(this.empLnametextBox);
            this.Controls.Add(this.empMnametextBox);
            this.Name = "EmpEditForm";
            this.Text = "Изменение данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button empEditbuttonCancel;
        private System.Windows.Forms.Button empEditbuttonOK;
        private System.Windows.Forms.Label empFnamelabel;
        private System.Windows.Forms.Label empMnamelabel;
        private System.Windows.Forms.Label empLnamelabel;
        public System.Windows.Forms.TextBox empFnametextBox;
        public System.Windows.Forms.TextBox empLnametextBox;
        public System.Windows.Forms.TextBox empMnametextBox;
        private security_blanksDataSet security_blanksDataSet;
        private System.Windows.Forms.BindingSource security_blanksBindingSource;
        private security_blanksDataSetTableAdapters.EmployeesTableAdapter EmployeesTableAdapter;
    }
}