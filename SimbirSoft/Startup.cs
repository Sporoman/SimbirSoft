using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using SimbirSoft.Middlewares;
using SimbirSoft.Repositories.Interfaces;
using SimbirSoft.Repositories;
using SimbirSoft.Services;

namespace SimbirSoft
{
    public class Startup
    {
        public IConfiguration Config { get; }

        public Startup(IConfiguration config)
        {
            Config = config;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            string connection = Config.GetConnectionString("DefaultConnection");
            services.AddDbContext<DbContext>(options => options.UseSqlServer(connection));

            services.AddTransient<IBookRepository, BookRepository>();
            services.AddTransient<BookService>();

            services.AddControllers();

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Simbirsoft", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(options => options.SwaggerEndpoint("/swagger/v1/swagger.json", "Simbirsoft v1"));
            }

            app.UseRouting();

            // Включаем сюда наши middlewares
            //app.UseMiddleware<RequestTimeLoggerMiddleware>();
            //app.UseMiddleware<AuthorizationMiddleware>();

            app.UseEndpoints(endpoints => 
            {
                endpoints.MapControllers();
            });
        }
    }
}
