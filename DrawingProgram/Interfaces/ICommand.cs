using System.Collections.Generic;

namespace DrawingProgram.Interfaces
{
    public interface ICommand
    {
        char CommandName { get; set; }
        List<string> CommandParams { get; set; }
    }
}
