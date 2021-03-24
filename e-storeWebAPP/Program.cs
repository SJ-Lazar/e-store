using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_storeWebAPP
{
    public class Program
    {
        public static void Main(string[] args)
        {

            #region SerilogSetup
            Log.Logger = new LoggerConfiguration()
                  .WriteTo
                  .File(
                      path: "c:\\Users\\Lenovo\\Desktop\\LoggerFIles\\log-.txt",
                           outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
                           rollingInterval: RollingInterval.Day,
                           restrictedToMinimumLevel: LogEventLevel.Information
                           ).CreateLogger();
            #endregion

            #region CallingHostBuilder
            try
            {
                Log.Information("Application is starting.");
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Application failed to start.");
            }
            finally
            {
                Log.CloseAndFlush();
            } 
            #endregion

        }

        #region HostBuilder
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                }); 
        #endregion
    }
}
