using System;

namespace reflexes.View
{
    public class ConsoleView
    {
        public string _greeting = "Welcome to Reflexes!";

        public void DisplayGreetingMessage()
        {
            Console.WriteLine(_greeting);
        }

    }
}
