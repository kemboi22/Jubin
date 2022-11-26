using System;
using System.Windows.Forms;

namespace JubinHouse1
{
    public partial class Agents : Form
    {
        public Agents()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
        private void Agents_Load(object sender, EventArgs e)
        {
            CommonFunctions.LoadDataGrid(AllAgents, "Agent");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Agent(`Employee ID`, `Agent Salary`, `Agent Position`) VALUES ('"+textBox1.Text+"','"+textBox3.Text+"','"+textBox2.Text+"')";
            CommonFunctions.Insert(query);
            CommonFunctions.LoadDataGrid(AllAgents, "Agent");
            
        }
    }
}