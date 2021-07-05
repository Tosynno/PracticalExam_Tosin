using HospitalManagementApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementApplication.BusinessLogic.Interface
{
    public interface IPatient
    {
        List<Patient> GetAllPatient();
    }
}
