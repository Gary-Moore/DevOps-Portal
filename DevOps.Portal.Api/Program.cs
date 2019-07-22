using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Serilog;
using Serilog.Events;

namespace DevOps.Portal.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseSerilog((context, config) =>
                    config.Enrich.FromLogContext()
                        .MinimumLevel.Information()
                        .WriteTo.Sentry(s =>
                        {
                            s.MinimumBreadcrumbLevel = LogEventLevel.Information;
                            s.MinimumEventLevel = LogEventLevel.Error;
                        }))
                .UseSentry();
    }
}
