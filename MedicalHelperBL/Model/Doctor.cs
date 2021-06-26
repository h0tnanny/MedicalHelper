using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalHelperBL.Model
{
    class Doctor
    {
        public int DoctorId { get; set; }
        public bool IsDelete { get; set; }
        public string FullName { get; set; }
        public int CabinetId { get; set; }
        public int SpecialtyId { get; set; }
        public int WorkingDayId { get; set; }
        public int UserGroupId { get; set; }
        public string PhoneNumber { get; set; }
    }
}
