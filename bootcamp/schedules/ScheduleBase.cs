using Sabio.Models.Domain.LookUp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sabio.Models.Domain.Schedules
{
    public class ScheduleBase 
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public int VendorId { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
