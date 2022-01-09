using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Basic.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Basic.Controllers
{
    public class BasicController<T> : ControllerBase where T : class
    {
        private readonly ILogger<T> _logger;

        protected ILogger<T> logger => (ILogger<T>)(_logger ?? HttpContext.RequestServices.GetService(typeof(ILogger<T>)));

        protected async Task<ActionResult<Result>> Success()
        {
            var result = new Result
            {
                IsSuccess = true,
                ReturnCode = "0",
                ErrorMessage = ""
            };
            return new OkObjectResult(result);
        }

        protected async Task<ActionResult<Result>> Fail()
        {
            var result = new Result
            {
                IsSuccess = false,
                ReturnCode = "999",
                ErrorMessage = "fail"
            };
            return new OkObjectResult(result);
        }
    }
}
