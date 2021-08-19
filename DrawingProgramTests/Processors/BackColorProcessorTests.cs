using DrawingProgram.CommandParsers;
using DrawingProgram.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DrawingProgram.Processors.Tests
{
    [TestClass()]
    public class BackColorProcessorTests
    {
        [TestMethod()]
        [DataRow("B 3 3 c", 'c')]
        [DataRow("B 3 3 r", 'r')]
        public void ProcessCommandTest(string commandText, char color)
        {
            DrawingManager.ParseAndProcessCommand("C 20 20");
            DrawingManager.ParseAndProcessCommand("R 2 2 4 4");
            ICommandParser parser = new BackColorCommandParser(commandText);
            ICommand command = parser.ParseCommand();
            ICommandProcessor processor = CommandProcessorFactory.GetCommandProcessor(command);
            processor.ProcessCommand(command, ref DrawingManager.MainCanvas);
            Assert.AreEqual(DrawingManager.MainCanvas.GetPointChar(2,2),color,"The start point of the color is not set properly.");
        }

        [TestMethod()]
        [DataRow("B 3 3 c", 'c')]        
        public void FillWholeCanvasWithColorTest(string commandText, char color)
        {
            DrawingManager.ParseAndProcessCommand("C 10 10");            
            ICommandParser parser = new BackColorCommandParser(commandText);
            ICommand command = parser.ParseCommand();
            ICommandProcessor processor = CommandProcessorFactory.GetCommandProcessor(command);
            processor.ProcessCommand(command, ref DrawingManager.MainCanvas);

            for (int widthIndex = 0; widthIndex < DrawingManager.MainCanvas.GetX(); widthIndex++)
            {
                for (int heightIndex = 0; heightIndex < DrawingManager.MainCanvas.GetY(); heightIndex++)
                {
                    string message = string.Format("Expected color not found at location x:{0} y:{1} ",widthIndex,heightIndex);
                    Assert.AreEqual(DrawingManager.MainCanvas.GetPointChar(widthIndex, heightIndex), color, message);
                }
            }
        }
    }
}