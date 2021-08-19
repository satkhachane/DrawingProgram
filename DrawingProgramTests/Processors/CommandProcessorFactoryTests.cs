using DrawingProgram.CommandParsers;
using DrawingProgram.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DrawingProgram.Processors.Tests
{
    [TestClass()]
    public class CommandProcessorFactoryTests
    {
        [TestMethod()]
        [DataRow("C 20 10", "CanvasCommandProcessor")]
        [DataRow("B 5 10 c", "BackColorCommandProcessor")]
        [DataRow("L 5 5 5 10", "LineCommandProcessor")]
        [DataRow("R 5 5 10 10", "ReactangleCommandProcessor")]
        public void GetCommandProcessorTest(string commandText, string processorName)
        {
            ICommandParser parser = new CommandParser(commandText);
            ICommand command =  parser.ParseCommand();
            ICommandProcessor processor = CommandProcessorFactory.GetCommandProcessor(command);
            var expectedProcessor = processor.GetType();
            Assert.AreEqual(expectedProcessor.Name, processorName, "Not able to get the correct parser for the command.");
        }
    }
}