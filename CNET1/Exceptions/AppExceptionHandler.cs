using System.Net;

namespace CNET1.Exceptions
{
    public class AppExceptionHandler(RequestDelegate next)
    {
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                AppErrorDTO errorDTO = new(
                    ex.InnerException?.Message ?? "INTERNAL_SERVER_ERROR",
                    ex.Message,
                    "INTERNAL_SERVER_ERROR",
                    (int)HttpStatusCode.InternalServerError,
                    DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss")
                );

                await context.Response.WriteAsJsonAsync(errorDTO);
            }
        }
    }
}
