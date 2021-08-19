using DrawingProgram.Domains;
using DrawingProgram.Interfaces;
using System;

namespace DrawingProgram.Processors
{
    public class ReactangleCommandProcessor : BaseProcessor, ICommandProcessor
    {
        public override void ProcessCommand(ICommand command, ref Canvas canvas)
        {
            ReactangleCommand rectCommand = command as ReactangleCommand;

            if (!IsPixelOnCanvas(rectCommand.TopLeft, canvas) || !IsPixelOnCanvas(rectCommand.RightBottom, canvas))
            {
                Console.WriteLine("Invalid coordinates provided for reactangle. Processor will skip to execute this command.");
                Console.ReadLine();
                return;
            }

            DrawHorizontalLine(rectCommand.TopLeft.X, rectCommand.TopLeft.Y, rectCommand.RightBottom.X, rectCommand.TopLeft.Y, canvas);
            DrawHorizontalLine(rectCommand.TopLeft.X, rectCommand.RightBottom.Y, rectCommand.RightBottom.X, rectCommand.RightBottom.Y, canvas);
            DrawVerticleLine(rectCommand.TopLeft.X, rectCommand.TopLeft.Y, rectCommand.TopLeft.X, rectCommand.RightBottom.Y, canvas);
            DrawVerticleLine(rectCommand.RightBottom.X, rectCommand.TopLeft.Y, rectCommand.RightBottom.X, rectCommand.RightBottom.Y, canvas);
        }
    }
}
