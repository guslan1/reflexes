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

        [Fact]
        public void RunApplication_ShouldCallGetAction()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();
            var mockLevelController = new Mock<LevelController>();

            var mainController = new MainController(mockReflexGame.Object, mockConsoleView.Object, mockLevelController.Object);
            mockConsoleView.Setup(view => view.GetAction()).Returns(4);

            mainController.RunApplication();
            mockConsoleView.Verify(view => view.GetAction(), Times.Once());
        }

        [Fact]
        public void RunApplication_ShouldCallDisplayLevelSelectionClarification()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();
            var mockLevelController = new Mock<LevelController>();

            var mainController = new MainController(mockReflexGame.Object, mockConsoleView.Object, mockLevelController.Object);
            mockConsoleView.SetupSequence(view => view.GetAction()).Returns(5).Returns(4);

            mainController.RunApplication();
            mockConsoleView.Verify(view => view.DisplayLevelSelectionClarification(), Times.Once());
        }

        [Fact]
        public void RunApplication_ShouldCallDisplayPressAKeyToContinue()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();
            var mockLevelController = new Mock<LevelController>();

            var mainController = new MainController(mockReflexGame.Object, mockConsoleView.Object, mockLevelController.Object);
            mockConsoleView.SetupSequence(view => view.GetAction()).Returns(5).Returns(4);

            mainController.RunApplication();
            mockConsoleView.Verify(view => view.DisplayPressAKeyToContinue(), Times.Once());
        }

        [Fact]
        public void RunApplication_ShouldCallReadKey()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();
            var mockLevelController = new Mock<LevelController>();

            var mainController = new MainController(mockReflexGame.Object, mockConsoleView.Object, mockLevelController.Object);
            mockConsoleView.SetupSequence(view => view.GetAction()).Returns(5).Returns(4);

            mainController.RunApplication();
            mockConsoleView.Verify(view => view.ReadKey(), Times.Once());
        }

        [Fact]
        public void RunApplication_ShouldCallDisplayGreetingMessage()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();
            var mockLevelController = new Mock<LevelController>();

            var mainController = new MainController(mockReflexGame.Object, mockConsoleView.Object, mockLevelController.Object);
            mockConsoleView.Setup(view => view.GetAction()).Returns(4);

            mainController.RunApplication();
            mockConsoleView.Verify(view => view.DisplayGreetingMessage(), Times.Once());
        }

        [Fact]
        public void RunApplication_ShouldCallDisplayMenuChoices()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();
            var mockLevelController = new Mock<LevelController>();

            var mainController = new MainController(mockReflexGame.Object, mockConsoleView.Object, mockLevelController.Object);
            mockConsoleView.Setup(view => view.GetAction()).Returns(4);

            mainController.RunApplication();
            mockConsoleView.Verify(view => view.DisplayMenuChoices(), Times.Once());
        }

        [Fact]
        public void RunApplication_ShouldCallDisplayLevelSelection()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();
            var mockLevelController = new Mock<LevelController>();

            var mainController = new MainController(mockReflexGame.Object, mockConsoleView.Object, mockLevelController.Object);
            mockConsoleView.Setup(view => view.GetAction()).Returns(4);

            mainController.RunApplication();
            mockConsoleView.Verify(view => view.DisplayLevelSelection(), Times.Once());
        }

        [Fact]
        public void RunApplication_CaseOneShouldCallPlay()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();
            var mockLevelController = new Mock<LevelController>();

            var mainController = new MainController(mockReflexGame.Object, mockConsoleView.Object, mockLevelController.Object);
            mockLevelController.SetupSequence(levelController => levelController.Play()).Returns(true).Returns(false);
            mockConsoleView.SetupSequence(view => view.GetAction()).Returns(1).Returns(4);

            mainController.RunApplication();
            mockLevelController.Verify(levelcontroller => levelcontroller.Play(), Times.AtLeastOnce());
        }

        [Fact]
        public void RunApplication_CaseOneShouldCallStartGameWithAlphabetImplementedAsArgument()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();
            var mockLevelController = new Mock<LevelController>();

            var mainController = new MainController(mockReflexGame.Object, mockConsoleView.Object, mockLevelController.Object);
            mockConsoleView.SetupSequence(view => view.GetAction()).Returns(1).Returns(4);

            mainController.RunApplication();
            mockReflexGame.Verify(game => game.StartGame(It.IsAny<AlphabetImplemented>()), Times.Once());
        }

        [Fact]
        public void RunApplication_CaseOneShouldCallDisplayEasyLevel()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();
            var mockLevelController = new Mock<LevelController>();

            var mainController = new MainController(mockReflexGame.Object, mockConsoleView.Object, mockLevelController.Object);
            mockConsoleView.SetupSequence(view => view.GetAction()).Returns(1).Returns(4);

            mainController.RunApplication();
            mockConsoleView.Verify(view => view.DisplayEasyLevel(), Times.Once());
        }

        [Fact]
        public void RunApplication_CaseOneShouldCallEasy()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();
            var mockLevelController = new Mock<LevelController>();

            var mainController = new MainController(mockReflexGame.Object, mockConsoleView.Object, mockLevelController.Object);
            mockConsoleView.SetupSequence(view => view.GetAction()).Returns(1).Returns(4);

            mainController.RunApplication();
            mockLevelController.Verify(levelController => levelController.Easy(), Times.Once());
        }

        [Fact]
        public void RunApplication_CaseTwoShouldCallStartGameWithAlphabetImplementedAsArgument()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();
            var mockLevelController = new Mock<LevelController>();

            var mainController = new MainController(mockReflexGame.Object, mockConsoleView.Object, mockLevelController.Object);
            mockConsoleView.SetupSequence(view => view.GetAction()).Returns(2).Returns(4);

            mainController.RunApplication();
            mockReflexGame.Verify(game => game.StartGame(It.IsAny<AlphabetImplemented>()), Times.Once());
        }

        [Fact]
        public void RunApplication_CaseTwoShouldCallPlay()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();
            var mockLevelController = new Mock<LevelController>();

            var mainController = new MainController(mockReflexGame.Object, mockConsoleView.Object, mockLevelController.Object);
            mockLevelController.SetupSequence(levelController => levelController.Play()).Returns(true).Returns(false);
            mockConsoleView.SetupSequence(view => view.GetAction()).Returns(2).Returns(4);

            mainController.RunApplication();
            mockLevelController.Verify(levelcontroller => levelcontroller.Play(), Times.AtLeastOnce());
        }

        [Fact]
        public void RunApplication_CaseThreeShouldCallPlay()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();
            var mockLevelController = new Mock<LevelController>();

            var mainController = new MainController(mockReflexGame.Object, mockConsoleView.Object, mockLevelController.Object);
            mockLevelController.SetupSequence(levelController => levelController.Play()).Returns(true).Returns(false);
            mockConsoleView.SetupSequence(view => view.GetAction()).Returns(3).Returns(4);

            mainController.RunApplication();
            mockLevelController.Verify(levelcontroller => levelcontroller.Play(), Times.AtLeastOnce());
        }

        [Fact]
        public void RunApplication_CaseTwoShouldCallDisplayMediumLevel()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();
            var mockLevelController = new Mock<LevelController>();

            var mainController = new MainController(mockReflexGame.Object, mockConsoleView.Object, mockLevelController.Object);
            mockConsoleView.SetupSequence(view => view.GetAction()).Returns(2).Returns(4);

            mainController.RunApplication();
            mockConsoleView.Verify(view => view.DisplayMediumLevel(), Times.Once());
        }

        [Fact]
        public void RunApplication_CaseTwoShouldCallMedium()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();
            var mockLevelController = new Mock<LevelController>();

            var mainController = new MainController(mockReflexGame.Object, mockConsoleView.Object, mockLevelController.Object);
            mockConsoleView.SetupSequence(view => view.GetAction()).Returns(2).Returns(4);

            mainController.RunApplication();
            mockLevelController.Verify(levelController => levelController.Medium(), Times.Once());
        }

        [Fact]
        public void RunApplication_CaseThreeShouldCallStartGameWithAlphabetImplementedAsArgument()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();
            var mockLevelController = new Mock<LevelController>();

            var mainController = new MainController(mockReflexGame.Object, mockConsoleView.Object, mockLevelController.Object);
            mockConsoleView.SetupSequence(view => view.GetAction()).Returns(3).Returns(4);

            mainController.RunApplication();
            mockReflexGame.Verify(game => game.StartGame(It.IsAny<AlphabetImplemented>()), Times.Once());
        }

        [Fact]
        public void RunApplication_CaseThreeShouldCallDisplayHardLevel()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();
            var mockLevelController = new Mock<LevelController>();

            var mainController = new MainController(mockReflexGame.Object, mockConsoleView.Object, mockLevelController.Object);
            mockConsoleView.SetupSequence(view => view.GetAction()).Returns(3).Returns(4);

            mainController.RunApplication();
            mockConsoleView.Verify(view => view.DisplayHardLevel(), Times.Once());
        }

        [Fact]
        public void RunApplication_CaseThreeShouldCallHard()
        {
            var mockReflexGame = new Mock<ReflexGame>();
            var mockConsoleView = new Mock<ConsoleView>();
            var mockLevelController = new Mock<LevelController>();

            var mainController = new MainController(mockReflexGame.Object, mockConsoleView.Object, mockLevelController.Object);
            mockConsoleView.SetupSequence(view => view.GetAction()).Returns(3).Returns(4);

            mainController.RunApplication();
            mockLevelController.Verify(levelController => levelController.Hard(), Times.Once());
        }

    }
}
