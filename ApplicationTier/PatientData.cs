//Author: Fletcher Thomas Moore
//Name: PatientData.cs
//Description: Class to read/Query database, select specific data, and store the specific data
//Start Date: 28/11/2020
//Last Edit: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace ApplicationTier
{
    public class PatientData
    {
        public DataSet NHSRegNo(String connectionData)
        {
            //NHS Registration Number
            string regNo = "";      //Pull this from input
            //SQL Query
            string selectSQL = "Select NHSRegNum, FirstName, LastName, Street Address, Town, Postcode, MedicalCon from patient where NHSRegNum = '" + regNo + "';";

            //connect to database, use query and store
            SqlConnection connect = new SqlConnection(connectionData);
            SqlDataAdapter adapter = new SqlDataAdapter(selectSQL, connect);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            return dataset;
        }
    }
}
