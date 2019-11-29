using reflexes.Model;
using reflexes.View;

namespace reflexes.Controller
{
    public class MainController
    {
        private ReflexGame _reflexGame;
        private ConsoleView _consoleView;
        private LevelController _levelController;

        public MainController(ReflexGame reflexGame, ConsoleView consoleView, LevelController levelController)
        {
            _reflexGame = reflexGame;
            _consoleView = consoleView;
            _levelController = levelController;
        }

        public void RunApplication()
        {
            int nextAction;
            bool keepGoing = true;
            while (keepGoing)
            {
                _consoleView.DisplayGreetingMessage();
                _consoleView.DisplayMenuChoices();
                _consoleView.DisplayLevelSelection();
                nextAction = _consoleView.GetAction();

                switch (nextAction)
                {
                    case 1:
                        _reflexGame.StartGame(new AlphabetImplemented());
                        _consoleView.DisplayEasyLevel();
                        _levelController.Easy();
                        while (_levelController.Play());
                        break;
                    case 2:
                        _reflexGame.StartGame(new AlphabetImplemented());
                        _consoleView.DisplayMediumLevel();
                        _levelController.Medium();
                        while (_levelController.Play()) ;
                        break;
                    case 3:
                        _reflexGame.StartGame(new AlphabetImplemented());
                        _consoleView.DisplayHardLevel();
                        _levelController.Hard();
                        while (_levelController.Play()) ;
                        break;
                    case 4:

                        break;
                    default:
                        _consoleView.DisplayLevelSelectionClarification();
                        _consoleView.DisplayPressAKeyToContinue();
                        _consoleView.ReadKey();
                        break;
                }

            }
        }
    }
}
