using DrawingProgram.Domains;
using DrawingProgram.Interfaces;
using System.Drawing;
using System.Linq;


namespace DrawingProgram.CommandParsers
{
    public class BackColorCommandParser : CommandParser
    {
        public BackColorCommandParser(string commandText) : base(commandText)
        {

        }

        public override ICommand ParseCommand()
        {
            ICommand command = base.ParseCommand();
            BackColorCommand backColorcommand = new BackColorCommand();

            string firstParam = command.CommandParams.Skip(0).First();
            string secondParam = command.CommandParams.Skip(1).First();
            char color = command.CommandParams.Skip(2).First().First();

            backColorcommand.CommandName = command.CommandName;
            backColorcommand.CommandParams = command.CommandParams;

            int x1, y1;

            if (int.TryParse(firstParam, out x1) && int.TryParse(secondParam, out y1))
            {

                backColorcommand.Color = color;
                backColorcommand.Point = new Point(x1, y1);
            }

            return backColorcommand;
        }
    }
}
