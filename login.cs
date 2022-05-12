using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagementSystem_WindowsApplication
{
    public partial class login : Form
    {
        string userame;
        string password;
        public login()
        {
            InitializeComponent();
            this.userame = "admin";
            this.password = "password";
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _username = textBox1.Text;
            string _password = textBox2.Text;

            if(_username == this.userame)
            {
                if(_password == this.password)
                {
                    // Code for starting Dash Board
                }
                else
                {
                    MessageBox.Show("Invalid Password", "Error");
                }
            }
            else
            {
                MessageBox.Show("Invalid Username", "Error");
            }
        }
    }
}
