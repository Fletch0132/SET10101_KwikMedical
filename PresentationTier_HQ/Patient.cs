//Author: Fletcher Thomas Moore
//Name: Patient.cs
//Description: Patient data to store variables
//Start Date: 29/11/2020
//Last Edit: 08/12/2020

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationTier_HQ
{
    class Patient
    {
        //private variables
        private int nhsRegNum;
        private string firstName, lastName, address, medicalCon;

        //get-set
        public int NHSRegNum
        {
            get { return nhsRegNum; }
            set { nhsRegNum = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string MedicalCon
        {
            get { return medicalCon; }
            set { medicalCon = value; }
        }

    }
}
