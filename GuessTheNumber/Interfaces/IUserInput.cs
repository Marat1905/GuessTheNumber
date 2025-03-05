namespace GuessTheNumber.Interfaces
{
    /// <summary>Ввод от пользователя</summary>
    public interface IUserInput
    {
        /// <summary>Чтение значения от пользователя </summary>
        /// <returns>Число полученное от пользователя</returns>
        public int Read();
    }
}
