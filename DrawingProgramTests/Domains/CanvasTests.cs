using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DrawingProgram.Domains.Tests
{
    [TestClass()]
    public class CanvasTests
    {
        [TestMethod()]
        [DataRow(-1, 0, false)]
        [DataRow(0, 0, false)]
        [DataRow(10, 10, true)]
        public void CanvasCreationTest(int x, int y, bool shouldCreatecanvas)
        {
            Canvas canvas = null;

            try
            {
                canvas = new Canvas(x, y);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
            }

            if (shouldCreatecanvas)
            {
                Assert.IsNotNull(canvas, "Canvas is not created with correct co ordinates.");
            }
            else
            {
                Assert.IsNull(canvas, "Canvas got created with invalid co ordinates.");
            }
        }

        [TestMethod()]
        [DataRow(20, 10)]
        public void CanvasCoOrdinatesTest(int x, int y)
        {
            Canvas canvas = null;
            canvas = new Canvas(x, y);
            Assert.AreEqual(canvas.GetX(), x, "Canvas width was not able to set properly.");
            Assert.AreEqual(canvas.GetY(), y, "Canvas height was not able to set properly.");
        }

        [TestMethod()]
        [DataRow(20, 10)]
        public void CanvasGetSetTest(int x, int y)
        {
            Canvas canvas = null;
            canvas = new Canvas(x, y);
            char expected = '*';
            canvas.SetCanvasPoint(3, 4, expected);
            char actual = canvas.GetPointChar(3, 4);
            Assert.AreEqual(actual, expected, "Not able to retrive the proper char set to the point in canvas.");
        }
    }
}