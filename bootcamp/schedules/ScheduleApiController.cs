using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using Sabio.Models;
using Sabio.Models.Domain.Schedules;
using Sabio.Models.Requests.Schedule;
using Sabio.Services;
using Sabio.Services.Schedules;
using Sabio.Web.Models.Responses;

namespace Sabio.Web.Api.Controllers
{
    [Route("api/schedules")]
    [ApiController]
    public class ScheduleApiController : ControllerBase
    {
        private ISchedulesService _service = null;
        private IAuthenticationService<int> _authService = null;
        public ScheduleApiController(ISchedulesService service, ILogger<PingApiController> logger, IAuthenticationService<int> authService) : base()
        {
            _service = service;
            _authService = authService;
        }

        #region Gets 
        [HttpGet("{id:int}")]
        public ActionResult<ItemResponse<Schedule>> Get(int id)
        {
            int iCode = 200;
            BaseResponse response = null;

            try
            {
                Schedule schedule = _service.Get(id);

                if (schedule == null)
                {
                    iCode = 404;
                    response = new ErrorResponse("Address not found.");
                }
                else
                {
                    response = new ItemResponse<Schedule> { Item = schedule };
                }
            }
            catch (Exception ex)
            {
                iCode = 500;
                response = new ErrorResponse($"Error: ${ex.Message}");
            }
            return StatusCode(iCode, response);
        }

        [HttpGet("paginate")] 
        public ActionResult<ItemResponse<Paged<Schedule>>> Get(int pageIndex, int pageSize)
        {
            BaseResponse response = null;
            int code = 200;
            try
            {
                Paged<Schedule> paged = _service.Get(pageIndex, pageSize);
                if (paged == null)
                {
                    code = 404;
                    response = new ErrorResponse("App Resource Not Found");
                }
                else
                {
                    ItemResponse<Paged<Schedule>> result = new ItemResponse<Paged<Schedule>>() { Item = paged};
                    response = result;
                }
            }
            catch (Exception ex)
            {
                code = 500;
                response = new ErrorResponse(ex.Message);
            }
            return StatusCode(code, response);
        }

        [HttpGet("current")]
        public ActionResult<ItemResponse<Paged<Schedule>>> GetByCreatedBy(int pageIndex, int pageSize)
        {

            int iCode = 200;
            BaseResponse response = null;

            try
            {
                    int userId = _authService.GetCurrentUserId();
                    
                    Paged<Schedule> paged = _service.GetByCreatedBy(userId, pageIndex, pageSize);
                    if (paged == null)
                    {
                        iCode = 404;
                        response = new ErrorResponse("App Resource Not Found");
                    }
                    else
                    {
                        ItemResponse<Paged<Schedule>> result = new ItemResponse<Paged<Schedule>>() { Item = paged };
                        response = result;
                    }
            }
            catch (Exception ex)
            {
                iCode = 500;
                response = new ErrorResponse($"Error: ${ex.Message}");
            }

            return StatusCode(iCode, response);
        }

        [HttpGet("current/byvendor")]
        public ActionResult<ItemResponse<Paged<Schedule>>> GetByCreatedBy_ByVendor(int pageIndex, int pageSize, DateTime startDate, DateTime endDate, int vendorId)
        {

            int iCode = 200;
            BaseResponse response = null;

            try
            {
                int userId = _authService.GetCurrentUserId();

                Paged<Schedule> paged = _service.GetByCreatedBy_ByVendor(userId, pageIndex, pageSize, startDate, endDate, vendorId);
                if (paged == null)
                {
                    iCode = 404;
                    response = new ErrorResponse("App Resource Not Found");
                }
                else
                {
                    ItemResponse<Paged<Schedule>> result = new ItemResponse<Paged<Schedule>>() { Item = paged };
                    response = result;
                }
            }
            catch (Exception ex)
            {
                iCode = 500;
                response = new ErrorResponse($"Error: ${ex.Message}");
            }

            return StatusCode(iCode, response);
        }
        #endregion

        [HttpPost]
        public ActionResult<ItemResponse<int>> Add(ScheduleAddRequestV2 model)
        {
            int code = 200;
            BaseResponse response = null;

            try
            {
                    int userId = _authService.GetCurrentUserId();
                    int id = _service.AddVersion2(model, userId);

                    response = new ItemResponse<int> { Item = id };

                    return StatusCode(code, response);
            }
            catch (Exception ex)
            {
                code = 500;
                response = new ErrorResponse($"Error ${ex.Message}");

            }

            return StatusCode(code, response);
        }

        [HttpPut("{id:int}")] 
        public ActionResult<ItemResponse<int>> Update(ScheduleUpdateRequest model)
        {
            int code = 200;
            BaseResponse response = null;

            try
            {
                    int userId = _authService.GetCurrentUserId();
                    _service.Update(model, userId);
                    response = new SuccessResponse();
            }
            catch (Exception ex)
            {
                code = 500;
                response = new ErrorResponse($"Error ${ex.Message}");
            }

            return StatusCode(code, response);
        }

        [HttpDelete("{id:int}")]
        public ActionResult<SuccessResponse> Delete(int id)
        {
            int code = 200;
            BaseResponse response = null;

            try
            {
                _service.Delete(id);
                response = new SuccessResponse();
            }
            catch (Exception ex)
            {
                code = 500;
                response = new ErrorResponse(ex.Message);
            }

            return StatusCode(code, response);
        }
    }
}
