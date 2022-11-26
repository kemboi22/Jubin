using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace JubinHouse1
{
    public class CommonFunctions
    {
        public static string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=jubin_house_database.mdb";
        private static  OleDbConnection _connection = new OleDbConnection(ConnectionString);

        public static void LoadDataGrid(DataGridView dataGridView, string table)
        {
            _connection.Open();
            string query = "SELECT * FROM " + table;
            var adapter = new OleDbDataAdapter(query, _connection);
            var dataset = new DataSet();
            adapter.Fill(dataset);
            dataGridView.DataSource = dataset.Tables[0];
            _connection.Close();
        }

        public static void Insert(string query)
        {
            _connection.Open();
            var cmd = new OleDbCommand(query, _connection);
            cmd.ExecuteNonQuery();
            _connection.Close();
            MessageBox.Show("Record Inserted SuccessFully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        public class Global
        {
            public static string role { get; set; }
        }
    }
}