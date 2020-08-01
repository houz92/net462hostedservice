using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace MyHostedService
{
    internal class SomeBackgroundService : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // Here you run some process by using some custom service
            while (stoppingToken.IsCancellationRequested == false)
            {
                Console.WriteLine($"I'm the backgroud service {DateTime.UtcNow}");

                await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
            }
        }
    }
}