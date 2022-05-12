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
    public partial class room_add : Form
    {
        public room_add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string roomnumber = textBox1.Text;
                string remarks = textBox2.Text;
                string status = "vaccant";
                SQLiteConnection connection = databasemanagement.CreateConnection();
                SQLiteCommand command;
                string sqlite = "INSERT INTO room (room_number, status, remarks) VALUES ('" + roomnumber + "','" + status + "','" + remarks + "')";
                command = connection.CreateCommand();
                command.CommandText = sqlite;
                command.ExecuteNonQuery();
                MessageBox.Show("Room has been added into Database.", "Sucess");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void room_add_Load(object sender, EventArgs e)
        {

        }
    }
}
