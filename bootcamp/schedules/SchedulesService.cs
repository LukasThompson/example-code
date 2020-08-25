using Sabio.Data;
using Sabio.Data.Providers;
using Sabio.Models;
using Sabio.Models.Domain;
using Sabio.Models.Domain.LookUp;
using Sabio.Models.Domain.Schedules;
using Sabio.Models.Requests.Schedule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Sabio.Services.Schedules
{
    public class SchedulesService : ISchedulesService
    {
        private IAuthenticationService<int> _authenticationService;
        private IDataProvider _dataProvider;

        public SchedulesService(IAuthenticationService<int> authSerice, IDataProvider dataProvider)
        {
            _authenticationService = authSerice;
            _dataProvider = dataProvider;
        }

        #region Gets
        public Schedule Get(int id)
        {
            string procName = "[dbo].[Schedules_Select_ById_V2]";
            Schedule schedule = null;
            int totalCount = 0;

            _dataProvider.ExecuteCmd(procName, delegate (SqlParameterCollection paramCollection)
            {
                paramCollection.AddWithValue("@Id", id);

            }, delegate (IDataReader reader, short set) // Single record mapper
            {
                if(schedule == null)
                {
                    schedule = MapSchedule(reader, out totalCount);
                }        
            }
            );

            return schedule;
        } 

        public Paged<Schedule> Get(int pageIndex, int pageSize)
        {
            Paged<Schedule> pagedList = null;

            List<Schedule> list = null;

            int totalCount = 0;

            string procName = "dbo.Schedules_SelectAll";

            _dataProvider.ExecuteCmd(procName, inputParamMapper: delegate (SqlParameterCollection parameterCollection)
            {
                parameterCollection.AddWithValue("@pageIndex", pageIndex);
                parameterCollection.AddWithValue("@pageSize", pageSize);
            },
                singleRecordMapper: delegate (IDataReader reader, short set)
                {
                    int startingIndex; 
                    Schedule schedule = MapSchedule(reader, out startingIndex);

                    if (totalCount == 0 && totalCount < reader.FieldCount)
                    {
                        totalCount = reader.GetSafeInt32(startingIndex);
                    }

                    if (list == null)
                    {
                        list = new List<Schedule>();
                    }
                    list.Add(schedule);
                }
            );
            if (list != null)
            {
                pagedList = new Paged<Schedule>(list, pageIndex, pageSize, totalCount);
            }

            return pagedList;
        } 

        public Paged<Schedule> GetByCreatedBy(int userId, int pageIndex, int pageSize)  
        {
            Paged<Schedule> pagedList = null;
            List<Schedule> list = null;
            int totalCount = 0;
            string procName = "[dbo].[Schedules_SelectByCreatedBy_Details]";
            
            _dataProvider.ExecuteCmd(procName, delegate (SqlParameterCollection paramCollection)
            {
                paramCollection.AddWithValue("@CreatedBy", userId);
                paramCollection.AddWithValue("@pageIndex", pageIndex);
                paramCollection.AddWithValue("@pageSize", pageSize);

            }, singleRecordMapper: delegate (IDataReader reader, short set)
            {
                int startingIndex;
                Schedule schedule = DetailsMapper(reader, out startingIndex);

                if (totalCount == 0 && totalCount < reader.FieldCount)
                {
                    totalCount = reader.GetSafeInt32(startingIndex);
                }

                if (list == null)
                {
                    list = new List<Schedule>();
                }
                list.Add(schedule);
            }
            );
            if (list != null)
            {
                pagedList = new Paged<Schedule>(list, pageIndex, pageSize, totalCount);
            }

            return pagedList;
        }


        public Paged<Schedule> GetByCreatedBy_ByVendor(int userId, int pageIndex, int pageSize, DateTime startDate, DateTime endDate, int vendorId)
        {
            Paged<Schedule> pagedList = null;
            List<Schedule> list = null;
            int totalCount = 0;
            string procName = "[dbo].[Schedules_Select_VendorRoutes_ByDate_By_CreatedBy_By_Vendor]";

            _dataProvider.ExecuteCmd(procName, delegate (SqlParameterCollection paramCollection)
            {
                paramCollection.AddWithValue("@CreatedBy", userId);
                paramCollection.AddWithValue("@pageIndex", pageIndex);
                paramCollection.AddWithValue("@pageSize", pageSize);
                paramCollection.AddWithValue("@startDate", startDate);
                paramCollection.AddWithValue("@endDate", endDate);
                paramCollection.AddWithValue("@vendorId", vendorId);

            }, singleRecordMapper: delegate (IDataReader reader, short set)
            {
                int startingIndex;
                Schedule schedule = ByVendorMapper(reader, out startingIndex);

                if (totalCount == 0 && totalCount < reader.FieldCount)
                {
                    totalCount = reader.GetSafeInt32(startingIndex);
                }

                if (list == null)
                {
                    list = new List<Schedule>();
                }
                list.Add(schedule);
            }
            );
            if (list != null)
            {
                pagedList = new Paged<Schedule>(list, pageIndex, pageSize, totalCount);
            }

            return pagedList;
        }
        #endregion

        public int Add(ScheduleAddRequest model, int userId)
        {
            int id = 0;
            object oId;

            string procName = "[dbo].[Schedules_Insert]";
            _dataProvider.ExecuteNonQuery(procName,
                inputParamMapper: delegate (SqlParameterCollection col)
                {
                    SetCommonParams(model, userId, col);
                    col.AddWithValue("@CreatedBy", userId);
                    

                    SqlParameter idOut = new SqlParameter("@Id", SqlDbType.Int);
                    idOut.Direction = ParameterDirection.Output;

                    col.Add(idOut);

                },
                returnParameters: delegate (SqlParameterCollection returnCollection)
                {
                    oId = returnCollection["@Id"].Value;
                    Int32.TryParse(oId.ToString(), out id);
                });

            return id;
        }

        public int AddVersion2(ScheduleAddRequestV2 model, int userId)
        {
            int id = 0;
            string procName = "[dbo].[Schedules_Insert_V3]";

                _dataProvider.ExecuteNonQuery(procName,
                inputParamMapper: delegate (SqlParameterCollection col)
                {
                    col.AddWithValue("@LocationId", model.LocationId);
                    col.AddWithValue("@VendorId", model.VendorId);
                    col.AddWithValue("@ModifiedBy", userId);
                    col.AddWithValue("@CreatedBy", userId);
                    col.AddWithValue("@StartTime", model.StartTime);
                    col.AddWithValue("@EndTime", model.EndTime);

                    SqlParameter sIdOut = new SqlParameter("@ScheduleId", SqlDbType.Int);
                    sIdOut.Direction = ParameterDirection.Output;

                    col.Add(sIdOut);

                    SqlParameter idOut = new SqlParameter("@Id", SqlDbType.Int);
                    idOut.Direction = ParameterDirection.Output;

                    col.Add(idOut);

                },
                returnParameters: delegate (SqlParameterCollection returnCollection)
                {
                    object oId = returnCollection["@Id"].Value;
                    object sId = returnCollection["@ScheduleId"].Value;
                    Int32.TryParse(oId.ToString(), out id);
                    Int32.TryParse(sId.ToString(), out id);
                });

            return id;
        }

        public void Update(ScheduleUpdateRequest model, int userId)
        {
            string procName = "[dbo].[Schedules_Update_V3]";
            _dataProvider.ExecuteNonQuery(procName,
                inputParamMapper: delegate (SqlParameterCollection col)
                {
                    col.AddWithValue("@LocationId", model.LocationId);
                    col.AddWithValue("@VendorId", model.VendorId);
                    col.AddWithValue("@ModifiedBy", userId);
                    col.AddWithValue("@Id", model.Id);
                    col.AddWithValue("@StartTime", model.StartTime);
                    col.AddWithValue("@EndTime", model.EndTime);
                    col.AddWithValue("@ScheduleId", model.Id);
                },
                returnParameters: null);
        }

        public void Delete(int id)
        {
            string procName = "[dbo].[Schedules_Delete_ById]";

            _dataProvider.ExecuteNonQuery(procName,
             inputParamMapper: delegate (SqlParameterCollection col)
             {
                 col.AddWithValue("@Id", id);
             });
        }

        private static Schedule MapSchedule(IDataReader reader, out int startingIndex)
        {

            Schedule pagedSchedule = new Schedule();
            startingIndex = 0;
            pagedSchedule.Id = reader.GetSafeInt32(startingIndex++);
            pagedSchedule.LocationId = reader.GetSafeInt32(startingIndex++);
            pagedSchedule.VendorId = reader.GetSafeInt32(startingIndex++);
            pagedSchedule.CreatedBy = reader.GetSafeInt32(startingIndex++);
            pagedSchedule.ModifiedBy = reader.GetSafeInt32(startingIndex++);
            pagedSchedule.DateCreated = reader.GetSafeDateTime(startingIndex++);
            pagedSchedule.DateModified = reader.GetSafeDateTime(startingIndex++);

            return pagedSchedule;
        }

        private static Schedule DetailsMapper(IDataReader reader, out int startingIndex)
        {

            Schedule detailedSchedule = new Schedule();
            detailedSchedule.Location = new Location();
            startingIndex = 0;
            detailedSchedule.StartTime = reader.GetSafeDateTimeNullable(startingIndex++);
            detailedSchedule.EndTime = reader.GetSafeDateTimeNullable(startingIndex++);
            detailedSchedule.VendorName = reader.GetSafeString(startingIndex++);
            detailedSchedule.Location.Id = reader.GetSafeInt32(startingIndex++);
            detailedSchedule.Location.LineOne = reader.GetSafeString(startingIndex++);
            detailedSchedule.Location.LineTwo = reader.GetSafeString(startingIndex++);
            detailedSchedule.Location.City = reader.GetSafeString(startingIndex++);
            detailedSchedule.Location.Zip = reader.GetSafeString(startingIndex++);
            detailedSchedule.Location.States = new States
            {
                Id = reader.GetSafeInt32(startingIndex++),
                Code = reader.GetSafeString(startingIndex++),
                Name = reader.GetSafeString(startingIndex++),
                CountryId = reader.GetSafeInt32(startingIndex++),
            };
            detailedSchedule.Location.Latitude = reader.GetSafeDouble(startingIndex++);
            detailedSchedule.Location.Longitude = reader.GetSafeDouble(startingIndex++);
            detailedSchedule.Id = reader.GetSafeInt32(startingIndex++);
            detailedSchedule.LocationId = reader.GetSafeInt32(startingIndex++);
            detailedSchedule.VendorId = reader.GetSafeInt32(startingIndex++);
            detailedSchedule.CreatedBy = reader.GetSafeInt32(startingIndex++);

            return detailedSchedule;
        }

        private static Schedule ByVendorMapper(IDataReader reader, out int startingIndex)
        {

            Schedule detailedSchedule = new Schedule();
            detailedSchedule.Location = new Location();
            detailedSchedule.Location.States = new States();
            startingIndex = 0;

            detailedSchedule.Id = reader.GetSafeInt32(startingIndex++);
            detailedSchedule.Location.Id = reader.GetSafeInt32(startingIndex++);
            detailedSchedule.VendorId = reader.GetSafeInt32(startingIndex++);
            detailedSchedule.CreatedBy = reader.GetSafeInt32(startingIndex++);

            detailedSchedule.StartTime = reader.GetSafeDateTimeNullable(startingIndex++);
            detailedSchedule.EndTime = reader.GetSafeDateTimeNullable(startingIndex++);

            detailedSchedule.VendorName = reader.GetSafeString(startingIndex++);
            detailedSchedule.Location.Latitude = reader.GetSafeDouble(startingIndex++);
            detailedSchedule.Location.Longitude = reader.GetSafeDouble(startingIndex++);
            detailedSchedule.Location.LineOne = reader.GetSafeString(startingIndex++);
            detailedSchedule.Location.LineTwo = reader.GetSafeString(startingIndex++);
            detailedSchedule.Location.City = reader.GetSafeString(startingIndex++);
            detailedSchedule.Location.States.Id = reader.GetSafeInt32(startingIndex++);
            detailedSchedule.Location.Zip = reader.GetSafeString(startingIndex++);
            detailedSchedule.Location.States.Name = reader.GetSafeString(startingIndex++);

            return detailedSchedule;
        }
        private static void SetCommonParams(ScheduleAddRequest model, int userId, SqlParameterCollection col)
        {
            col.AddWithValue("@LocationId", model.LocationId);
            col.AddWithValue("@VendorId", model.VendorId);
            col.AddWithValue("@ModifiedBy", userId);
        }
    }
}
