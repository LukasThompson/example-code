using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sabio.Models.Requests.Schedule
{
    public class ScheduleUpdateRequest : ScheduleAddRequestV2, IModelIdentifier
    {
        public int Id { get; set; }
    }
}
