using System;
using System.Collections.Generic;
using System.Text;

namespace reflexes.Model
{
    public interface ReflexGame
    {
        void StartGame(Alphabet alphabet);

        int WordsLeft();

        bool IsGameCompleted();

        string GetNewLetter();

        bool IsCorrectInput(string character);

        void RemoveLetterFromAlphabet();

        void CreateStopwatch();

        void StartStopwatch();

        void StopStopwatch();

        TimeSpan TimeElapsed { get; }

    }
}
