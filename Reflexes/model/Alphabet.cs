using System.Collections.Generic;

namespace reflexes.Model
{
    public interface Alphabet
    {

        IReadOnlyList<string> GetAlphabet { get; }

        bool IsAlphabetEmpty();

        string GetLetter();

        int WordsLeft();

        void RemoveLetter();

        void ClearAlphabetForTestOnly();
    }
}
