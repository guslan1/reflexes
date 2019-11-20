using System;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("reflexesTest")]

namespace reflexes.View
{
    public class ConsoleView
    {
        internal string _greeting = "Welcome to Reflexes!";

        public void DisplayGreetingMessage()
        {
            Console.WriteLine(_greeting);
        }

    }
}
