using GuessTheNumber.Interfaces;
using GuessTheNumber.Models;

namespace GuessTheNumber.Implementations
{
    public  class GameService: IGameService
    {
        private readonly Settings _settings;

        public GameService(Settings settings) 
        {
            _settings = settings;
        }
    }
}
