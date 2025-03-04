using GuessTheNumber.Models;

namespace GuessTheNumber.Interfaces
{
    /// <summary>Настройки игры </summary>
    public interface ISettings
    {
        /// <summary>Максимальное количество попыток</summary>
        int MaxRetryCount { get; set; }

        /// <summary><inheritdoc cref="RangeNumbers"/></summary>
        RangeNumbers Range { get; set; }
    }
}
