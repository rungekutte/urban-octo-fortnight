using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityRating
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm empform = new EmployeeForm();
            empform.Show();
        }
    }
}
