using DrawingProgram.Domains;
using DrawingProgram.Interfaces;
using System;
using System.Drawing;

namespace DrawingProgram.Processors
{
    public class LineCommandProcessor : BaseProcessor, ICommandProcessor
    {
        public override void ProcessCommand(ICommand command, ref Canvas canvas)
        {
            LineCommand lineCommand = command as LineCommand;

            if (!IsPixelOnCanvas(lineCommand.StartPoint, canvas) || !IsPixelOnCanvas(lineCommand.EndPoint, canvas))
            {
                Console.WriteLine("Invalid coordinates provided for line. Processor will skip to execute this command.");
                Console.ReadLine();
                return;
            }

            if (IsSupportedCoordinates(lineCommand.StartPoint, lineCommand.EndPoint))
            {
                if (lineCommand.StartPoint.X == lineCommand.EndPoint.X)
                {
                    DrawVerticleLine(lineCommand.StartPoint, lineCommand.EndPoint, canvas);
                }
                else if (lineCommand.StartPoint.Y == lineCommand.EndPoint.Y)
                {
                    DrawHorizontalLine(lineCommand.StartPoint, lineCommand.EndPoint, canvas);
                }
            }
        }

        bool IsSupportedCoordinates(Point startPoint, Point endPoint)
        {
            return startPoint.X == endPoint.X || endPoint.Y == endPoint.Y;
        }
    }
}
