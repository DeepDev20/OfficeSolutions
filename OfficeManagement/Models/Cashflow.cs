using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeManagement.Models
{
    public class Cashflow
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Direction { get; set; }
        public string Description { get; set; }
        public DateTime Loggeddatetime { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
    }
}
