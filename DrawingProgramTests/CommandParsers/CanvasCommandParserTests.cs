using DrawingProgram.Domains;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DrawingProgram.CommandParsers.Tests
{
    [TestClass()]
    public class CanvasCommandParserTests
    {
        [TestMethod()]
        [DataRow("C 20 10", 'C', 20, 10)]
        public void CanvasCommandParserTest(string commandText, char commandName, int x, int y)
        {
            CanvasCommandParser parser = new CanvasCommandParser(commandText);
            CanvasCommand command = (CanvasCommand)parser.ParseCommand();

            Assert.AreEqual(command.CommandName, commandName, "Command Name not parsed correctly.");
            Assert.AreEqual(command.Width, x, "Height of canvas not parsed properly.");
            Assert.AreEqual(command.Height, y, "Width of canvas not parsed properly..");
        }
    }
}