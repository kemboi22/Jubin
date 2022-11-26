using System;
using System.Windows.Forms;

namespace JubinHouse1
{
    public partial class Branches : Form
    {
        public Branches()
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
            string query = "INSERT INTO Branches(`Branch_ID`, `BranchStreet Address`, `BranchName`, `Branch Phone Number`, `Branch State`, `Branch City`, `Branch Zipcode`) VALUES ('"+textBox1.Text+"','"+textBox3.Text+"','"+textBox2.Text+"','"+textBox8.Text+"','"+textBox7.Text+"','"+textBox6.Text+"','"+textBox5.Text+"')";
            CommonFunctions.Insert(query);
            CommonFunctions.LoadDataGrid(AllData, "Branches");
        }

        private void Branches_Load(object sender, EventArgs e)
        {
            CommonFunctions.LoadDataGrid(AllData, "Branches");
        }
    }
}