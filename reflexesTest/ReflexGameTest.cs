using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using reflexes.Model;

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
            mockAlphabet.Setup(foo => foo.WordsLeft()).Returns(() => count);
            sut.StartGame(mockAlphabet.Object);

            int expected = 25;
            int actual = sut.WordsLeft();
            Assert.Equal(expected, actual);
        }

    }
}
