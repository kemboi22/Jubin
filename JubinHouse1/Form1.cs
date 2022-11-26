using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JubinHouse1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Branches_Click(object sender, EventArgs e)
        {
            new Branches().Show();
            this.Hide();
        }

        private void Projects_Click(object sender, EventArgs e)
        {
            new Projects().Show();
            this.Hide();
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            new Clients().Show();
            this.Hide();
        }

        private void Agents_Click(object sender, EventArgs e)
        {
            new Agents().Show();
            this.Hide();
        }

        private void Architects_Click(object sender, EventArgs e)
        {
            new Architects().Show();
            this.Hide();
        }

        private void Finances_Click(object sender, EventArgs e)
        {
            new Finance().Show();
            this.Hide();
        }

        private void Suppliers_Click(object sender, EventArgs e)
        {
            new Suppliers().Show();
            this.Hide();
        }

        private void States_Click(object sender, EventArgs e)
        {
            new States().Show();
            this.Hide();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}