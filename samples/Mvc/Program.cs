using FluffySpoon.AspNet.NGrok;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                        .UseStartup<Startup>()
                        .UseNGrok();
                });
        }
    }
}