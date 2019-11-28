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

    }
}
