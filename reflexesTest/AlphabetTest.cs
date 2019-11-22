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

        [Fact]
        public void RemoveLetter_ShouldRemoveOneLetter()
        {
            Alphabet sut = new Alphabet();
            int expected = 24;
            sut.RemoveLetter();
            int actual = sut.WordsLeft();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetLetter_ReturnsFirstCharacterInRandomAlphabet()
        {
            Alphabet sut = new Alphabet();
            IReadOnlyList<string> randomAlphabet = sut.GetAlphabet;
            string expected = randomAlphabet[0];
            string actual = sut.GetLetter();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveLetter_RemovesFirstCharacterInRandomAlphabet()
        {
            Alphabet sut = new Alphabet();

            string firstLetter = sut.GetLetter();
            sut.RemoveLetter();
            IReadOnlyList<string> currentAlphabet = sut.GetAlphabet;

            bool actual = false;

            foreach (string character in currentAlphabet)
            { 
                if (character == firstLetter)
                {
                    actual = true;
                }
            }
   
            Assert.False(actual);
        }



    }
}