using System;
using System.Diagnostics;

namespace reflexes.Model
{
    public class ReflexGameImplemented : ReflexGame
    {
        private Alphabet _alphabet;
        private Stopwatch _stopwatch;
        private TimeSpan _maxTime = new TimeSpan(0, 0, 3);
        private string _currentChar;

        public TimeSpan EasyMode => new TimeSpan(0, 0, 3);

        public TimeSpan MediumMode => new TimeSpan(0, 0, 2);

        public TimeSpan HardMode => new TimeSpan(0, 0, 1);

        public void StartGame(Alphabet alphabet) => _alphabet = alphabet;

        private bool IsValidGame(Alphabet game) => (game != null);

        public bool IsGameCompleted() => _alphabet.IsAlphabetEmpty();

        public string GetNewLetter()
        {
            _currentChar = _alphabet.GetLetter();
            return _currentChar;
        }

        public void CreateStopwatch() => _stopwatch = new Stopwatch();

        public void StartStopwatch() => _stopwatch.Start();

        public void StopStopwatch() => _stopwatch.Stop();

        public bool IsInTime() => TimeElapsed < MaxTime;

        public TimeSpan TimeElapsed { get { return _stopwatch.Elapsed; } }

        public TimeSpan MaxTime { get { return _maxTime; } set { _maxTime = value; } }

        public int WordsLeft() => _alphabet.WordsLeft();

        public bool IsCorrectInput(string character) => ValidateCharacter(character);

        private bool ValidateCharacter(string character) => character == _currentChar;

        public void RemoveLetterFromAlphabet() => _alphabet.RemoveLetter();


    }
}
