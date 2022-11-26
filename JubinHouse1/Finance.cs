using System;
using System.Windows.Forms;

namespace JubinHouse1
{
    public partial class Finance : Form
    {
        public Finance()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void Finance_Load(object sender, EventArgs e)
        {
            CommonFunctions.LoadDataGrid(AllData, "Finance");
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Finance(`Finance ID`, `Bank Name`, `Financing Interest Rate`, `Financing Duration`, `Project ID`) VALUES ('"+textBox1.Text+"','"+textBox3.Text+"','"+textBox2.Text+"','"+textBox6.Text+"','"+textBox5.Text+"')";
            CommonFunctions.Insert(query);
            CommonFunctions.LoadDataGrid(AllData, "Finance");
        }
    }
}