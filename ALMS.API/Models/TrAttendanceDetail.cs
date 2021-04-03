using System;
using System.Collections.Generic;

#nullable disable

namespace ALMS.API.Models
{
    public partial class TrAttendanceDetail
    {
        public int AttendanceId { get; set; }
        public int? ProjectId { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime AttedanceDate { get; set; }
        public TimeSpan InTime { get; set; }
        public TimeSpan OutTime { get; set; }
        public string AttendanceStatus { get; set; }
        public DateTime? StatusUpdateDate { get; set; }
        public long? StatusUpdatedBy { get; set; }

        public virtual MsEmployeeDetail Employee { get; set; }
        public virtual MsProjectDetail Project { get; set; }
    }
}
