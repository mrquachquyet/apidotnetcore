using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using G_Stars.Api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace G_Stars.Api.Controllers
{
    public class BaseController : ControllerBase
    {
        protected ActionResult DefauResult(object model)
        {
            var list = JsonConvert.SerializeObject(model,
            Formatting.None,
            new JsonSerializerSettings()
            {
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            });
            return Content(list, "application/json");
        }

        protected ObjectResult Ok(object data = null, string message = "Ok")
        {
            return StatusCode(200, GetResultModel(data, message, 200));
        }

        protected ObjectResult OkPagination(object data, int numberOfPages = 1, int totalRecords = 0)
        {
            return Ok(new ResponseModel
            {
                Data = data,
                TotalRecords = totalRecords,
                StatusCode = 200
            });
        }

        protected ObjectResult OkPagination(object data, int totalRecords = 0)
        {
            return Ok(new ResponseModel
            {
                StatusCode = 200,
                Data = data,
                TotalRecords = totalRecords
            });
        }
        protected ObjectResult BadRequest(string message = "Bad Request", object data = null)
        {
            return StatusCode(400, GetResultModel(data, message, 400));
        }
        //protected ObjectResult Accepted(string message = "Bad Request", object data = null)
        //{
        //    return StatusCode(202, GetResultModel(data, message, 202));
        //}
        protected ObjectResult Unauthorized(string message = "Unauthorized", object data = null)
        {
            return StatusCode(401, GetResultModel(data, message, 401));
        }

        protected ObjectResult Forbidden(string message = "Forbidden", object data = null)
        {
            return StatusCode(403, GetResultModel(data, message, 403));
        }

        protected ObjectResult NotFound(string message = "Not Found", object data = null)
        {
            return StatusCode(404, GetResultModel(data, message, 404));
        }

        protected ObjectResult InternalServerError(string message = "Internal Server Error", object data = null)
        {
            return StatusCode(500, GetResultModel(data, message, 500));
        }

        protected ObjectResult NotImplemented(string message = "Not Implemented", object data = null)
        {
            return StatusCode(501, GetResultModel(data, message, 501));
        }
        private ResultModel GetResultModel(object data, string message, int StatusCode)
        {
            return new ResultModel
            {
                Message = message,
                Data = data,
                StatusCode = StatusCode,
            };
        }

        protected string getUserName()
        {
            if (HttpContext != null)
                return HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
            return string.Empty;

        }
        protected int getUserID()
        {
            if (HttpContext != null)
                return int.Parse(HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Sid)?.Value);
            return 0;
        }
    }
}