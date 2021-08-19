using System.Drawing;

namespace DrawingProgram.Domains
{
    public class BackColorCommand : Command
    {
        public Point Point { get; set; }
        public char Color { get; set; }
    }
}
