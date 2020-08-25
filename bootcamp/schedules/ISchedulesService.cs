using Sabio.Models;
using Sabio.Models.Domain.Schedules;
using Sabio.Models.Requests.Schedule;
using System;
using System.Collections.Generic;

namespace Sabio.Services.Schedules
{
    public interface ISchedulesService
    {
        void Delete(int id);
        int Add(ScheduleAddRequest model, int userId);
        int AddVersion2(ScheduleAddRequestV2 model, int userId);
        void Update(ScheduleUpdateRequest model, int userId);
        Schedule Get(int id);
        Paged<Schedule> Get(int pageIndex, int pageSize);
        Paged<Schedule> GetByCreatedBy(int userId, int pageIndex, int pageSize);
        Paged<Schedule> GetByCreatedBy_ByVendor(int userId, int pageIndex, int pageSize, DateTime startDate, DateTime endDate, int vendorId);
    }
}
