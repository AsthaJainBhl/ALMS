using System;
using System.Collections.Generic;

#nullable disable

namespace ALMS.API.Models
{
    public partial class TrLeaveRequestDetail
    {
        public int LeaveRequestId { get; set; }
        public long? EmployeeId { get; set; }
        public string LeaveType { get; set; }
        public int LeavesRemaining { get; set; }
        public DateTime LeaveRequestFrom { get; set; }
        public DateTime LeaveRequestTo { get; set; }
        public string LeaveStatus { get; set; }

        public virtual MsEmployeeDetail Employee { get; set; }
    }
}
