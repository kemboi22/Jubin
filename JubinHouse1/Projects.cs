using System;
using System.Windows.Forms;

namespace JubinHouse1
{
    public partial class Projects : Form
    {
        public Projects()
        {
            InitializeComponent();
        }

        private void Projects_Load(object sender, EventArgs e)
        {
            CommonFunctions.LoadDataGrid(AllData, "Project");
        }


        private void Save_Click(object sender, EventArgs e)
        {
            string Query = "INSERT INTO Project (`Project ID`, `Project Name`,`Project Status`, `Project Estimated Amount`, `Project Estimated Duration`, `Project Type`, `Employee ID`, `Client ID`, `Associated architect`, `Associated employee`) " +
                           "VALUES('"+textBox1.Text+"','"+textBox3.Text+"','"+textBox2.Text+"','"+textBox8.Text+"','"+textBox7.Text+"','"+textBox6.Text+"','"+textBox5.Text+"','"+textBox11.Text+"','"+textBox9.Text+"','"+textBox10.Text+"')";
            CommonFunctions.Insert(Query);
            CommonFunctions.LoadDataGrid(AllData, "Project");
        }


        private void Back_Click(object sender, EventArgs e)
        {
            if (CommonFunctions.Global.role == "manager")
            {
                new Form1().Show();
                this.Hide();
            }
            else if (CommonFunctions.Global.role == "Employee")
            {
                new EmployeeDashBoard().Show();
                this.Hide();
            }else if (CommonFunctions.Global.role == "Architect")
            {
                new ArchitectDashboard().Show();
                this.Hide();
            }
            
            
        }
    }
}