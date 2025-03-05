using GuessTheNumber.Interfaces;
using GuessTheNumber.Models;

namespace GuessTheNumber.Implementations
{
    /// <summary><inheritdoc cref="INumberGenerator"/></summary>
    internal class NumberGenerator: INumberGenerator
    {
        private readonly Random _random;
        private readonly Settings _settings;

        /// <summary><inheritdoc cref="INumberGenerator"/> </summary>
        /// <param name="settings">Настройки</param>
        public NumberGenerator(Settings settings)
        {
            _random = new Random();
            _settings = settings;
        }

        public virtual int Generate()
        {
            return _random.Next(_settings.Range.Start, _settings.Range.End);
        }
    }
}
