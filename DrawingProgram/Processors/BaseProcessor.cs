using DrawingProgram.Domains;
using DrawingProgram.Interfaces;
using System;
using System.Drawing;

namespace DrawingProgram.Processors
{
    public class BaseProcessor : ICommandProcessor
    {
        public virtual void ProcessCommand(ICommand command, ref Canvas canvas)
        {
            throw new NotImplementedException();
        }

        public void DrawVerticleLine(int x1, int y1, int x2, int y2, Canvas canvas)
        {
            for (int index = y1 - 1; index < y2; index++)
            {
                canvas.SetCanvasPoint(x1 - 1, index, 'x');
            }
        }
        public void DrawVerticleLine(Point startPoint, Point endPoint, Canvas canvas)
        {
            for (int index = startPoint.Y - 1; index < endPoint.Y; index++)
            {
                canvas.SetCanvasPoint(startPoint.X - 1, index, 'x');
            }
        }

        public void DrawHorizontalLine(int x1, int y1, int x2, int y2, Canvas canvas)
        {
            for (int index = x1 - 1; index < x2; index++)
            {
                canvas.SetCanvasPoint(index, y1 - 1, 'x');
            }
        }

        public void DrawHorizontalLine(Point startPoint, Point endPoint, Canvas canvas)
        {
            for (int index = startPoint.X - 1; index < endPoint.X; index++)
            {
                canvas.SetCanvasPoint(index, startPoint.Y - 1, 'x');
            }
        }

        public bool IsPixelOnCanvas(Point p, Canvas canvas)
        {
            return p.X > 0 && p.Y > 0 && p.X <= canvas.GetX() && p.Y <= canvas.GetY();
        }       
    }
}
