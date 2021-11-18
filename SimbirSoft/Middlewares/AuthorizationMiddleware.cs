using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace SimbirSoft.Middlewares
{
    /// <summary>
    /// Часть 2.2; 4 - Добавление Middleware, для запрета запроса, без хедера "Authorization" со значением "Basic admin:admin"
    /// </summary>
    public class AuthorizationMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthorizationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Проверка на хедер "Authorization" со значением "Basic admin:admin"
            if (context.Request.Headers["Authorization"] != "Basic admin:admin")
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync("Authorization failed.");
            }
            else
                await _next.Invoke(context);
        }
    }
}
