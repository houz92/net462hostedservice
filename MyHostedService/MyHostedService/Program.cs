using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace MyHostedService
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            // Press Ctrl + C to exist application
            Console.WriteLine("Starting program");

            // Building and running host
            await CreateHostBuilder(args).RunConsoleAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                       .ConfigureServices((hostContext, services) => Program.ConfigureServices(hostContext, services));
        }

        private static void ConfigureServices(HostBuilderContext hostContext, IServiceCollection services)
        {
            // Here configure DI container
            services.AddHostedService<SomeBackgroundService>();
        }
    }
}
