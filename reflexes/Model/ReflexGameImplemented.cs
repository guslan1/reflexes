using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace reflexes.Model
{
    public class ReflexGameImplemented : ReflexGame
    {
        private Alphabet _alphabet;

        private Stopwatch _stopwatch;

        private TimeSpan _maxTime = new TimeSpan(0, 0, 3);

        private string _currentChar;

        internal string _failedToCreateStopwatch = "Unable to create an object of referencetype Stopwatch";

        public void StartGame(Alphabet alphabet) => _alphabet = alphabet;

        public TimeSpan MaxTime { get { return _maxTime; } }

        public int WordsLeft() => _alphabet.WordsLeft();

        public bool IsGameCompleted() => _alphabet.IsAlphabetEmpty();

        public string GetNewLetter()
        {
            _currentChar = _alphabet.GetLetter();
            return _currentChar;
        }

        public bool IsCorrectInput(string character) => ValidateCharacter(character);

        private bool ValidateCharacter(string character) => character == _currentChar;

        public void RemoveLetterFromAlphabet() => _alphabet.RemoveLetter();

        public void CreateStopwatch() => _stopwatch = new Stopwatch();

        public void StartStopwatch() => _stopwatch.Start();

        public void StopStopwatch() => _stopwatch.Stop();

        public TimeSpan TimeElapsed { get { return _stopwatch.Elapsed; } }




    }
}
