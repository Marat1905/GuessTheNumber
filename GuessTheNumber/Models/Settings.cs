namespace GuessTheNumber.Models
{
    /// <summary>Настройки игры </summary>
    public class Settings
    {
        /// <summary>Максимальное количество попыток</summary>
        public int MaxRetryCount { get; set; }

        /// <summary><inheritdoc cref="RangeNumbers"/></summary>
        public RangeNumbers Range { get; set; }
    }
}
