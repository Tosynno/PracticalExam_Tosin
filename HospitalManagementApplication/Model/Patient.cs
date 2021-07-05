using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementApplication.Model
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contract { get; set; }
        public string Gender { get; set; }
        public string EmergencyId { get; set; }
        public string Occupation { get; set; }
        public string BloodGroup { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
