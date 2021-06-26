using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalHelperBL.Model
{
    class Case
    {
        public int CaseId { get; set; }
        public DateTime Created { get; set; }
        public bool IsDelete { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int DoctorId { get; set; }
        public string Medicament { get; set; }
    }
}
