using System;

namespace DrawingProgram.Domains
{
    public class Canvas
    {
        int width = -1;
        int height = -1;
        char[,] canvasPoints;

        public Canvas(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                width = x;
                height = y;
                canvasPoints = new char[width, height];
            }
            else
            {
                throw new Exception("Invalid Canvas initilization");
            }
        }
        public int GetX()
        {
            return width;
        }

        public int GetY()
        {
            return height;
        }

        public char [,]  GetCanvasPoints()
        {
            return canvasPoints;
        }

        public char GetPointChar(int x, int y)
        {
            return canvasPoints[x, y];
        }

        public void SetCanvasPoint(int x, int y, char ch)
        {
            canvasPoints[x, y] = ch;
        }

        public void InitialiseCanvasToChar(char defaultChar)
        {
            for (int widthIndex = 0; widthIndex < width; widthIndex++)
            {
                for (int heightIndex = 0; heightIndex < height; heightIndex++)
                {
                    canvasPoints[widthIndex, heightIndex] = Constants.EmptyChar;
                }
            }
        }       
    }
}
