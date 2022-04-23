using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;/*

namespace MagicOnionExamples.Server
{
    class Program
    {
        static async Task Main(string[] args)
        {
            GrpcEnvironment.SetLogger(new Grpc.Core.Logging.ConsoleLogger());

            await MagicOnionHost.CreateDefaultBuilder()
                .UseMagicOnion(
                    new MagicOnionOptions(isReturnExceptionStackTraceInErrorDetail: true),
                    new ServerPort("0.0.0.0", 12345, ServerCredentials.Insecure))
                .RunConsoleAsync();
        }
    }
}*/

namespace HQDotNet.MagicOnionModule.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                //.UseKestrel()
                //.UseWindowsService()
                /*.ConfigureAppConfiguration((context, builder) =>
                {
                    var environment = context.HostingEnvironment.EnvironmentName;
                    builder.AddAppSettings(environment);
                })*/

                .UseContentRoot(Directory.GetCurrentDirectory())
                .ConfigureWebHostDefaults(builder =>
                {
                    builder.UseStartup<Startup>();
                });
    }
}