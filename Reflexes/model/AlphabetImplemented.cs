using System;
using System.Collections.Generic;

namespace reflexes.Model
{
    public class AlphabetImplemented : Alphabet
    {
        private string[] _alphabetArray = new string[25] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "x", "y", "z" };
        private List<string> _randomAlphabet;

        public AlphabetImplemented()
        {
            _randomAlphabet = RandomAlphabet(AlphabetList());
        }

        private List<string> RandomAlphabet(List<string> alphabetList)
        {
            List<string> randomAlphabetList = new List<string>();
            Random r = new Random();
            int randomIndex = 0;

            while (alphabetList.Count > 0)
            {
                randomIndex = r.Next(0, alphabetList.Count);
                randomAlphabetList.Add(alphabetList[randomIndex]);
                alphabetList.RemoveAt(randomIndex);
            }
            return randomAlphabetList;
        }

        private List<string> AlphabetList()
        {
            List<string> alphabetList = new List<string>(25);
            foreach (string character in _alphabetArray)
            {
                alphabetList.Add(character);
            }
            return alphabetList;
        }

        public IReadOnlyList<string> GetAlphabet => _randomAlphabet.AsReadOnly();

        public bool IsAlphabetEmpty() => GetAlphabet.Count == 0;

        public string GetLetter() => _randomAlphabet[0];

        public int WordsLeft() => _randomAlphabet.Count;

        public void RemoveLetter() => _randomAlphabet.RemoveAt(0);

        public void ClearAlphabetForTestOnly() => _randomAlphabet.Clear();
    }
}
