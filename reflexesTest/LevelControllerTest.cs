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

        [Fact]
        public void EasyMode_WhenGameIsCompletedReadKeyIsCalled()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);
            mockReflexGame.Setup(game => game.IsGameCompleted()).Returns(true);

            levelController.EasyMode();
            mockConsoleView.Verify(view => view.ReadKey(), Times.Once());
        }

        [Fact]
        public void EasyMode_ShouldCallPresentLetterWithGetNewLetterAsArgument()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);

            levelController.EasyMode();
            mockConsoleView.Verify(view => view.PresentLetter(mockReflexGame.Object.GetNewLetter()), Times.Once());
        }

        [Fact]
        public void EasyMode_ShouldCallCreateStopwatch()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);

            levelController.EasyMode();
            mockReflexGame.Verify(game => game.CreateStopwatch(), Times.Once());
        }

        [Fact]
        public void EasyMode_ShouldCallStartStopwatch()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);

            levelController.EasyMode();
            mockReflexGame.Verify(game => game.StartStopwatch(), Times.Once());
        }

        [Fact]
        public void EasyMode_ShouldCallGetInput()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);

            levelController.EasyMode();
            mockConsoleView.Verify(view => view.GetInput(), Times.Once());
        }

        [Fact]
        public void EasyMode_ShouldCallStopStopwatch()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);

            levelController.EasyMode();
            mockReflexGame.Verify(game => game.StopStopwatch(), Times.Once());
        }

        [Fact]
        public void EasyMode_WhenNotInTimeTooLongTimeIsCalled()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);
            mockReflexGame.Setup(game => game.IsInTime()).Returns(false);

            levelController.EasyMode();
            mockConsoleView.Verify(view => view.TooLongTime(), Times.Once());
        }

        [Fact]
        public void EasyMode_WhenNotInTimeGameOverIsCalledWithWordsLeftAsArgument()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);
            mockReflexGame.Setup(game => game.IsInTime()).Returns(false);

            levelController.EasyMode();
            mockConsoleView.Verify(view => view.GameOver(mockReflexGame.Object.WordsLeft()), Times.Once());
        }

        [Fact]
        public void EasyMode_WhenNotInTimeDisplayPressAKeyToContinueIsCalled()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);
            mockReflexGame.Setup(game => game.IsInTime()).Returns(false);

            levelController.EasyMode();
            mockConsoleView.Verify(view => view.DisplayPressAKeyToContinue(), Times.Once());
        }
    }
}
