using DrawingProgram.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DrawingProgram.CommandParsers.Tests
{
    [TestClass()]


    public class CommandParserFactoryTests
    {
        [TestMethod()]
        [DataRow("C 20 10", "CanvasCommandParser")]
        [DataRow("B 5 10 c", "BackColorCommandParser")]
        [DataRow("L 5 5 5 10", "LineCommandParser")]
        [DataRow("R 5 5 10 10", "ReactangleCommandParser")]
        public void GetCommandParserTest(string commandText, string parserName)
        {
            ICommandParser parser = CommandParserFactory.GetCommandParser(commandText);
            var expectedParserName = parser.GetType();
            Assert.AreEqual(expectedParserName.Name, parserName, "Not able to get the correct parser for the command.");
        }
    }
}