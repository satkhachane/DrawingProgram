using DrawingProgram;
using DrawingProgram.Domains;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingProgramTests
{
    public class TestBase
    {
        public void VerifyVerticalLineOnCanvas(int x, int y1, int y2)
        {
            for (int index = y1 - 1; index < y2; index++)
            {
                string message = string.Format("Expected charecter is missing at location X:{0} Y:{1}", x, index);
                Assert.AreEqual(DrawingManager.MainCanvas.GetPointChar(x - 1, index), Constants.DrawingChar, message);
            }
        }

        public void verifyHorizonatalLineOnCanvas(int x1, int x2, int y)
        {
            for (int index = x1 - 1; index < x2; index++)
            {
                string message = string.Format("Expected charecter is missing at location X:{0} Y:{1}", index, y);
                Assert.AreEqual(DrawingManager.MainCanvas.GetPointChar(index, y - 1), Constants.DrawingChar, message);
            }
        }
    }
}
