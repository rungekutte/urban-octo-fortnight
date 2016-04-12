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
    public partial class EmpEditForm : Form
    {
        public EmpEditForm()
        {
            InitializeComponent();

        }

        private void empEditbuttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void empEditbuttonOK_Click(object sender, EventArgs e)
        {
     
            this.Close();
        }
    }
}
