using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeManagement.Models
{
    public class LeaveEmployeeMapping
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int LeaveId { get; set; }
    }
}
