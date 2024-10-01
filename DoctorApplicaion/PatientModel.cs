using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorApplicaion
{
    public class PatientModel
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string file_number { get; set; }
        public string age { get; set; }
        public string is_medical { get; set; }
        public string is_cash { get; set; }
        public string doctor {  get; set; }
    }
}
