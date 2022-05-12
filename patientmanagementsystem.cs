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
    public partial class patientmanagementsystem : Form
    {
        public patientmanagementsystem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form1 = new patient_summary();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form2 = new patient_add();
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form3 = new patient_discharge();
            form3.ShowDialog();
        }
    }
}
