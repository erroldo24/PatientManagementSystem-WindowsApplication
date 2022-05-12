using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagementSystem_WindowsApplication
{
    public class doctor
    {
        public string name { get; set; }
        public string remarks { get; set; }

        public doctor(string _name, string _remarks)
        {
            this.name = _name;
            this.remarks = _remarks;
        }
    }
}
