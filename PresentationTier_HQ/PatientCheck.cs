//Author: Fletcher Thomas Moore
//Name: PatientCheck.cs
//Description: Find the patient in DB from input 
//Start Date: 29/11/2020
//Last Edit:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using ApplicationTier;

namespace PresentationTier_HQ
{
    class PatientCheck
    {
        public DataSet FindPatient(string connectionData)
        {
            PatientData patientData = new PatientData();

            return patientData.NHSRegNo(connectionData);
        }
        
    }
}

