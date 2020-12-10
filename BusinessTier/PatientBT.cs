using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTier;
using BusinessObject;
using System.Data;
using System.Data.SqlClient;

namespace BusinessTier
{
    public class PatientBT
    {
        //Objects for PatientDT and PatientBO
        public PatientDT pdt = new PatientDT();
        public PatientBO pbo = new PatientBO();

        public DataTable PatientDT(PatientBT pbt)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from KwikMedical where NHSRegNum = '"+pbo.NHSRegNum+"'";
            return pdt.ExeReader(cmd);
        }

        /*Insert Query if needed
        public int Insert(PatientBO pbo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into patient";
        }*/


    }
}
