namespace GuessTheNumber.Interfaces
{
    /// <summary>Вывод</summary>
    public interface INotify
    {
        /// <summary>Ответ пользователю</summary>
        /// <param name="message">Текст</param>
        void Print(string message);

        /// <summary>Ответ пользователю об ошибке</summary>
        /// <param name="message">Текст</param>
        void Error(string message);

        /// <summary>Информативный ответ пользователю</summary>
        /// <param name="message">Текст</param>
        void Information(string message);

        /// <summary>Предупреждающий ответ пользователю </summary>
        /// <param name="message">Текст</param>
        void Warning(string message);
    }
}
