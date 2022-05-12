#region
using System.Threading.Tasks;
#endregion

namespace PatientManagementSystem_WindowsApplication
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Shown(object sender, EventArgs e)
        {
        }
        void timer_tick(object sender, EventArgs e)
        {
            timer.Stop();
            // Code for starting new  Form
            dashboard page1 = new dashboard();
            page1.Show();
            this.Hide();
        }

        private void Form1_Shown_1(object sender, EventArgs e)
        {

            // Creating time for loading form
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 8000;
            timer.Start();
            timer.Tick += timer_tick;
        }
    }
}