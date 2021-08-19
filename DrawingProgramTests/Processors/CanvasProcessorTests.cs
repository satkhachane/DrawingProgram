using DrawingProgram.CommandParsers;
using DrawingProgram.Domains;
using DrawingProgram.Interfaces;
using DrawingProgram.Validators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DrawingProgram.Processors.Tests
{
    [TestClass()]
    public class CanvasProcessorTests
    {
        [TestMethod()]
        [DataRow("C 20 10", 20, 10)]
        [DataRow("C 5 20", 5, 20)]
        public void ProcessCommandTest(string commandText, int width , int height)
        {
            ICommandParser parser = new CanvasCommandParser(commandText);
            ICommand command = parser.ParseCommand();
            Canvas canvas = null;
            ICommandProcessor processor = CommandProcessorFactory.GetCommandProcessor(command);
            processor.ProcessCommand(command, ref canvas);

            Assert.IsNotNull(canvas,"Not able to create canvas from canvas command.");
            Assert.AreEqual(canvas.GetX(), width, "Not able to parse canvas width while creating canvas.");
            Assert.AreEqual(canvas.GetY(), height, "Not able to parse canvas height while creating canvas.");
        }
    }
}