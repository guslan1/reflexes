using System;
using System.Runtime.CompilerServices;
using System.Threading;
[assembly: InternalsVisibleTo("reflexesTest")]

namespace reflexes.View
{
    public class ConsoleViewImplemented : ConsoleView
    {
        internal string _greeting = "Welcome to Reflexes!";
        internal string _greetingInstructions = "Pick a level to start training your reflexes.";
        internal string _selectLevelMessage = "Select a level to start playing : ";
        internal string _selectLevelClarificationMessage = "\n MAKE A SELECTION! 0 to 4.\n";
        internal string _easyLevelMessage = "Easy level starting in";
        internal string _gameCompleted = "You win! Game completed.";
        internal string _gameOver1 = "You lost with ";
        internal string _gameOver2 = " characters remaining.";
        internal string _presentLetterInfo = "Type the letter: ";
        internal string _tooLongTime = "You answered too late.";
        internal string[] _nextActionArray = new string[] { "1. Easy", "2. Medium", "3. Hard", "4. Exit" };
        internal string _pressKeyToContinue = "\n   Press a key to continue   ";

        public void DisplayGreetingMessage()
        {
            Console.WriteLine(_greeting);
            Console.WriteLine("");
            Console.WriteLine(_greetingInstructions);
            Console.WriteLine("");
        }

        public void DisplayEasyLevel()
        {
            Console.WriteLine(_easyLevelMessage);
            Console.WriteLine("");
        }

        public void DisplayMenuChoices()
        {
            foreach (string option in _nextActionArray)
            {
                Console.WriteLine(option);
            }
        }

        public void DisplayLevelSelectionClarification()
        {
            Console.WriteLine(_selectLevelClarificationMessage);
        }

        public void DisplayLevelSelection()
        {
            Console.Write(_selectLevelMessage);
        }


        public int GetAction()
        {
            int input;
            int.TryParse(Console.ReadLine(), out input);
            return input;
        }

        public void GameOver(int wordsLeft)
        {
            Console.Write(_gameOver1);
            Console.Write(wordsLeft);
            Console.WriteLine(_gameOver2);
        }

        public void GameCompleted()
        {
            Console.WriteLine(_gameCompleted);
            Console.WriteLine("");
        }

        public void TooLongTime()
        {
            Console.WriteLine(_tooLongTime);
            Console.WriteLine("");
        }


        public void PresentLetter(string letter)
        {
            Console.Write(_presentLetterInfo);
            Console.Write(letter);
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public string GetInput() => Console.ReadLine();

        public void DisplayPressAKeyToContinue() => Console.Write(_pressKeyToContinue);

   
    }
}
