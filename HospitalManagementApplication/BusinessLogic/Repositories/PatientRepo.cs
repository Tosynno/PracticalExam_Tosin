using HospitalManagementApplication.BusinessLogic.Interface;
using HospitalManagementApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementApplication.BusinessLogic.Repositories
{
    public class PatientRepo : IPatient
    {
        public List<Patient> GetAllPatient()
        {
            List<Patient> ListPatient = new List<Patient>();

            ListPatient.Add(new Patient() { Id = 1, Name = "Bello", BloodGroup = "AA", Contract = "12 Street", Occupation = "Software dev", EmergencyId = "0999", Gender = "M", CreatedDate = DateTime.Now });

            ListPatient.Add(new Patient() { Id = 1, Name = "Ada", BloodGroup = "As", Contract = "12 Street", Occupation = "IT dev", EmergencyId = "455", Gender = "M", CreatedDate = DateTime.Now });

            ListPatient.Add(new Patient() { Id = 1, Name = "Dimeji", BloodGroup = "CC", Contract = "12 Street", Occupation = "Accountant", EmergencyId = "445", Gender = "F", CreatedDate = DateTime.Now });

            return ListPatient;
        }
    }
}
