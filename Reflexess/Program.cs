using reflexes.Controller;
using reflexes.Model;
using reflexes.View;
using System;
using System.Diagnostics.CodeAnalysis;

namespace reflexes
{
    [ExcludeFromCodeCoverage]
    class Program
    {
        [ExcludeFromCodeCoverage]
        static void Main(string[] args)
        {
            ReflexGame reflexGame = new ReflexGameImplemented();
            ConsoleView consoleView = new ConsoleViewImplemented();
            LevelController levelController = new LevelControllerImplemented(reflexGame, consoleView);
            MainController mainController = new MainController(reflexGame, consoleView, levelController);
            mainController.RunApplication();
        }
    }
}
