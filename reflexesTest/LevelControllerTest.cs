using System;
using Xunit;
using Moq;
using reflexes.Controller;
using reflexes.Model;
using reflexes.View;

namespace reflexesTest
{
    public class LevelControllerTest
    {

        [Fact]
        public void LevelController_NewLevelControllerShouldReturnLevelController()
        {
            var reflexGame = new ReflexGameImplemented();
            var consoleView = new ConsoleViewImplemented();
            var controller = new LevelControllerImplemented(reflexGame, consoleView);

            Assert.IsType<LevelControllerImplemented>(controller);
        }

        [Fact]
        public void EasyMode_WhenGameIsCompletedGameCompletedIsCalled()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);
            mockReflexGame.Setup(game => game.IsGameCompleted()).Returns(true);

            levelController.EasyMode();
            mockConsoleView.Verify(view => view.GameCompleted(), Times.Once());
        }

        [Fact]
        public void EasyMode_WhenGameIsCompletedDisplayPressAKeyToContinueIsCalled()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);
            mockReflexGame.Setup(game => game.IsGameCompleted()).Returns(true);

            levelController.EasyMode();
            mockConsoleView.Verify(view => view.DisplayPressAKeyToContinue(), Times.Once());
        }
    }
}
