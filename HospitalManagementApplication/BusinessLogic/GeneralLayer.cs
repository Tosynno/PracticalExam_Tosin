using HospitalManagementApplication.BusinessLogic.Interface;
using HospitalManagementApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementApplication.BusinessLogic
{
   public  class GeneralLayer
    {
        public IPatient iPatientDAL;
        public GeneralLayer(IPatient iPatientDAL)
        {
            this.iPatientDAL = iPatientDAL;

        }
        public List<Patient> GetPatient()
        {

            return iPatientDAL.GetAllPatient();
        }
    }
}
