namespace GuessTheNumber.Interfaces
{
    /// <summary> Генератор чисел в заданном диапазоне</summary>
    public interface INumberGenerator
    {
        /// <summary>Генератор числа</summary>
        /// <returns>С генерированное число</returns>
        public int Generate();
    }
}
