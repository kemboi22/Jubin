using System;
using System.Windows.Forms;

namespace JubinHouse1
{
    public partial class States : Form
    {
        public States()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO States(`Branch State`, `State Name`)VALUES ('"+textBox3.Text+"', '"+textBox2.Text+"')";
            CommonFunctions.Insert(query);
            CommonFunctions.LoadDataGrid(AllData, "States");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void States_Load(object sender, EventArgs e)
        {
            CommonFunctions.LoadDataGrid(AllData, "States");
        }
    }
}