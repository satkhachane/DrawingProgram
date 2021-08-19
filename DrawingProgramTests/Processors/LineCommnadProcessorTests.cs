using DrawingProgram.CommandParsers;
using DrawingProgram.Domains;
using DrawingProgram.Interfaces;
using DrawingProgramTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DrawingProgram.Processors.Tests
{
    [TestClass()]
    public class LineCommnadProcessorTests : TestBase
    {
        [TestMethod()]
        [DataRow("L 1 4 1 8")]
        [DataRow("L 1 2 5 2")]
        public void ProcessCommandTest(string commandText)
        {
            DrawingManager.ParseAndProcessCommand("C 10 20");
            ICommandParser parser = new LineCommandParser(commandText);
            ICommand command = parser.ParseCommand();            
            ICommandProcessor processor = CommandProcessorFactory.GetCommandProcessor(command);
            processor.ProcessCommand(command, ref DrawingManager.MainCanvas);

            LineCommand lineCommnad = command as LineCommand;
            if(lineCommnad.StartPoint.X == lineCommnad.EndPoint.X)
            {
                VerifyVerticalLineOnCanvas(lineCommnad.StartPoint.X, lineCommnad.StartPoint.Y, lineCommnad.EndPoint.Y);
            }

            if (lineCommnad.StartPoint.Y == lineCommnad.EndPoint.Y)
            {
                verifyHorizonatalLineOnCanvas(lineCommnad.StartPoint.X, lineCommnad.EndPoint.X, lineCommnad.StartPoint.Y);
            }
        }        
    }
}