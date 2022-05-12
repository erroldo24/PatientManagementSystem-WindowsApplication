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
    public partial class roomManagementSystem : Form
    {
        public roomManagementSystem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form1 = new room_summary();
            form1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new room_add();
            form2.ShowDialog();
        }
    }
}
