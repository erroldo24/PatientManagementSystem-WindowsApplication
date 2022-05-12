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
    public partial class patient_add : Form
    {
        public patient_add()
        {
            InitializeComponent();
            // Status Options
            comboBox2.Items.Add("Normal");
            comboBox2.Items.Add("Serious");
            comboBox2.Items.Add("Extreme Critical");
        }

        private void patient_add_Load(object sender, EventArgs e)
        {

            // Getting data from sqlite form doctor 
            SQLiteConnection connection = databasemanagement.CreateConnection();
            SQLiteCommand command;
            SQLiteDataReader Reader;
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM doctor";
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                // Code for displaying data
                comboBox1.Items.Add("Dr. " + Reader.GetString(1));
            }


            // geeting data from sqlite for avaiable room number
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM room";
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                // Code for displaying data
                if (Reader.GetString(2) == "vaccant")
                {
                    comboBox3.Items.Add(Reader.GetString(1));
                }
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Code for adding patient data into database
            try
            {
                string _name = textBox1.Text;
                string _age = textBox2.Text;
                string _contactnumber = textBox3.Text;
                string _disease = textBox4.Text;
                string _remarks = textBox5.Text;
                string _doctor = comboBox1.SelectedItem.ToString();
                string _status = comboBox2.SelectedItem.ToString();
                string _roomnumber = comboBox3.SelectedItem.ToString();
                SQLiteConnection connection = databasemanagement.CreateConnection();
                SQLiteCommand command;
                string sqlite = "INSERT INTO patient (name, Age, contact_number, disease, doctor, status, room, remarks) VALUES ('" + _name + "','" + _age + "','" + _contactnumber + "','"+_disease + "','"+_doctor + "','"+_status + "','"+_roomnumber + "','"+_remarks+ "')";
                command = connection.CreateCommand();
                command.CommandText = sqlite;
                command.ExecuteNonQuery();

                // Query for changing status of room
                sqlite = "UPDATE room SET status='filled' WHERE room_number='"+_roomnumber+"'";
                command.CommandText = sqlite;
                command.ExecuteNonQuery();

                MessageBox.Show("Patient has been added into Database.", "Sucess");



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }
    }
}
