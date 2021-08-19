using DrawingProgram.Interfaces;
using System.Drawing;

namespace DrawingProgram.Domains
{
    public class ReactangleCommand : Command, ICommand
    {
        public Point TopLeft { get; set; }
        public Point RightBottom { get; set; }
    }
}
