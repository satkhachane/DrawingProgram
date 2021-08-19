using DrawingProgram;
using DrawingProgram.Domains;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DrawingProgramTests.IntegrationTest
{
    [TestClass()]
    public class CanvasIntegrationTest
    {
        List<string> commandsList = new List<string>();
        public CanvasIntegrationTest()
        {
            commandsList.Add("C 20 4");
            commandsList.Add("L 1 2 6 2");
            commandsList.Add("L 6 3 6 4");
            commandsList.Add("R 14 1 18 3");
            commandsList.Add("B 10 3 o");
        }

        [TestMethod("Main Integration test for provided inputs in problem statement")]
        public void IntegrationTestforCanvas()
        {
            char[,] expectedOutput = LoadExpectedOutPut();

            foreach (var command in commandsList)
            {
                DrawingManager.ParseAndProcessCommand(command);
            }

            Canvas canvas = DrawingProgram.DrawingManager.MainCanvas;
            CollectionAssert.AreEqual(expectedOutput, canvas.GetCanvasPoints(), "test failed");
        }

        char[,] LoadExpectedOutPut()
        {
            char[,] expectedOutput = null;
            string str = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\\IntegrationTest\\ExpectedOutput.txt");
            List<string> lines = File.ReadLines(AppDomain.CurrentDomain.BaseDirectory + "\\IntegrationTest\\ExpectedOutput.txt").ToList();
            
            expectedOutput = new char[lines.First().Length, lines.Count];
            for (int yIndex = 0; yIndex < lines.Count; yIndex++)
            {
                for (int xIndex = 0; xIndex < lines.First().Length; xIndex++)
                {
                    expectedOutput[xIndex, yIndex] = lines[yIndex][xIndex];
                    if (expectedOutput[xIndex, yIndex] == ' ')
                        expectedOutput[xIndex, yIndex] = Constants.EmptyChar;
                }
            }
            return expectedOutput;
        }
    }
}
