using DrawingProgram.Domains;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DrawingProgram.CommandParsers.Tests
{
    [TestClass()]
    public class LineCommandParserTests
    {
        [TestMethod()]
        [DataRow("L 5 5 5 10", 'L', 5, 5, 5, 10)]
        public void LineCommandParserTest(string commandText, char commandName, int x1, int y1, int x2, int y2)
        {
            LineCommandParser parser = new LineCommandParser(commandText);
            LineCommand command = (LineCommand)parser.ParseCommand();

            Assert.AreEqual(command.CommandName, commandName, "Command Name not parsed correctly.");
            Assert.AreEqual(command.StartPoint.X, x1, "Command Start Point X not parsed properly.");
            Assert.AreEqual(command.StartPoint.Y, y1, "Command Start Point Y not parsed properly..");
            Assert.AreEqual(command.EndPoint.X, x2, "Command End Point X not parsed properly.");
            Assert.AreEqual(command.EndPoint.Y, y2, "Command End Point Y not parsed properly..");

        }
    }
}