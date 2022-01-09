using Basic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Services
{
    public class BasicService
    {
        public BasicService() { }

        public async Task<Result> Success()
        {
            var result = new Result
            {
                IsSuccess = true,
                ReturnCode = "0",
                ErrorMessage = ""
            };
            return await Task.FromResult(result);
        }

        public async Task<Result> Fail()
        {
            var result = new Result
            {
                IsSuccess = false,
                ReturnCode = "999",
                ErrorMessage = "fail"
            };
            return await Task.FromResult(result);
        }
    }
}
