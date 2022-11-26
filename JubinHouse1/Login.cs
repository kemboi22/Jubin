using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace JubinHouse1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        OleDbConnection _connection = new OleDbConnection(CommonFunctions.ConnectionString);

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM login WHERE email='"+email.Text+"' AND password='"+password.Text+"'";
            _connection.Open();
            var cmd = new OleDbCommand(query, _connection);
            var dataReader = cmd.ExecuteReader();
            
            if (dataReader.Read())
            {
                MessageBox.Show("Success", "You have Logged in successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if ((string)dataReader["role"] == "manager")
                {
                    new Form1().Show();
                    this.Hide();
                }else if ((string)dataReader["role"] == "Architect")
                {
                    new ArchitectDashboard().Show();
                    CommonFunctions.Global.role = dataReader["role"].ToString();
                    this.Hide();
                }else if ((string)dataReader["role"] == "Employee")
                {
                    new EmployeeDashBoard().Show();
                    CommonFunctions.Global.role = dataReader["role"].ToString();
                    this.Hide();
                }
                dataReader.Close();
                
            }
            else
            {
                dataReader.Close();
                MessageBox.Show("Error", "Details do not match", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}