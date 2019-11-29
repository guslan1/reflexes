using System;
using System.Collections.Generic;
using System.Text;

namespace reflexes.View
{
    public interface ConsoleView
    {
        void DisplayGreetingMessage();

        void DisplayMenuChoices();

        int GetAction();

        void DisplayLevelSelection();

        void DisplayEasyLevel();

        void DisplayMediumLevel();

        void DisplayHardLevel();

        void DisplayLevelSelectionClarification();

        void GameOver(int wordsLeft);

        void GameCompleted();

        void DisplayPressAKeyToContinue();

        string ReadKey();

        void PresentLetter(string letter);

        string GetInput();

        void TooLongTime();
    }
}
