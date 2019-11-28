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

        public void EasyModee()
        {
            _reflexGame.MaxTime = _reflexGame.EasyMode;
        }

        public void Medium()
        {
            _reflexGame.MaxTime = _reflexGame.MediumMode;
        }

        public bool EasyMode()
        {
            if (_reflexGame.IsGameCompleted())
            {
                _consoleView.GameCompleted();
                _consoleView.DisplayPressAKeyToContinue();
                _consoleView.ReadKey();
                return false;
            }
            else
            {
                _consoleView.PresentLetter(_reflexGame.GetNewLetter());
                _reflexGame.CreateStopwatch();
                _reflexGame.StartStopwatch();

                string input = _consoleView.GetInput();
                _reflexGame.StopStopwatch();

                if (!_reflexGame.IsInTime())
                {
                    _consoleView.TooLongTime();
                    _consoleView.GameOver(_reflexGame.WordsLeft());
                    _consoleView.DisplayPressAKeyToContinue();
                    _consoleView.ReadKey();
                    return false;
                }

                if (!_reflexGame.IsCorrectInput(input))
                {
                    _consoleView.GameOver(_reflexGame.WordsLeft());
                    _consoleView.DisplayPressAKeyToContinue();
                    _consoleView.ReadKey();
                    return false;
                }

                _reflexGame.RemoveLetterFromAlphabet();




            }
            return true;
        }
    }
}
