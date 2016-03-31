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
        }



        private void EmpDeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
