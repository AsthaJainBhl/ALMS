using System;
using System.Collections.Generic;

#nullable disable

namespace ALMS.API.Models
{
    public partial class MsProjectDetail
    {
        public MsProjectDetail()
        {
            TrAttendanceDetails = new HashSet<TrAttendanceDetail>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectTechnology { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public DateTime ProjectEndDate { get; set; }
        public string Status { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual ICollection<TrAttendanceDetail> TrAttendanceDetails { get; set; }
    }
}
