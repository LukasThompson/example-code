using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Sabio.Models.Requests.Schedule
{
    public class ScheduleAddRequest
    {
        [Required]
        [Range(1, Int32.MaxValue, ErrorMessage = "LocationId must be between 1 and 2147483647")] 
        public int LocationId { get; set; }
        [Required]
        [Range(1, Int32.MaxValue, ErrorMessage = "VendorId must be between 1 and 2147483647")]
        public int VendorId { get; set; }

    }
}
