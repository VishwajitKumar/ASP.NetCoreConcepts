using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppToWebApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            //services.AddTransient<CustomMiddleware>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            //app.UseMiddleware<CustomMiddleware>();
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from run 1 1\n");
            //    await next();
            //    await context.Response.WriteAsync("Hello from run 1 2\n");
            //});
            //app.Map("/vishwajit",PrintName);
            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello from run 2 1");
            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from run 2 2\n");
            //    await next();
            //});
            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello from run 3 1");
            //});
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            //app.UseEndpoints(endpoint =>
            //{
            //    endpoint.MapGet("/",async context =>await context.Response.WriteAsync("Hi"));

            //});
            //app.UseEndpoints(endpoint =>
            //{
            //    endpoint.MapGet("/test", async context => await context.Response.WriteAsync("Hi test"));

            //});
            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }

        private void PrintName(IApplicationBuilder app)
        {
            app.Run(async context =>{
                await context.Response.WriteAsync("Hello from Map");
            });
        }
    }
}
