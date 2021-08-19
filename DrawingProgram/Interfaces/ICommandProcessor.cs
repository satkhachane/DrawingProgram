using DrawingProgram.Domains;

namespace DrawingProgram.Interfaces
{
    public interface ICommandProcessor
    {
        void ProcessCommand(ICommand command, ref Canvas canvas);
    }
}
