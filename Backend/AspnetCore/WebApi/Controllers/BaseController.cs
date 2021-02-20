using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Utility.Helpers;

namespace WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected IActionResult ApiResult<T>(Result<T> result)
        {
            if (result.HasError)
            {
                return BadRequest(new ApiResult<T>
                {
                    Code = result.StatusCode,
                    Errors = result.Errors,
                    Message = result.Message
                });
            }

            if (result.StatusCode == StatusCodes.Status404NotFound)
            {
                
                return NotFound(
                  new ApiResult<T>
                  {
                      Code = result.StatusCode,
                      Message = result.Message
                  }
                    );
            }   
            if (result.StatusCode == StatusCodes.Status401Unauthorized)
            {   
                return Unauthorized(
                  new ApiResult<T>
                  {
                      Code = result.StatusCode,
                      Message = result.Message
                  }
                    );
            }

            
            return Ok(new ApiResult<T>
            {
                Code = result.StatusCode,
                Data = result.Data,
                Message = result.Message,
            });



        }
    }


    internal class ApiResult<T>
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public List<string> Errors { get; set; }
    }
}
