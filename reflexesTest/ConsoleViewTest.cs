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

                var sut = new ConsoleView();
                sut.DisplayGreetingMessage();

                string expected = sut._greeting + "\r\n";
                Assert.Equal(expected, sw.ToString());
                sw.Close();
            }
        }






    }
}
