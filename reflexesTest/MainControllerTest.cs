using System;
using Xunit;
using Moq;
using reflexes.Controller;
using reflexes.Model;
using reflexes.View;

namespace reflexesTest
{
    public class MainControllerTest
    {

        [Fact]
        public void MainController_NewMainControllerShouldReturnMainController()
        {
            var reflexGame = new ReflexGameImplemented();
            var consoleView = new ConsoleViewImplemented();
            var levelController = new LevelControllerImplemented(reflexGame, consoleView);
            var mainController = new MainController(reflexGame, consoleView, levelController);

            Assert.IsType<MainController>(mainController);
        }

    }
}
