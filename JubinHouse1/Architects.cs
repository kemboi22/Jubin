using System;
using System.Windows.Forms;

namespace JubinHouse1
{
    public partial class Architects : Form
    {
        public Architects()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }


        private void Architects_Load(object sender, EventArgs e)
        {
            CommonFunctions.LoadDataGrid(AllData, "Architects");
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Architects(`Employee_ID`, `Architect Experience`, `Architect Pay Rate`) VALUES ('"+textBox1.Text+"','"+textBox3.Text+"','"+textBox2.Text+"')";
            CommonFunctions.Insert(query);
            CommonFunctions.LoadDataGrid(AllData, "Architects");
        }
    }
}