using System.Drawing;

namespace DrawingProgram.Domains
{
    public class LineCommand : Command
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
    }
}
