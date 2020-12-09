//Author: Fletcher Thomas Moore
//Name: PatientCheck.cs
//Description: Find the patient in DB from input 
//Start Date: 29/11/2020
//Last Edit:

using System.Data;
using PresentationTier_HQ;
using ApplicationTier;  //Need Application Tier for PatientData -- connects to DataTier

namespace PresentationTier_HQ
{
    class PatientCheck
    {
        //Retrieves data from DB
        public DataSet FindPatient(string connectionString)
        {
            PatientData patientData = new PatientData();

            return patientData.NHSRegNo(connectionString);
        }


        
    }
}

