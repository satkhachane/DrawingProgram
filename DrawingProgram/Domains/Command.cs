using DrawingProgram.Interfaces;
using System.Collections.Generic;

namespace DrawingProgram.Domains
{
    public class Command : ICommand
    {
        public char CommandName { get; set; }
        public List<string> CommandParams { get; set; }
    }
}
