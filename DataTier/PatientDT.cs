using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;                  //DataSet
using System.Data.SqlClient;        //SQL
using System.Configuration;         //Connection
using BusinessObject;               //Accessing Business Object

namespace DataTier
{
    class PatientDT
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ToString());

        public DataSet NHSRegNo(PatientBO ObjBO, String connectionString)
        {
            try
            {
                //NHS Registration Number
                string regNo = "";      //Pull this from input
                                        //SQL Query
                string selectSQL = "Select NHSRegNum, FirstName, LastName, Street Address, Town, Postcode, MedicalCon from patient where NHSRegNum = '" + regNo + "';";

                //connect to database, use query and store
                SqlConnection connect = new SqlConnection(connectionString);
                SqlDataAdapter adapter = new SqlDataAdapter(selectSQL, connect);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                return dataset;
            }
            catch
            {
                DataSet dataSet = new DataSet();
                return dataSet;
            }
        }
    }
}
