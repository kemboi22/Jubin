using System;
using System.Windows.Forms;

namespace JubinHouse1
{
    public partial class ArchitectDashboard : Form
    {
        public ArchitectDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Projects().Show();
            this.Hide();
        }
    }
}