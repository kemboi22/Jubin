using System;
using System.Windows.Forms;

namespace JubinHouse1
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }


        private void Clients_Load(object sender, EventArgs e)
        {
            CommonFunctions.LoadDataGrid(AllData, "Client");
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Client (`Client ID`, `Client First name`, `Client Last Name`, `Client Street address`, `Client Zip code`, `Client City`, `Client State`)" +
                           " VALUES ('"+textBox1.Text+"','"+textBox3.Text+"','"+textBox2.Text+"','"+textBox8.Text+"','"+textBox7.Text+"','"+textBox6.Text+"','"+textBox5.Text+"')";
            CommonFunctions.Insert(query);
            CommonFunctions.LoadDataGrid(AllData, "Client");
        }
    }
}