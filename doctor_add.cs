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
    public partial class doctor_add : Form
    {
        public doctor_add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Code for adding a doctor into database
                SQLiteConnection connection = databasemanagement.CreateConnection();
                SQLiteCommand command;
                command = connection.CreateCommand();
                string sqlite_query = "INSERT INTO doctor (name, remarks) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "')";
                command.CommandText = sqlite_query;
                command.ExecuteNonQuery();
                MessageBox.Show("Your Doctor has been added in the Database", "Sucess");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
