using DrawingProgram.Domains;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DrawingProgram.CommandParsers.Tests
{
    [TestClass()]
    public class ReactangleCommandParserTests
    {
        [TestMethod()]
        [DataRow("R 5 5 10 10", 'R', 5, 5, 10, 10)]
        public void ReactangleCommandParserTest(string commandText, char commandName, int x1, int y1, int x2, int y2)
        {
            ReactangleCommandParser parser = new ReactangleCommandParser(commandText);
            ReactangleCommand command = (ReactangleCommand)parser.ParseCommand();

            Assert.AreEqual(command.CommandName, commandName, "Command Name not parsed correctly.");
            Assert.AreEqual(command.TopLeft.X, x1, "Command TopLeft Point X not parsed properly.");
            Assert.AreEqual(command.TopLeft.Y, y1, "Command TopLeft Point Y not parsed properly..");
            Assert.AreEqual(command.RightBottom.X, x2, "Command RightBottom Point X not parsed properly.");
            Assert.AreEqual(command.RightBottom.Y, y2, "Command Rightbottom Point Y not parsed properly..");
        }
    }
}