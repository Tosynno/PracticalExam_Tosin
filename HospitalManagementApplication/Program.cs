using HospitalManagementApplication.BusinessLogic;
using HospitalManagementApplication.BusinessLogic.Repositories;
using HospitalManagementApplication.Model;
using System;
using System.Collections.Generic;

namespace HospitalManagementApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneralLayer generalentities = new GeneralLayer(new PatientRepo());

            List<Patient> Listpatient = generalentities.GetPatient();

            foreach (Patient pat in Listpatient)
            {
                Console.WriteLine();
                Console.WriteLine("ID = {0}, Name = {1}, Blood Group = {2}, Contract = {3}, Emergency Id = {4}, Gender = {5}, Occupation = {6}, Created Date = {7}", pat.Id, pat.Name, pat.BloodGroup, pat.Contract, pat.EmergencyId, pat.Gender, pat.Occupation, pat.CreatedDate);
            }
        }
    }
}
