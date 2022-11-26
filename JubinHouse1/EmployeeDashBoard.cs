using System;
using System.Windows.Forms;

namespace JubinHouse1
{
    public partial class EmployeeDashBoard : Form
    {
        public EmployeeDashBoard()
        {
            InitializeComponent();
        }

        private void Projects_Click(object sender, EventArgs e)
        {
            new Projects().Show();
            this.Hide();
        }
    }
}