using System;
using System.Collections.Generic;

#nullable disable

namespace ALMS.API.Models
{
    public partial class MsEmployeeDetail
    {
        public MsEmployeeDetail()
        {
            TrAttendanceDetails = new HashSet<TrAttendanceDetail>();
            TrLeaveRequestDetails = new HashSet<TrLeaveRequestDetail>();
        }

        public long EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime EmployeeDob { get; set; }
        public int? EmployeeAge { get; set; }
        public long EmployeePhoneNumber { get; set; }
        public string EmployeeEmailId { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeDesignation { get; set; }
        public long? ManagerId { get; set; }
        public string Status { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual ICollection<TrAttendanceDetail> TrAttendanceDetails { get; set; }
        public virtual ICollection<TrLeaveRequestDetail> TrLeaveRequestDetails { get; set; }
    }
}
