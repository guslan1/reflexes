using System;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("reflexesTest")]

namespace reflexes.View
{
    public class ConsoleViewImplemented : ConsoleView
    {
        internal string _greetingMessage = "Welcome to Reflexes!";
        internal string _greetingInstructionsMessage = "Time to start training your reflexes.";
        internal string[] _menuChoices = new string[] { "1. Easy", "2. Medium", "3. Hard", "4. Exit" };
        internal string _selectLevelMessage = "Select a level to start playing : ";
        internal string _selectLevelClarificationMessage = "\n MAKE A SELECTION! 0 to 4.\n";
        internal string _easyLevelMessage = "\n PLAYING EASY LEVEL! \n";
        internal string _mediumLevelMessage = "\n PLAYING MEDIUM LEVEL! \n";
        internal string _hardLevelMessage = "\n PLAYING HARD LEVEL! \n";
        internal string _presentLetterInfoMessage = "Type the letter: ";
        internal string _gameCompletedMessage = "You win! Game completed.";
        internal string _gameOverFirstMessage = "You lost with ";
        internal string _gameOverSecondMessage = " characters remaining.";
        internal string _tooLongTimeMessage = "You answered too late.";
        internal string _pressKeyToContinueMessage = "\n   Press a key to continue   ";

        public void DisplayGreetingMessage()
        {
            Console.WriteLine(_greetingMessage);
            Console.WriteLine("");
            Console.WriteLine(_greetingInstructionsMessage);
            Console.WriteLine("");
        }

        public void DisplayMenuChoices()
        {
            foreach (string option in _menuChoices)
            {
                Console.WriteLine(option);
            }
        }

        public int GetAction()
        {
            int.TryParse(Console.ReadLine(), out int input);
            return input;
        }

        public void DisplayLevelSelection() => Console.Write(_selectLevelMessage);

        public void DisplayEasyLevel()
        {
            Console.WriteLine(_easyLevelMessage);
            Console.WriteLine("");
        }

        public void DisplayMediumLevel()
        {
            Console.WriteLine(_mediumLevelMessage);
            Console.WriteLine("");
        }

        public void DisplayHardLevel()
        {
            Console.WriteLine(_hardLevelMessage);
            Console.WriteLine("");
        }

        public void DisplayLevelSelectionClarification() => Console.WriteLine(_selectLevelClarificationMessage);

        public void GameOver(int wordsLeft)
        {
            Console.Write(_gameOverFirstMessage);
            Console.Write(wordsLeft);
            Console.WriteLine(_gameOverSecondMessage);
        }

        public void GameCompleted()
        {
            Console.WriteLine(_gameCompletedMessage);
            Console.WriteLine("");
        }

        public void DisplayPressAKeyToContinue() => Console.Write(_pressKeyToContinueMessage);

        public string ReadKey() => Console.ReadLine();

        public string GetInput() => Console.ReadLine();

        public void TooLongTime()
        {
            Console.WriteLine(_tooLongTimeMessage);
            Console.WriteLine("");
        }

        public void PresentLetter(string letter)
        {
            Console.Write(_presentLetterInfoMessage);
            Console.Write(letter);
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
