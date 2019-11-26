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

        //[Fact]
        //public void GetNextAction_ShouldReturnTrue()
        //{
        //    using (StringWriter sw = new StringWriter())
        //    {
        //        Console.SetOut(sw);
        //        var input = new StringReader("1");
        //        Console.SetIn(input);

        //        var v = new ConsoleViewImplemented();
        //        string firstAction = "";

        //        foreach (string choice in v._nextActionArray)
        //        {
        //            firstAction += choice;
        //            firstAction += "\r\n";
        //        }

        //        v.GetNextAction();

        //        string expected = v._greeting + "\r\n\r\n" + v._greetingInstructions + "\r\n\r\n" + firstAction;
        //        Assert.Equal(expected, sw.ToString());
        //        sw.Close();
        //        input.Close();
        //        Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
        //    }
        //}


    }
}
