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
    public partial class patient_discharge : Form
    {
        public patient_discharge()
        {
            InitializeComponent();
            treeView1.Nodes.Clear();

            // Adding Patient Data from sqlite database
            SQLiteConnection connection = databasemanagement.CreateConnection();
            SQLiteCommand command;
            SQLiteDataReader Reader;
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM patient";
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                // Code for displaying data
                treeView1.Nodes.Add(Reader.GetString(1));
            }
        }

        private void dischage_patient_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteDataReader Reader;
                string patientname = treeView1.SelectedNode.Text;
                SQLiteConnection connection = databasemanagement.CreateConnection();
                SQLiteCommand command;
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM patient WHERE name='" + patientname+"'";
                command.ExecuteNonQuery();
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM patient";
                Reader = command.ExecuteReader();
                string _roomnumber = "";
                while (Reader.Read())
                {
                    // Code for displaying data
                    if (Reader.GetString(1) == treeView1.SelectedNode.Text)
                    {
                        _roomnumber = Reader.GetString(7);
                    }
        
                }
                Reader.Close();
                SQLiteCommand command1 = connection.CreateCommand();
                string sqlite = "UPDATE room SET status='vaccant' WHERE room_number=" + _roomnumber + "'";
                command1.CommandText = sqlite;
                command1.ExecuteNonQuery();
                MessageBox.Show("Patient has been sucessfully discharged", "Sucess");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void patient_discharge_Load(object sender, EventArgs e)
        {

        }
    }
}
