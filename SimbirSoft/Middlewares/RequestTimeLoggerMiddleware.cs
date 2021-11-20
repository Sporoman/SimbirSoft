using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace SimbirSoft.Middlewares
{
    /// <summary>
    /// Часть 2.2; 3 - Добавление Middleware, для логирования времени запроса
    /// </summary>
    public class RequestTimeLoggerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public RequestTimeLoggerMiddleware(RequestDelegate next, ILogger<RequestTimeLoggerMiddleware> logger)
        {
            _next   = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Считываем время и вызываем следующий middleware
            DateTimeOffset startTime = DateTimeOffset.Now;
            await _next.Invoke(context);

            // После отработки запроса ещё раз считываем время и вычисляем время отрабоки запроса
            DateTimeOffset endTime = DateTimeOffset.Now;
            _logger.LogInformation($"Время запроса: {startTime.ToString("HH:mm:ss:ffff")} - {endTime.ToString("HH:mm:ss:ffff")} \n" +
                                   $"      Время выполнения запроса: {(endTime- startTime).TotalSeconds}");
        }
    }
}
