using System.Linq;
using System.Collections.Generic;
using Xunit;
using reflexes.Model;

namespace reflexesTest
{
    public class AlphabetTest
    {
        [Fact]
        public void Alphabet_NewAlphabetShouldReturnAlphabet()
        {
            var alphabet = new AlphabetImplemented();
            Assert.IsType<AlphabetImplemented>(alphabet);
        }

        [Fact]
        public void GetAlphabet_ShouldReturnCompleteAlphabet()
        {
            AlphabetImplemented sut = new AlphabetImplemented();

            var sutAlphabet = sut.GetAlphabet;

            List<string> sutAlphabetList = new List<string>();

            foreach (string character in sutAlphabet)
            {
                sutAlphabetList.Add(character);
            }

            string[] expected = new string[25] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "x", "y", "z" };
            bool actual = true;
            
            foreach (string character in expected)
            {
                if (!expected.Contains(character))
                {
                    actual = false;
                }
            }

            Assert.True(actual);
        }

        [Fact]
        public void IsAlphabetEmpty_ShouldReturnTrue()
        {
            AlphabetImplemented sut = new AlphabetImplemented();
            sut.ClearAlphabetForTestOnly();
            bool expected = true;
            var actual = sut.IsAlphabetEmpty();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsAlphabetEmpty_ShouldReturnFalse()
        {
            AlphabetImplemented sut = new AlphabetImplemented();
            bool expected = false;
            var actual = sut.IsAlphabetEmpty();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetLetter_ReturnsFirstCharacterInRandomAlphabet()
        {
            AlphabetImplemented sut = new AlphabetImplemented();
            IReadOnlyList<string> randomAlphabet = sut.GetAlphabet;
            string expected = randomAlphabet[0];
            var actual = sut.GetLetter();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WordsLeft_ShouldReturnNumbersOfLettersInAlphabet()
        {
            AlphabetImplemented sut = new AlphabetImplemented();
            int expected = 25;
            var actual = sut.WordsLeft();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveLetter_RemovesLetterFromRandomAlphabet()
        {
            AlphabetImplemented sut = new AlphabetImplemented();

            string firstLetter = sut.GetLetter();
            sut.RemoveLetter();
            var currentAlphabet = sut.GetAlphabet;

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

        [Fact]
        public void RemoveLetter_ShouldRemoveOneLetter()
        {
            AlphabetImplemented sut = new AlphabetImplemented();
            int expected = 24;
            sut.RemoveLetter();
            var actual = sut.WordsLeft();
            Assert.Equal(expected, actual);
        }
    }
}