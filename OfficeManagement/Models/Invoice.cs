using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeManagement.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public decimal? Tax { get; set; }
        public int Fromcompanyid { get; set; }
        public int Tocompanyid { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
    }
}
