using DrawingProgram.CommandParsers;
using DrawingProgram.Domains;
using DrawingProgram.Interfaces;
using DrawingProgramTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DrawingProgram.Processors.Tests
{
    [TestClass()]
    public class ReactangleProcessorTests : TestBase
    {
        [TestMethod()]
        [DataRow("R 2 2 8 8")]
        public void ProcessCommandTest(string commandText)
        {
            DrawingManager.ParseAndProcessCommand("C 10 20");
            ICommandParser parser = new ReactangleCommandParser(commandText);
            ICommand command = parser.ParseCommand();
            ICommandProcessor processor = CommandProcessorFactory.GetCommandProcessor(command);
            processor.ProcessCommand(command, ref DrawingManager.MainCanvas);

            ReactangleCommand rectCommand = command as ReactangleCommand;            
            VerifyVerticalLineOnCanvas(rectCommand.TopLeft.X, rectCommand.TopLeft.Y, rectCommand.RightBottom.Y);
            VerifyVerticalLineOnCanvas(rectCommand.RightBottom.X, rectCommand.TopLeft.Y, rectCommand.RightBottom.Y);
            verifyHorizonatalLineOnCanvas(rectCommand.TopLeft.X,  rectCommand.RightBottom.X, rectCommand.TopLeft.Y);
            verifyHorizonatalLineOnCanvas(rectCommand.TopLeft.X,  rectCommand.RightBottom.X, rectCommand.RightBottom.Y);
        }       

    }
}