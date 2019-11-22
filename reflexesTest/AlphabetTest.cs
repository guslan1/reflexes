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
        public void WordsLeft_ShouldReturnAllLettersInAlphabet()
        {
            Alphabet sut = new Alphabet();
            int expected = 25;
            int actual = sut.WordsLeft();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsAlphabetEmpty_ShouldReturnTrue()
        {
            Alphabet sut = new Alphabet();
            sut.ClearAlphabet();
            bool expected = true;
            bool actual = sut.IsAlphabetEmpty();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsAlphabetEmpty_ShouldReturnFalse()
        {
            Alphabet sut = new Alphabet();
            bool expected = false;
            bool actual = sut.IsAlphabetEmpty();
            Assert.Equal(expected, actual);
        }





    }
}