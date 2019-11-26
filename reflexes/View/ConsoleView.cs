using System;
using System.Collections.Generic;
using System.Text;

namespace reflexes.View
{
    public interface ConsoleView
    {
        void DisplayGreetingMessage();

        void DisplayEasyLevel();

        void DisplayMenuChoices();

        void DisplayLevelSelectionClarification();

        void DisplayLevelSelection();

        int GetAction();

        void GameOver(int wordsLeft);

        void GameCompleted();

        void TooLongTime();

        void PresentLetter(string letter);


    }
}
