using Microsoft.Extensions.Logging;
using System.Numerics;

namespace GuessTheNumber.Interfaces
{
    /// <summary>Ввод от пользователя</summary>
    public interface IUserInput
    {
        /// <summary>Получение значения с консоли</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="predicate">Для валидации</param>
        /// <param name="notify">Вывод информации</param>
        /// <param name="text">Текст для представления</param>
        /// <param name="message">Текст для ошибки</param>
        /// <param name="formatter"></param>
        /// <returns>Возвращаем число</returns>
        T GetConsoleRead<T>(Func<string?, IFormatProvider, bool> predicate, INotify notify, string text = "Введите число:" , string message = "Введенное значение должно быть числом", IFormatProvider? formatter = default) where T : INumber<T>;


        /// <summary>Метод для валидации числа</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="digit">Текст который надо проверить что оно является числом</param>
        /// <param name="formatter"></param>
        /// <returns></returns>
        bool ValidDigit<T>(string? digit, IFormatProvider formatter = default) where T : INumber<T>;
    }
}
