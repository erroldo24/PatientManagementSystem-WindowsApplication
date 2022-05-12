using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PatientManagementSystem_WindowsApplication
{
    public partial class doctor_view : Form
    {
        public doctor_view()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Doctor Id";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "Remarks";
            dataGridView1.Columns[0].Width = 195;
            dataGridView1.Columns[1].Width = 295;
            dataGridView1.Columns[2].Width = 295;

        }

        private void doctor_view_Load(object sender, EventArgs e)
        {
            // Displaying Data from database
            SQLiteConnection connection = databasemanagement.CreateConnection();
            SQLiteCommand command;
            SQLiteDataReader Reader;
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM doctor";
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                // Code for displaying data
                string[] data = { Reader.GetInt64(0).ToString(), Reader.GetString(1), Reader.GetString(2) };
                dataGridView1.Rows.Add(data);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
