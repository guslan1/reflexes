using System;

namespace reflexes.Model
{
    public interface ReflexGame
    {
        TimeSpan EasyMode { get; }

        TimeSpan MediumMode { get; }

        TimeSpan HardMode { get; }

        void StartGame(Alphabet alphabet);

        bool IsGameCompleted();

        string GetNewLetter();

        void CreateStopwatch();

        void StartStopwatch();

        void StopStopwatch();

        bool IsInTime();

        TimeSpan TimeElapsed { get; }

        TimeSpan MaxTime { get; set; }

        int WordsLeft();

        bool IsCorrectInput(string character);

        void RemoveLetterFromAlphabet();
    }
}
