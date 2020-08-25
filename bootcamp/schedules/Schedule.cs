using System;
using System.Collections.Generic;
using System.Text;

namespace Sabio.Models.Domain.Schedules
{
   public class Schedule : ScheduleBase
    {
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string VendorName { get; set; }
        public Location Location { get; set; }

    }
}
