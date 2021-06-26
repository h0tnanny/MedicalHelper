using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalHelperBL.Model
{
    class Card
    {
        public int CardId { get; set; }
        public DateTime Created { get; set; }
        public bool IsDelete { get; set; }
        public int CaseId { get; set; }
        public int PatientId { get; set; }
    }
}
