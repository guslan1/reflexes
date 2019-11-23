using System;
using System.Collections.Generic;
using System.Text;

namespace reflexes.Model
{
    public class ReflexGameImplemented : ReflexGame
    {
        private Alphabet _alphabet;

        private string _currentChar;

        public void StartGame(Alphabet alphabet) => _alphabet = alphabet;

        public int WordsLeft() => _alphabet.WordsLeft();

        public bool IsGameCompleted() => _alphabet.IsAlphabetEmpty();

        public string GetNewLetter()
        {
            _currentChar = _alphabet.GetLetter();
            return _currentChar;
        }

        public bool IsCorrectInput(string character)
        {
            return ValidateCharacter(character);
        }

        private bool ValidateCharacter(string character)
        {
            if (character == _currentChar)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
