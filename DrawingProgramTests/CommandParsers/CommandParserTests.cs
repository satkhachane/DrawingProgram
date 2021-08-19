using DrawingProgram.Domains;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DrawingProgram.CommandParsers.Tests
{
    [TestClass()]
    public class CommandParserTests
    {
        [TestMethod()]
        [DataRow("C 20 10", 'C', 2)]
        [DataRow("B 5 10 c", 'B', 3)]
        [DataRow("L 5 5 5 10", 'L', 4)]
        [DataRow("R 5 5 10 10", 'R', 4)]
        public void GetCommandTextTest(string commandText, char commandName, int numberOfArguments)
        {
            CommandParser parser = new CommandParser(commandText);
            Command command = (Command)parser.ParseCommand();

            Assert.AreEqual(command.CommandName, commandName, "Command Name not parsed correctly.");
            Assert.AreEqual(command.CommandParams.Count, numberOfArguments, "Height of canvas not parsed properly.");
        }
    }
}