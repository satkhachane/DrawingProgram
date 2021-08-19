using DrawingProgram.Domains;
using DrawingProgram.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace DrawingProgram.Processors
{
    public class BackColorCommandProcessor : BaseProcessor, ICommandProcessor
    {
        Canvas _canvas;
        public override void ProcessCommand(ICommand command, ref Canvas canvas)
        {
            _canvas = canvas;
            BackColorCommand backColorCommand = command as BackColorCommand;
            var startPoint = new Point { X = backColorCommand.Point.X - 1, Y = backColorCommand.Point.Y - 1 };
            if (!IsPixelOnCanvas(startPoint, _canvas))
            {
                Console.WriteLine("Invalid startpoint for coloring. Processor will skip to execute this command.");
                Console.ReadLine();
                return;
            }
            ColorAdjacentPoints(startPoint, backColorCommand.Color);
        }

        void ColorAdjacentPoints(Point point, char color)
        {
            if (_canvas.GetPointChar(point.X, point.Y) != Constants.EmptyChar)
            {
                return;
            }
            else
            {
                _canvas.SetCanvasPoint(point.X, point.Y, color);
                List<Point> adjacentPoints = new List<Point> {
                new Point(point.X-1,point.Y-1), new Point(point.X,point.Y-1), new Point(point.X+1,point.Y-1),
                new Point(point.X-1,point.Y), new Point(point.X+1,point.Y),
                new Point(point.X-1,point.Y+1), new Point(point.X,point.Y+1), new Point(point.X+1,point.Y+1)};

                foreach (Point p in adjacentPoints)
                {
                    if (IsPixelOnCanvas(p, _canvas))
                    {
                        ColorAdjacentPoints(p, color);
                    }
                }
            }
        }
    }
}
