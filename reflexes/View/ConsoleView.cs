using System;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("reflexesTest")]

namespace reflexes.View
{
    public class ConsoleView
    {
        internal string _greeting = "Welcome to Reflexes!";
        internal string _greetingInstructions = "Pick a level to start training your reflexes.";
        internal string _easyLevelMessage = "Easy level starting in";
        internal string _gameCompleted = "You win! Game completed.";

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

        //public void GameCompleted()
        //{
        //    Console.WriteLine(_gameCompleted);
        //    Console.WriteLine("");
        //}

        //public bool GameReadkey()
        //{
        //    bool keyPressed = false;
        //    if ()
        //    Console.ReadKey(true);
        //}


    }
}
