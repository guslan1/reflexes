using System;
using System.IO;
using Xunit;
using reflexes.View;

namespace reflexesTest
{
    public class ConsoleViewTest
    {
        [Fact]
        public void ConsoleView_NewConsoleViewShouldReturnConsoleView()
        {
            var view = new ConsoleViewImplemented();
            Assert.IsType<ConsoleViewImplemented>(view);
        }

        [Fact]
        public void DisplayGreetingMessage_ShouldDisplayGreetingMessage()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var sut = new ConsoleViewImplemented();
                sut.DisplayGreetingMessage();

                string expected = sut._greetingMessage + "\r\n\r\n" + "" + sut._greetingInstructionsMessage + "\r\n\r\n";
                Assert.Equal(expected, sw.ToString());
                sw.Close();
            }
        }

        [Fact]
        public void DisplayMenuChoices_ShouldDisplayMenuChoices()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var sut = new ConsoleViewImplemented();
                string expected = "";

                foreach (string choice in sut._menuChoices)
                {
                    expected += choice;
                    expected += "\r\n";
                }
                sut.DisplayMenuChoices();

                Assert.Equal(expected, sw.ToString());
                sw.Close();
            }
        }

        [Fact]
        public void GetAction_ShouldReturnOne()
        {
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
            string choice = "1";
            var input = new StringReader(choice);
            Console.SetIn(input);

            using (StringWriter sw = new StringWriter())
            {
                var sut = new ConsoleViewImplemented();
                var actual = sut.GetAction();

                int expected = 1;

                Assert.Equal(expected, actual);
                input.Close();
            }
        }

        [Fact]
        public void GetAction_ShouldReturnZeroWithStringAsInput()
        {
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
            string choice = "a";
            var input = new StringReader(choice);
            Console.SetIn(input);

            using (StringWriter sw = new StringWriter())
            {
                var sut = new ConsoleViewImplemented();
                var actual = sut.GetAction();

                int expected = 0;

                Assert.Equal(expected, actual);
                input.Close();
            }
        }

        [Fact]
        public void DisplayLevelSelection_ShouldDisplayLevelSelection()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var sut = new ConsoleViewImplemented();
                string expected = sut._selectLevelMessage;

                sut.DisplayLevelSelection();

                Assert.Equal(expected, sw.ToString());
                sw.Close();
            }
        }

        [Fact]
        public void DisplayEasyLevel_ShouldDisplayEasyLevel()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var sut = new ConsoleViewImplemented();
                sut.DisplayEasyLevel();


                string expected = sut._easyLevelMessage + "\r\n\r\n";
                Assert.Equal(expected, sw.ToString());
                sw.Close();
            }
        }

        [Fact]
        public void DisplayEasyLevel_ShouldDisplayMediumLevel()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var sut = new ConsoleViewImplemented();
                sut.DisplayMediumLevel();

                string expected = sut._mediumLevelMessage + "\r\n\r\n";
                Assert.Equal(expected, sw.ToString());
                sw.Close();
            }
        }

        [Fact]
        public void DisplayEasyLevel_ShouldDisplayHardLevel()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var sut = new ConsoleViewImplemented();
                sut.DisplayHardLevel();

                string expected = sut._hardLevelMessage + "\r\n\r\n";
                Assert.Equal(expected, sw.ToString());
                sw.Close();
            }
        }

        [Fact]
        public void DisplayLevelSelectionClarification_ShouldClarify()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var sut = new ConsoleViewImplemented();
                string expected = sut._selectLevelClarificationMessage + "\r\n";

                sut.DisplayLevelSelectionClarification();

                Assert.Equal(expected, sw.ToString());
                sw.Close();
            }
        }

        [Fact]
        public void GameOver_ShouldDisplay25WordsLeft()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                var input = new StringReader("test");
                Console.SetIn(input);

                var sut = new ConsoleViewImplemented();
                int wordsLeft = 25;
                sut.GameOver(wordsLeft);

                string expected = sut._gameOverFirstMessage + "25" + sut._gameOverSecondMessage + "\r\n";
                Assert.Equal(expected, sw.ToString());
                sw.Close();
                input.Close();
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
            }
        }

        [Fact]
        public void GameCompleted_ShouldDisplayGameCompleted()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                var input = new StringReader("test");
                Console.SetIn(input);

                var sut = new ConsoleViewImplemented();
                sut.GameCompleted();

                string expected = sut._gameCompletedMessage + "\r\n\r\n";
                Assert.Equal(expected, sw.ToString());
                sw.Close();
                input.Close();
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
            }
        }

        [Fact]
        public void DisplayPressAKeyToContinue_ShouldDisplayPressAKeyToContinue()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                var input = new StringReader("test");
                Console.SetIn(input);

                var sut = new ConsoleViewImplemented();
                sut.DisplayPressAKeyToContinue();

                string expected = sut._pressKeyToContinueMessage;
                Assert.Equal(expected, sw.ToString());
                sw.Close();
                input.Close();
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
            }
        }

        [Fact]
        public void ReadKey_ShouldReturnStringInput()
        {
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
            string action = "1";
            var input = new StringReader(action);
            Console.SetIn(input);

            using (StringWriter sw = new StringWriter())
            {
                var sut = new ConsoleViewImplemented();
                var actual = sut.ReadKey();

                string expected = "1";

                Assert.Equal(expected, actual);
                input.Close();
            }
        }

        [Fact]
        public void GetInput_ShouldReturnStringInput()
        {
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
            string action = "a";
            var input = new StringReader(action);
            Console.SetIn(input);

            using (StringWriter sw = new StringWriter())
            {
                var sut = new ConsoleViewImplemented();
                var actual = sut.GetInput();

                string expected = "a";

                Assert.Equal(expected, actual);
                input.Close();
            }
        }

        [Fact]
        public void TooLongTime_ShouldDisplayTooLongTime()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                var input = new StringReader("test");
                Console.SetIn(input);

                var sut = new ConsoleViewImplemented();
                sut.TooLongTime();

                string expected = sut._tooLongTimeMessage + "\r\n\r\n";
                Assert.Equal(expected, sw.ToString());
                sw.Close();
                input.Close();
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
            }
        }

        [Fact]
        public void PresentLetter_ShouldPresentLetter()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                var input = new StringReader("test");
                Console.SetIn(input);

                var sut = new ConsoleViewImplemented();
                string testLetter = "a";
                sut.PresentLetter(testLetter);

                string expected = sut._presentLetterInfoMessage + testLetter + "\r\n\r\n";
                Assert.Equal(expected, sw.ToString());
                sw.Close();
                input.Close();
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
            }
        }
    }
}
