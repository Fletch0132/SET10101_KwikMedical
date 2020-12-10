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
    public class PatientDT
    {
        //Connect to the DB
        public SqlConnection con = new SqlConnection("Data Source=DESKTOP-M316A5Q\\MSSQLSERVER01;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        //Check connection open
        public SqlConnection GetCon()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        //Perfoms Queries 
        public int ExeNonQuery(SqlCommand cmd)
        {
            cmd.Connection = GetCon();
            int rowsaffected = -1;
            rowsaffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowsaffected;
        }

        //Select value 
        public object ExeScalar(SqlCommand cmd)
        {
            cmd.Connection = GetCon();
            object obj = -1;
            obj = cmd.ExecuteScalar();
            con.Close();
            return obj;
        }

        //Preform Query
        public DataTable ExeReader(SqlCommand cmd)
        {
            cmd.Connection = GetCon();
            SqlDataReader sdr;
            DataTable dt = new DataTable();

            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }

    }
}
