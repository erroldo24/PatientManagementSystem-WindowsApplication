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
    public partial class patient_summary : Form
    {
        public patient_summary()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "Patient Name";
            dataGridView1.Columns[2].Name = "Age";
            dataGridView1.Columns[3].Name = "Contact Number";
            dataGridView1.Columns[4].Name = "Disease";
            dataGridView1.Columns[5].Name = "Detailed Doctor";
            dataGridView1.Columns[6].Name = "Status";
            dataGridView1.Columns[7].Name = "Room Number";
            dataGridView1.Columns[8].Name = "Remarks";

            // Displaying Data from database
            SQLiteConnection connection = databasemanagement.CreateConnection();
            SQLiteCommand command;
            SQLiteDataReader Reader;
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM patient";
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                // Code for displaying data
                string[] data = { Reader.GetInt64(0).ToString(), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3), Reader.GetString(4), Reader.GetString(5), Reader.GetString(6), Reader.GetString(7), Reader.GetString(8), Reader.GetString(8) };
                dataGridView1.Rows.Add(data);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void patient_summary_Load(object sender, EventArgs e)
        {

        }
    }
}
