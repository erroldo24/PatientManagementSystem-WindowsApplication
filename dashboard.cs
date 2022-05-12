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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Code for Room Management System
            Form form2 = new roomManagementSystem();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new doctormangementsystem();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form3 = new patientmanagementsystem();
            form3.ShowDialog();
        }
    }
}
