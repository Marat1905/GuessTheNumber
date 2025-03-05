using GuessTheNumber.Interfaces;

namespace GuessTheNumber.Implementations
{
    /// <summary>Ввод данных с консоли </summary>
    internal class UserInputConsole : IUserInput
    {
        public int Read()
        {
            if (int.TryParse(Console.ReadLine(), out int number))
                return number;
            return -1;
        }
    }
}
