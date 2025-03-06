using GuessTheNumber.Interfaces;
using GuessTheNumber.Models;
using System.Reflection;

namespace GuessTheNumber.Implementations
{
    /// <summary><inheritdoc cref="IGameService"/> </summary>
    public  class GameService: IGameService
    {
        private readonly Settings _settings;
        private readonly INumberGenerator _generator;
        private readonly IUserInput _input;
        private readonly INotify _notify;
        private int _retryCount;

        public GameService(Settings settings,INumberGenerator generator,IUserInput input, INotify notify ) 
        {
            _settings = settings;
            _generator = generator;
            _input = input;
            _notify = notify;
        }

        public void StartGame()
        {
            var secretNumber = _generator.Generate();
            _retryCount = 0;

            _notify.Information($"Угадайте число от {_settings.Range.Start} до {_settings.Range.End}!!!!");

            while (true)
            {
                if (_retryCount >= _settings.MaxRetryCount)
                {
                    _notify.Error("Вы использовали максимальное количество попыток");
                    break;
                }

                int userInput = _input.GetConsoleRead<int>(_input.ValidDigit<int>, _notify, "Введите число:");

                if (ValidateNumber(CompareNumber, secretNumber, userInput))
                {
                    _notify.Print("Вы угадали число!!!!");
                    break;
                }          
                  _retryCount++;
            }      
        }

        /// <summary>Метод для проверки числа</summary>
        /// <param name="compare">Метод для сравнения<</param>
        /// <param name="secretNumber">Секретное число</param>
        /// <param name="UserNumber">Число полученное от пользователя</param>
        /// <param name="textOver">Текст если число больше заданного</param>
        /// <param name="textUnder">Текст если число меньше заданного</param>
        /// <returns>Если заданное число равно числу от пользователя возвращаем истину</returns>
        private bool ValidateNumber(Func<int,int,int> compare, int secretNumber,int UserNumber, string textOver = "Ваше число больше загаданного", string textUnder = "Ваше число меньше загаданного")
        {
            var result = compare(secretNumber, UserNumber);
            if (result == 1)
            {
                _notify.Warning(textUnder);
                return false;
            }
            else if (result == -1)
            {
                _notify.Warning(textOver);
                return false;
            }
            return true;
        }

        /// <summary>Метод для сравнения</summary>
        /// <param name="secretNumber">Секретное число</param>
        /// <param name="userNumber">Число полученное от пользователя</param>
        /// <returns></returns>
        private int CompareNumber(int secretNumber,int userNumber)
        {
             return secretNumber.CompareTo(userNumber);
        }
    }
}
