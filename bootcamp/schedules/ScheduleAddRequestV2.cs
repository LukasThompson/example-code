using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sabio.Models.Requests.Schedule
{
    public class ScheduleAddRequestV2
    {
        [Required]
        [Range(1, Int32.MaxValue, ErrorMessage = "LocationId must be between 1 and 2147483647")]
        public int LocationId { get; set; }
        
        [Required]
        [Range(1, Int32.MaxValue, ErrorMessage = "VendorId must be between 1 and 2147483647")]
        public int VendorId { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }
    }
}
