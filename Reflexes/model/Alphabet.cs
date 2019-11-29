using System.Collections.Generic;

namespace reflexes.Model
{
    public interface Alphabet
    {
        int WordsLeft();

        bool IsAlphabetEmpty();

        void RemoveLetter();

        IReadOnlyList<string> GetAlphabet { get; }

        void ClearAlphabet();

        string GetLetter();
    }
}
