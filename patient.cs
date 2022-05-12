using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagementSystem_WindowsApplication
{
    public class patient
    {
        public string name { get; set; }
        public string age { get; set; }
        public string contactNumber { get; set; }
        public string disease { get; set; }
        public string doctor { get; set; }
        public string status { get; set; }
        public string room { get; set; }
        public string remarks { get; set; }

        public patient(string _name, string _age, string _contactNumber, string _disease, string _doctor, string _room, string _remarks, string _status)
        {
            this.name = _name;
            this.age = _age;
            this.contactNumber = _contactNumber;
            this.disease = _disease;
            this.doctor = _doctor;
            this.room = _room;
            this.remarks = _remarks;
            this.status = _status;
        }
    }
}
