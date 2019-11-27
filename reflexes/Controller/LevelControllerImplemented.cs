using System;
using reflexes.Model;
using reflexes.View;

namespace reflexes.Controller
{
    public class LevelControllerImplemented : LevelController
    {

        private ReflexGame _reflexGame;
        private ConsoleView _consoleView;

        public LevelControllerImplemented(ReflexGame reflexGame, ConsoleView consoleView)
        {
            _reflexGame = reflexGame;
            _consoleView = consoleView;
        }
        public bool EasyMode()
        {
            if (_reflexGame.IsGameCompleted())
            {
                _consoleView.GameCompleted();
                _consoleView.DisplayPressAKeyToContinue();
               
                return false;
            }
           
            return true;
        }

    }
}
