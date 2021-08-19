using DrawingProgram.Domains;
using DrawingProgram.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DrawingProgram.CommandParsers
{
    public class CommandParser : ICommandParser
    {
        string _commandText = string.Empty;
        public CommandParser(string commandText)
        {
            _commandText = commandText;
        }

        public string GetCommandText()
        {
            return _commandText;
        }

        public virtual ICommand ParseCommand()
        {
            List<string> commandParams = _commandText.Split(' ').ToList();
            ICommand command = new Command();

            command.CommandName = commandParams.First().First();
            command.CommandParams = commandParams.Skip(1).ToList();

            return command;
        }

    }
}
