using DrawingProgram.Domains;
using DrawingProgram.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DrawingProgram.CommandParsers
{
    public class CommandParserFactory
    {
        public static ICommandParser GetCommandParser(string commandText)
        {
            ICommandParser commandParser = null;
            List<string> commandParams = commandText.Split(' ').ToList();
            char commandName = commandParams.First().First();
            //TODO: We can use IOC here based on command type to get command parser
            switch (commandName)
            {
                case CommandConstants.Canvas: commandParser = new CanvasCommandParser(commandText); break;
                case CommandConstants.Line: commandParser = new LineCommandParser(commandText); break;
                case CommandConstants.Reactangle: commandParser = new ReactangleCommandParser(commandText); break;
                case CommandConstants.BackColor: commandParser = new BackColorCommandParser(commandText); break;
                default: break;
            }

            return commandParser;
        }
    }
}
