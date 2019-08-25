using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeManagement.Models
{
    public class Salary
    {
        public int Id { get; set; }
        public int employeeId { get; set; }
        public string Amount { get; set; }
        public string Month { get; set; }

        public bool isPending { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
    }
}
