using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using hw1.Custom;

namespace UnitTestHw1
{

    [TestClass]
    public class UnitTestCustomMatrix
    {
        [TestMethod]
        public void TestMethodMultiply()
        {
            var matrix = new CustomMatrix();
            var arr1 = new int[3, 3]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            var arr2 = new int[3, 3]
            {
                {1, 1, 1},
                {2, 2, 2},
                {3, 3, 3}
            };

            var ret = matrix.MatrixMultiply<int>(arr1, arr2);
            var result = new Int32[3, 3]
            {
                {14, 14, 14},
                {32, 32, 32},
                {50, 50, 50}
            };

            
            // Assert.AreEqual(result, ret, "Multiply Error");
        }
    }
}
