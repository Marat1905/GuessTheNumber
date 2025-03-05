using GuessTheNumber.Extensions;
using GuessTheNumber.Implementations;
using GuessTheNumber.Interfaces;
using GuessTheNumber.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using GuessTheNumber.Extensions;

namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var myGame = host.Services.GetRequiredService<IGameService>();
            myGame.StartGame();

            Console.WriteLine("Hello, World!");
        }

       
        public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                services.AddServices();
            });
    }
}
