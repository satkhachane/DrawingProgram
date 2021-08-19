using DrawingProgram.Domains;
using DrawingProgram.Interfaces;

namespace DrawingProgram.Processors
{
    public class CanvasCommandProcessor : ICommandProcessor
    {
        public void ProcessCommand(ICommand command, ref Canvas canvas)
        {
            CanvasCommand canvasCommand = command as CanvasCommand;
            canvas = new Canvas(canvasCommand.Width, canvasCommand.Height);
        }
    }
}
