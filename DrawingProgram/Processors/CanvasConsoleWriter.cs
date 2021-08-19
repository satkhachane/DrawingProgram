using DrawingProgram.Domains;
using System;

namespace DrawingProgram.Processors
{
    public class CanvasConsoleWriter
    {
        Canvas _canvas;
        public CanvasConsoleWriter(Canvas canvas)
        {
            _canvas = canvas;
        }
        public void WriteOnConsole()
        {
            Console.WriteLine("Current state of canvas...");
            Console.Write(Environment.NewLine);
            PrintHorizonatalBorder();
            for (int yIndex = 0; yIndex < _canvas.GetY(); yIndex++)
            {
                PrintCanvasSideChar();
                for (int xIndex = 0; xIndex < _canvas.GetX(); xIndex++)
                {
                    Console.Write(_canvas.GetPointChar(xIndex, yIndex));
                }

                PrintCanvasSideChar();
                Console.Write(Environment.NewLine);
            }

            PrintHorizonatalBorder();
        }

        void PrintHorizonatalBorder()
        {
            for (int xIndex = 0; xIndex < _canvas.GetX() + 2; xIndex++)
            {
                Console.Write(Constants.HorizonatalSeprator);
            }
            Console.Write(Environment.NewLine);
        }

        void PrintCanvasSideChar()
        {
            Console.Write(Constants.Verticalseprator);
        }
    }
}