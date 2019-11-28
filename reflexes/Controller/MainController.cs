using reflexes.Model;
using reflexes.View;
using System;
using System.Collections.Generic;
using System.Text;

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
                        _consoleView.DisplayEasyLevel();
                        while (_levelController.EasyMode()) ;
                        break;
                    case 2:
                        _consoleView.DisplayEasyLevel();
                        break;
                    case 3:
                        _consoleView.DisplayEasyLevel();
                        break;
                    case 4:
                        keepGoing = false;
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
