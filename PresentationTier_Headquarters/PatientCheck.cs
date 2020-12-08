using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using ApplicationTier;

namespace PresentationTier_Headquarters
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
