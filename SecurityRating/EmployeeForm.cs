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
    public partial class EmployeeForm : Form
    {
        private void DeleteEmp()
        {
            DialogResult DeleteEmpDialogResult = MessageBox.Show("Удалить запись?",
            "Подтверждение удаления", MessageBoxButtons.YesNo);
            if (DeleteEmpDialogResult == DialogResult.Yes)
            {
                if (empdataGridView.CurrentRow != null)
                {
                    empdataGridView.Rows.Remove(empdataGridView.CurrentRow);
                }
                OleDbConnection empcon = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;"
                + @"Data source = C:\Users\runge\Documents\GitHub\urban-octo-fortnight\SecurityRating\security_blanks.accdb");
                empcon.Open();
                OleDbDataAdapter empda = new OleDbDataAdapter("select * from Employees", empcon);
                OleDbCommandBuilder empcb = new OleDbCommandBuilder(empda);
                empcon.Close();
                empda.Update(security_blanksDataSet, "Employees");
            }
        }
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'security_blanksDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.security_blanksDataSet.Employees);
        }

        private void EmpEditButton_Click(object sender, EventArgs e)
        {

        }
        private void EmpAddButton_Click(object sender, EventArgs e)
        {
            EmpAddForm employeeAdd = new EmpAddForm();
            employeeAdd.ShowDialog();
            OleDbConnection empcon = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;"
            + @"Data source = C:\Users\runge\Documents\GitHub\urban-octo-fortnight\SecurityRating\security_blanks.accdb");
            empcon.Open();
            OleDbDataAdapter empda = new OleDbDataAdapter("select * from Employees", empcon);
            empda.Fill(security_blanksDataSet.Employees);
            empcon.Close();
        }
        private void EmpDeleteButton_Click(object sender, EventArgs e)
        {
            DeleteEmp();
        }
    }
}
