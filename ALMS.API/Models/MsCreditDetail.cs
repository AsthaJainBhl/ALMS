using System;
using System.Collections.Generic;

#nullable disable

namespace ALMS.API.Models
{
    public partial class MsCreditDetail
    {
        public long? EmployeeId { get; set; }
        public int LeaveCreditValue { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual MsEmployeeDetail Employee { get; set; }
    }
}
