using DrawingProgram.Domains;
using DrawingProgram.Interfaces;

namespace DrawingProgram.Processors

{
    public class CommandProcessorFactory
    {
        public static ICommandProcessor GetCommandProcessor(ICommand command)
        {
            ICommandProcessor commandProcessor = null;

            //TODO: We can use IOC here based on command type to get command processor
            switch (command.CommandName)
            {
                case CommandConstants.Canvas: commandProcessor = new CanvasCommandProcessor(); break;
                case CommandConstants.Line: commandProcessor = new LineCommandProcessor(); break;
                case CommandConstants.Reactangle: commandProcessor = new ReactangleCommandProcessor(); break;
                case CommandConstants.BackColor: commandProcessor = new BackColorCommandProcessor(); break;
                default: break;
            }

            return commandProcessor;
        }
    }
}
