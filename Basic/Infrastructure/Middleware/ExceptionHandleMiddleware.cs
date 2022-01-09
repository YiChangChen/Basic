using Basic.Infrastructure.ExceptionHandler;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Basic.Infrastructure.Middleware
{
    public class ExceptionHandleMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandleMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch(NimbleException ex)
            {
                await HandleExceptionAsync(context, ex);
            }
            catch (Exception exception)
            {
                await HandleExceptionAsync(context, exception);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
           
            return context.Response.WriteAsync(
                $"{context.Response.StatusCode} Internal Server Error from the ExceptionHandle middleware."
            );
        }


        private static Task HandleExceptionAsync(HttpContext context, NimbleException exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;

            return context.Response.WriteAsync(
                $"{context.Response.StatusCode} Internal Server Error from the ExceptionHandle middleware."
            );
        }
    }
}
