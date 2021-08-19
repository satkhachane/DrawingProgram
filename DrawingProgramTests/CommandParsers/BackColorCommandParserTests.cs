using DrawingProgram.Domains;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DrawingProgram.CommandParsers.Tests
{
    [TestClass()]
    public class BackColorCommandParserTests
    {
        [TestMethod()]
        [DataRow("B 5 10 c", 'B', 5, 10, 'c')]
        public void ParseCommandTest(string commandText, char commandName, int x, int y, char color)
        {
            BackColorCommandParser parser = new BackColorCommandParser(commandText);
            BackColorCommand command = (BackColorCommand)parser.ParseCommand();

            Assert.AreEqual(command.CommandName, commandName, "Command Name not parsed correctly.");
            Assert.AreEqual(command.Point.X, x, "Command Point x not parsed properly.");
            Assert.AreEqual(command.Point.Y, y, "Command Point y not parsed properly..");
            Assert.AreEqual(command.Color, color, "Command Color not parsed correctly.");
        }
    }
}