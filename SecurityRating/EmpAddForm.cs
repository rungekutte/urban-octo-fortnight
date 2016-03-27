using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace SecurityRating
{
    public partial class EmpAddForm : Form
    {
        private void AddEmp()
        {
            OleDbConnection empcon = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;"
            + @"Data source = C:\Users\cpt. runge\Documents\GitHub\objectscheck\SecurityRating\SecurityRating\security_blanks.accdb");
            empcon.Open();
            OleDbDataAdapter empda = new OleDbDataAdapter("select * from Employees", empcon);
            OleDbCommandBuilder empcb = new OleDbCommandBuilder(empda);
            security_blanksDataSet.EmployeesRow newEmp;
            newEmp = security_blanksDataSet.Employees.NewEmployeesRow();
            newEmp.lname = empLnametextBox.Text;
            newEmp.fname = empFnametextBox.Text;
            newEmp.mname = empMnametextBox.Text;
            security_blanksDataSet.Employees.Rows.Add(newEmp);
            empcon.Close();
            empda.Update(security_blanksDataSet, "Employees");
        }
        public EmpAddForm()
        {
            InitializeComponent();
        }

        private void empAddbuttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void empAddbuttonOK_Click(object sender, EventArgs e)
        {
            AddEmp();
            Close();
           
            
        }
    }
}

