using System;
using System.Collections.Generic;

#nullable disable

namespace ALMS.API.Models
{
    public partial class MsUserRegistration
    {
        public long? EmployeeId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual MsEmployeeDetail Employee { get; set; }
    }
}
