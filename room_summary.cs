using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagementSystem_WindowsApplication
{
    public partial class room_summary : Form
    {
        public room_summary()
        {
            InitializeComponent();
            // Adding Data 
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Room Id";
            dataGridView1.Columns[1].Name = "Room Number";
            dataGridView1.Columns[2].Name = "Status";
            dataGridView1.Columns[3].Name = "Remarks";
            dataGridView1.Columns[0].Width = 195;
            dataGridView1.Columns[1].Width = 195;
            dataGridView1.Columns[2].Width = 195;
            dataGridView1.Columns[3].Width = 195;

            // Displaying Data from database
            SQLiteConnection connection = databasemanagement.CreateConnection();
            SQLiteCommand command;
            SQLiteDataReader Reader;
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM room";
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                // Code for displaying data
                string[] data = { Reader.GetInt64(0).ToString(), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3) };
                dataGridView1.Rows.Add(data);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void room_summary_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
