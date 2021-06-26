using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalHelperBL.Model
{
    class PurschaseHistory
    {
        public int PurschaseHistoryId { get; set; }
        public DateTime Created { get; set; }
        public decimal Total { get; set; }
        public int PatientId { get; set; }
    }
}
