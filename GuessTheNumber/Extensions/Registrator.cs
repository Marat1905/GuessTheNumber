using GuessTheNumber.Implementations;
using GuessTheNumber.Interfaces;
using GuessTheNumber.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GuessTheNumber.Extensions
{
    public static class Registrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services 
            .AddSingleton(SettingsConfigurationManager.Configuration.Get<Settings>())
            .AddTransient<IGameService, GameService>()
            .AddTransient<INumberGenerator, NumberGenerator>()
            .AddTransient<INotify, NotifyConsole>()
            .AddTransient<IUserInput, UserInputConsole>()
            ;
    }
}
