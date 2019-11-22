using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using reflexes.Model;

namespace reflexesTest
{
    public class AlphabetTest
    {
        [Fact]
        public void WordsLeft_ShouldReturnNumberOfWordsInAlphabet()
        {
            Alphabet sut = new Alphabet();
            int expected = 25;
            int actual = sut.WordsLeft();
            Assert.Equal(expected, actual);
        }
    }
}