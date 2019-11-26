using System;
using System.IO;
using Xunit;
using reflexes.View;

namespace reflexesTest
{
    public class ConsoleViewTest
    {
        [Fact]
        public void DisplayGreetingsMessage_ShouldDisplayGreetingMessage()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var sut = new ConsoleViewImplemented();
                sut.DisplayGreetingMessage();

                string expected = sut._greeting + "\r\n\r\n" + "" + sut._greetingInstructions + "\r\n\r\n";
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
        public void DisplayMenuChoices_ShouldDisplayMenuChoices()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var sut = new ConsoleViewImplemented();
                string expected = "";

                foreach (string choice in sut._nextActionArray)
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
        public void GetAction_ShouldReturnOne()
        {
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
            string choice = "1";
            var input = new StringReader(choice);
            Console.SetIn(input);

            using (StringWriter sw = new StringWriter())
            {
                var sut = new ConsoleViewImplemented();
                int result = sut.GetAction();

                int expected = 1;

                Assert.Equal(expected, result);
                input.Close();
            }
        }

        [Fact]
        public void GetAction_ShouldReturnZero()
        {
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
            string choice = "a";
            var input = new StringReader(choice);
            Console.SetIn(input);

            using (StringWriter sw = new StringWriter())
            {
                var sut = new ConsoleViewImplemented();
                int result = sut.GetAction();

                int expected = 0;

                Assert.Equal(expected, result);
                input.Close();
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

                string expected = sut._gameOver1 + "25" + sut._gameOver2 + "\r\n";
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

                string expected = sut._gameCompleted + "\r\n\r\n";
                Assert.Equal(expected, sw.ToString());
                sw.Close();
                input.Close();
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
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

                string expected = sut._tooLongTime + "\r\n\r\n";
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

                string expected = sut._presentLetterInfo + testLetter + "\r\n\r\n";
                Assert.Equal(expected, sw.ToString());
                sw.Close();
                input.Close();
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
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
                string result = sut.GetInput();

                string expected = "a";

                Assert.Equal(expected, result);
                input.Close();
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

                string expected = sut._pressKeyToContinue;
                Assert.Equal(expected, sw.ToString());
                sw.Close();
                input.Close();
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
            }
        }

    }
}
