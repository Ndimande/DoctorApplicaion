using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorApplicaion
{
    // Static class so that we dont have to instantiate all the time
    public static class GlobalConfig
    {

        // This will be a static Sql connection that we can use anywhere in our PROJECT
        public static SqlConnection SQLCONN { get; set; } = Conn();

        public static PatientModel patientModel { get; set; } = new PatientModel();

        public static SqlConnection Conn()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["DoctorApp"].ConnectionString);

        }
    }
}
