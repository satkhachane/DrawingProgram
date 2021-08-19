using DrawingProgram.Domains;
using DrawingProgram.Interfaces;
using System.Linq;

namespace DrawingProgram.CommandParsers
{
    public class CanvasCommandParser : CommandParser
    {
        public CanvasCommandParser(string commandText) : base(commandText)
        {

        }

        public override ICommand ParseCommand()
        {
            ICommand command = base.ParseCommand();
            CanvasCommand canvasCommand = new CanvasCommand();

            canvasCommand.CommandName = command.CommandName;
            canvasCommand.CommandParams = command.CommandParams;

            string firstParam = command.CommandParams.Skip(0).First();
            string secondParam = command.CommandParams.Skip(1).First();


            int x1, y1;
            if (int.TryParse(firstParam, out x1) && int.TryParse(secondParam, out y1))
            {
                canvasCommand.Width = x1;
                canvasCommand.Height = y1;
            }
            return canvasCommand;
        }
    }
}
