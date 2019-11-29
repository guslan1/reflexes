using System;
using Xunit;
using Moq;
using reflexes.Model;
using reflexes.View;
using reflexes.Controller;

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
        public void Easy_ShouldSetMaxTime()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);
            levelController.Easy();

            mockReflexGame.VerifySet(game => game.MaxTime = It.IsAny<TimeSpan>(), Times.Once());
        }

        [Fact]
        public void Easy_ShouldGetEasyMode()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);
            levelController.Easy();

            mockReflexGame.VerifyGet(game => game.EasyMode);
        }

        [Fact]
        public void Medium_ShouldSetMaxTime()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);
            levelController.Medium();

            mockReflexGame.VerifySet(game => game.MaxTime = It.IsAny<TimeSpan>(), Times.Once());
        }

        [Fact]
        public void Medium_ShouldGetMediumMode()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);
            levelController.Medium();

            mockReflexGame.VerifyGet(game => game.MediumMode);
        }

        [Fact]
        public void Hard_ShouldSetMaxTime()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);
            levelController.Hard();

            mockReflexGame.VerifySet(game => game.MaxTime = It.IsAny<TimeSpan>(), Times.Once());
        }

        [Fact]
        public void Hard_ShouldGetHardMode()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);
            levelController.Hard();

            mockReflexGame.VerifyGet(game => game.HardMode);
        }

        [Fact]
        public void Play_WhenGameIsCompletedGameCompletedIsCalled()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);
            mockReflexGame.Setup(game => game.IsGameCompleted()).Returns(true);

            levelController.Play();
            mockConsoleView.Verify(view => view.GameCompleted(), Times.Once());
        }

        [Fact]
        public void Play_WhenGameIsCompletedDisplayPressAKeyToContinueIsCalled()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);
            mockReflexGame.Setup(game => game.IsGameCompleted()).Returns(true);

            levelController.Play();
            mockConsoleView.Verify(view => view.DisplayPressAKeyToContinue(), Times.Once());
        }

        [Fact]
        public void Play_WhenGameIsCompletedReadKeyIsCalled()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);
            mockReflexGame.Setup(game => game.IsGameCompleted()).Returns(true);

            levelController.Play();
            mockConsoleView.Verify(view => view.ReadKey(), Times.Once());
        }

        [Fact]
        public void Play_ShouldCallPresentLetterWithGetNewLetterAsArgument()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);

            levelController.Play();
            mockConsoleView.Verify(view => view.PresentLetter(mockReflexGame.Object.GetNewLetter()), Times.Once());
        }

        [Fact]
        public void Play_ShouldCallCreateStopwatch()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);

            levelController.Play();
            mockReflexGame.Verify(game => game.CreateStopwatch(), Times.Once());
        }

        [Fact]
        public void Play_ShouldCallStartStopwatch()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);

            levelController.Play();
            mockReflexGame.Verify(game => game.StartStopwatch(), Times.Once());
        }

        [Fact]
        public void Play_ShouldCallGetInput()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);

            levelController.Play();
            mockConsoleView.Verify(view => view.GetInput(), Times.Once());
        }

        [Fact]
        public void Play_ShouldCallStopStopwatch()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);

            levelController.Play();
            mockReflexGame.Verify(game => game.StopStopwatch(), Times.Once());
        }

        [Fact]
        public void Play_WhenNotInTimeTooLongTimeIsCalled()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);
            mockReflexGame.Setup(game => game.IsInTime()).Returns(false);

            levelController.Play();
            mockConsoleView.Verify(view => view.TooLongTime(), Times.Once());
        }

        [Fact]
        public void Play_WhenNotInTimeGameOverIsCalledWithWordsLeftAsArgument()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);
            mockReflexGame.Setup(game => game.IsInTime()).Returns(false);

            levelController.Play();
            mockConsoleView.Verify(view => view.GameOver(mockReflexGame.Object.WordsLeft()), Times.Once());
        }

        [Fact]
        public void Play_WhenNotInTimeDisplayPressAKeyToContinueIsCalled()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);
            mockReflexGame.Setup(game => game.IsInTime()).Returns(false);

            levelController.Play();
            mockConsoleView.Verify(view => view.DisplayPressAKeyToContinue(), Times.Once());
        }

        [Fact]
        public void Play_WhenNotInTimeReadKeyIsCalled()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);
            mockReflexGame.Setup(game => game.IsInTime()).Returns(false);

            levelController.Play();
            mockConsoleView.Verify(view => view.ReadKey(), Times.Once());
        }

        [Fact]
        public void Play_IfNotCorrectInputGameOverIsCalledWithWordsLeftAsArgument()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);
            mockReflexGame.Setup(game => game.IsInTime()).Returns(true);
            mockReflexGame.Setup(game => game.IsCorrectInput(mockConsoleView.Object.GetInput())).Returns(false);

            levelController.Play();
            mockConsoleView.Verify(view => view.GameOver(mockReflexGame.Object.WordsLeft()), Times.Once());
        }

        [Fact]
        public void Play_IfNotCorrectInputDisplayPressAKeyToContinueIsCalled()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);
            mockReflexGame.Setup(game => game.IsInTime()).Returns(true);
            mockReflexGame.Setup(game => game.IsCorrectInput(mockConsoleView.Object.GetInput())).Returns(false);

            levelController.Play();
            mockConsoleView.Verify(view => view.DisplayPressAKeyToContinue(), Times.Once());
        }

        [Fact]
        public void Play_IfNotCorrectInputReadKeyIsCalled()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);
            mockReflexGame.Setup(game => game.IsInTime()).Returns(true);
            mockReflexGame.Setup(game => game.IsCorrectInput(mockConsoleView.Object.GetInput())).Returns(false);

            levelController.Play();
            mockConsoleView.Verify(view => view.ReadKey(), Times.Once());
        }

        [Fact]
        public void Play_IfCorrectInputInTimeRemoveLetterFromAlphabetIsCalled()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();

            var levelController = new LevelControllerImplemented(mockReflexGame.Object, mockConsoleView.Object);
            mockReflexGame.Setup(game => game.IsInTime()).Returns(true);
            mockReflexGame.Setup(game => game.IsCorrectInput(mockConsoleView.Object.GetInput())).Returns(true);

            levelController.Play();
            mockReflexGame.Verify(game => game.RemoveLetterFromAlphabet(), Times.Once());
        }
    }
}
