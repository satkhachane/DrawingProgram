using System.Collections.Generic;

namespace DrawingProgram.Interfaces
{
    public interface ICommandValidator
    {
        List<string> ValidationErrors { get; set; }
        List<char> ApplicableCommands { get; set; }
        bool Validate(ICommand command);
    }
}
