﻿using GuessTheNumber.Interfaces;
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

        public GameService(Settings settings,INumberGenerator generator,IUserInput input, INotify notify ) 
        {
            _settings = settings;
            _generator = generator;
            _input = input;
            _notify = notify;
        }

        public void StartGame()
        {
            var number = _generator.Generate();

            _notify.Information($"Угадайте число от {_settings.Range.Start} до {_settings.Range.End}!!!!");

            //while (true)
            //{

            //}
        }
    }
}
