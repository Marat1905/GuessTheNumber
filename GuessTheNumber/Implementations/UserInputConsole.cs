using GuessTheNumber.Interfaces;
using System.Numerics;

namespace GuessTheNumber.Implementations
{
    /// <summary>Ввод данных с консоли </summary>
    internal class UserInputConsole : IUserInput
    {

        public  T GetConsoleRead<T>(Func<string?, IFormatProvider, bool> predicate, INotify notify, string text = "Введите число:",  string message = "Введенное значение должно быть числом", IFormatProvider? formatter = default) where T : INumber<T>
        {
            T? result = default;
            do
            {
                try
                {
                    Console.Write(text);
                    string? input = Console.ReadLine();
                    if (IsValid(input, message, predicate))
                    {
                        result = T.Parse(input, formatter);
                        break;
                    }
                }
                catch (Exception ex)
                {

                    if (notify == null)
                        Console.WriteLine(ex.Message);
                    else
                        notify.Error($"Ошибка: {ex.Message}");
                }
            }
            while (result != null);

            return result;
        }


        /// <summary>Метод для валидации числа</summary>
        /// <param name="digit">Текст который надо проверить что оно является числом</param>
        /// <returns></returns>
        public bool ValidDigit<T>(string? digit, IFormatProvider formatter = default) where T : INumber<T>
        {
            if (T.TryParse(digit, formatter, out T? result))
            {
                return true;
            }
            return false;
        }

        /// <summary>Метод валидации</summary>
        /// <param name="input">Входящий текст</param>
        /// <param name="message">Сообщение при ошибке</param>
        /// <param name="predicate">Делегат для проверки валидации</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private bool IsValid(string? input, string message, Func<string?, IFormatProvider?, bool> predicate, IFormatProvider? formatter = default)
        {
            return predicate(input, formatter) != true ? throw new ArgumentException(message) : true;
        }

        
    }
}
