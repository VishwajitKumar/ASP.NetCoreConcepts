using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace ConsoleAppToWebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuider().Build().Run();
        }
        public static IHostBuilder CreateHostBuider()
        {
            return Host.CreateDefaultBuilder()
                  .ConfigureWebHostDefaults(webhost =>
                  {
                      webhost.UseStartup<Startup>();
                  });
        }
    }
}
