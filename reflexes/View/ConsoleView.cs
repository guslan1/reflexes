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


    }
}
