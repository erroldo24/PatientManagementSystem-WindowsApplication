using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagementSystem_WindowsApplication
{
    public class room
    {
        public int roomnumber { get; set; }
        public string status { get; set; }
        public string remarks { get; set; }

        public room(int _roomnumber, string _status, string _remarks)
        {
            this.roomnumber = _roomnumber;
            this.status = _status;
            this.remarks = _remarks;
        }
        
    }
}
