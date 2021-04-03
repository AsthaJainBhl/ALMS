using System;
using System.Collections.Generic;

#nullable disable

namespace ALMS.API.Models
{
    public partial class TrProjectAllocation
    {
        public int? ProjectId { get; set; }
        public long? EmployeeId { get; set; }
        public string Status { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual MsEmployeeDetail Employee { get; set; }
        public virtual MsProjectDetail Project { get; set; }
    }
}
