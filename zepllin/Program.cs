using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
namespace zepllin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging((hostcontext,logging) =>
                {
                    logging.AddConfiguration(hostcontext.Configuration.GetSection("Logging"));
                    logging.AddDebug();
                    logging.AddNLog();
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                #region
                    webBuilder.UseKestrel();
                        //kest.Limits.MaxConcurrentConnections = 200;
                        //kest.Limits.MaxConcurrentUpgradedConnections = 200;
                        ////kest.Limits.MaxRequestBodySize = 90 * 4024; /* TODO Değiştirilebilir */
                        //kest.Limits.MinRequestBodyDataRate = new MinDataRate(bytesPerSecond: 100, gracePeriod: TimeSpan.FromSeconds(15));
                        //kest.Limits.MinResponseDataRate = new MinDataRate(bytesPerSecond: 100, gracePeriod: TimeSpan.FromSeconds(15));
                    webBuilder.UseContentRoot(Directory.GetCurrentDirectory());
                    webBuilder.CaptureStartupErrors(true);
                    webBuilder.SuppressStatusMessages(true);
                    webBuilder.UseStartup<Startup>();
                    #endregion
                });
    }
}
