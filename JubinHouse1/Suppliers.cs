using System;
using System.Windows.Forms;

namespace JubinHouse1
{
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Suppliers(`Supplier Name`, `Supplier Phone Number`, `Supplier Street Address`, `Supplier State`, `Supplier Zip code`, `Supplier City`) VALUES ('"+textBox2.Text+"','"+textBox8.Text+"','"+textBox7.Text+"','"+textBox6.Text+"','"+textBox5.Text+"','"+textBox1.Text+"')";
            CommonFunctions.Insert(query);
            CommonFunctions.LoadDataGrid(AllData, "Suppliers");
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            CommonFunctions.LoadDataGrid(AllData, "Suppliers");
        }
    }
}