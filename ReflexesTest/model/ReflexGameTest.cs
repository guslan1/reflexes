using System;
using Xunit;
using Moq;
using reflexes.Model;
using System.Threading;

namespace reflexesTest
{
    public class ReflexGameTest
    {

        [Fact]
        public void WordsLeft_ShouldReturnAllLettersInAlphabet()
        {
            var sut = new ReflexGameImplemented();
            var mockAlphabet = new Mock<Alphabet>();

            int count = 25;
            mockAlphabet.Setup(alphabet => alphabet.WordsLeft()).Returns(() => count);
            sut.StartGame(mockAlphabet.Object);

            int expected = 25;
            int actual = sut.WordsLeft();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsGameCompleted_GameShouldBeCompleted()
        {
            var sut = new ReflexGameImplemented();
            var mockAlphabet = new Mock<Alphabet>();

            mockAlphabet.Setup(alphabet => alphabet.IsAlphabetEmpty()).Returns(() => true);
            sut.StartGame(mockAlphabet.Object);

            bool actual = sut.IsGameCompleted();
            Assert.True(actual);
        }

        [Fact]
        public void IsGameCompleted_GameShouldNotBeCompleted()
        {
            var sut = new ReflexGameImplemented();
            var mockAlphabet = new Mock<Alphabet>();

            mockAlphabet.Setup(alphabet => alphabet.IsAlphabetEmpty()).Returns(() => false);
            sut.StartGame(mockAlphabet.Object);

            bool actual = sut.IsGameCompleted();
            Assert.False(actual);
        }

        [Fact]
        public void GetNewLetter_ReturnsCorrectLetterFromAlphabet()
        {
            var sut = new ReflexGameImplemented();
            var mockAlphabet = new Mock<Alphabet>();

            string letter = "a";
            mockAlphabet.Setup(alphabet => alphabet.GetLetter()).Returns(() => letter);
            sut.StartGame(mockAlphabet.Object);

            string expected = "a";
            string actual = sut.GetNewLetter();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsCorrectInput_ReturnsTrueIfCorrectLetter()
        {
            var sut = new ReflexGameImplemented();
            var mockAlphabet = new Mock<Alphabet>();

            string letter = "a";
            mockAlphabet.Setup(alphabet => alphabet.GetLetter()).Returns(() => letter);

            sut.StartGame(mockAlphabet.Object);
            sut.GetNewLetter();

            bool actual = sut.IsCorrectInput(letter);

            Assert.True(actual);
        }

        [Fact]
        public void IsCorrectInput_ReturnsFalseIfWrongLetter()
        {
            var sut = new ReflexGameImplemented();
            var mockAlphabet = new Mock<Alphabet>();

            string letter = "a";
            mockAlphabet.Setup(alphabet => alphabet.GetLetter()).Returns(() => letter);

            sut.StartGame(mockAlphabet.Object);
            sut.GetNewLetter();

            bool actual = sut.IsCorrectInput("b");

            Assert.False(actual);
        }

        [Fact]
        public void RemoveLetterFromAlphabet_SuccessfullyCallsMethodOnce()
        {
            var sut = new ReflexGameImplemented();
            var mockAlphabet = new Mock<Alphabet>();
            
            sut.StartGame(mockAlphabet.Object);
            sut.RemoveLetterFromAlphabet();

            mockAlphabet.Verify(alphabet => alphabet.RemoveLetter(), Times.Once());
        }

        [Fact]
        public void CreateStopwatch_SuccessfullyCreatesStopwatch()
        {
            var sut = new ReflexGameImplemented();

            sut.CreateStopwatch();

            TimeSpan expected = new TimeSpan(0, 0, 0);
            TimeSpan actual = sut.TimeElapsed;

            Assert.Equal<TimeSpan>(expected, actual);
        }

        [Fact]
        public void StartStopwatch_SuccesfullyStartsStopwatch()
        {
            var sut = new ReflexGameImplemented();

            sut.CreateStopwatch();
            sut.StartStopwatch();

            TimeSpan expected = new TimeSpan(0, 0, 0);
            TimeSpan actual = sut.TimeElapsed;

            Assert.NotEqual<TimeSpan>(expected, actual);
        }

        [Fact]
        public void StopStopwatch_StoppingStopwatchWorks()
        {
            var sut = new ReflexGameImplemented();

            sut.CreateStopwatch();
            sut.StartStopwatch();

            TimeSpan startTime = new TimeSpan(0, 0, 0);
            
            sut.StopStopwatch();

            TimeSpan expected = sut.TimeElapsed;
            TimeSpan actual = sut.TimeElapsed;

            Assert.Equal<TimeSpan>(expected, actual);
        }

        [Fact]
        public void IsInTime_ShouldReturnTrue()
        {
            var sut = new ReflexGameImplemented();

            sut.CreateStopwatch();
            sut.StartStopwatch();
            sut.StopStopwatch();

            Assert.True(sut.IsInTime());
        }

        [Fact]
        public void IsInTime_ShouldReturnFalse()
        {
            var sut = new ReflexGameImplemented();

            sut.CreateStopwatch();
            sut.StartStopwatch();
            Thread.Sleep(3001);
            sut.StopStopwatch();

            Assert.False(sut.IsInTime());
        }

        [Fact]
        public void EasyMode_ShouldGetThreeSecondTimeSpan()
        {
            var sut = new ReflexGameImplemented();

            var actual = sut.EasyMode;
            var expected = new TimeSpan(0, 0, 3);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MediumMode_ShouldGetTwoSecondTimeSpan()
        {
            var sut = new ReflexGameImplemented();

            var actual = sut.MediumMode;
            var expected = new TimeSpan(0, 0, 2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HardMode_ShouldGetOneSecondTimeSpan()
        {
            var sut = new ReflexGameImplemented();

            var actual = sut.HardMode;
            var expected = new TimeSpan(0, 0, 1);

            Assert.Equal(expected, actual);
        }

    }
}
