using Microsoft.Extensions.Configuration;

namespace GuessTheNumber.Extensions
{
    public static class SettingsConfigurationManager
    {
        public static readonly IConfigurationRoot Configuration;

        static SettingsConfigurationManager()
        {
            Configuration = new ConfigurationBuilder().AddJsonFile("Settings.json").Build();
        }
    }
}
