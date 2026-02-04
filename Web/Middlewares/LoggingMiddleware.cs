using System.Globalization;
using Web.Middlewares;

namespace Web.Middlewares
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        // private readonly ILogger<LoggingMiddleware> _logger;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {

            // _logger.LogInformation($" Request: {context.Request.Method} {context.Request.Path}");
            Console.WriteLine($"Request received: [{context.Request.Method}] {context.Request.Path} - {DateTime.Now:dd-MM-yyyy HH:mm:ss}");

            await _next(context);

        }
    }
}

public static class Logger
{
    public static IApplicationBuilder UseLogger(
        this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<LoggingMiddleware>();
    }
}