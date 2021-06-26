using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalHelperBL.Model
{
    class Patient
    {
        public int PatientId { get; set; }
        public DateTime BirthDayDate { get; set; }
        public bool IsDelete { get; set; }
        public string FullName { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public int PurschaseHistoryId { get; set; }
        public string OMS { get; set; }
    }
}
