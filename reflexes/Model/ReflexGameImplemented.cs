using System;
using System.Collections.Generic;
using System.Text;

namespace reflexes.Model
{
    public class ReflexGameImplemented : ReflexGame
    {
        private Alphabet _alphabet;

        public void StartGame(Alphabet alphabet) => _alphabet = alphabet;

        public int WordsLeft() => _alphabet.WordsLeft();



    }
}
