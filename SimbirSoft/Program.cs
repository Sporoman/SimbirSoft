using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace SimbirSoft
{
    /// <summary>
    /// 1 - Создание ASP.NET 5.0 Web Api проекта
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
