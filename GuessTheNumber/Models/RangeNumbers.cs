namespace GuessTheNumber.Models
{
    /// <summary>Задание диапазона чисел</summary>
    public class RangeNumbers
    {
        /// <summary>Начальное число</summary>
        public int Start { get; private set; }

        /// <summary>Конечное число</summary>
        public int End { get; private set; }

        /// <summary><inheritdoc cref="RangeNumbers"/></summary>
        /// <param name="start"><inheritdoc cref="Start" path="/summary/node()"/></param>
        /// <param name="end"><inheritdoc cref="End" path="/summary/node()"/></param>
        public RangeNumbers(int start, int end)
        {
            Start = start;
            End = end;
        }
    }
}
