using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using hw1.Custom;

namespace UnitTestHw1
{

    [TestClass]
    public class UnitTestCustomMatrix
    {

        CustomMatrix matrix = new CustomMatrix();

        [TestMethod]
        public void TestMethodMultiply()
        {
            
            var arr1 = new int[1, 3]
            {
                {1, 2, 3},
            };

            var arr2 = new int[3, 3]
            {
                {1, 2, 3},
                {1, 2, 3},
                {1, 2, 3}
            };

            var ret = matrix.MatrixMultiply<int>(arr1, arr2);
            var result = new Int32[1, 3]
            {
                {6, 12, 18},
            };

            Assert.AreEqual(result, ret, "Multiply Error");
        }

        [TestMethod]
        public void TestMethodTranspose()
        {

            var arr1 = new int[3, 3]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            var ret = matrix.MatrixTranspose<int>(arr1);
            var result = new Int32[3, 3]
            {
                {1, 4, 7},
                {2, 5, 8},
                {3, 6, 9}
            };

            Assert.AreEqual(result, ret, "Transpose Error");
        }

        [TestMethod]
        public void TestMethodInverse()
        {

            var arr1 = new double[3, 3]
            {
                {5, 9, 8},
                {7, 3, 1},
                {2, 4, 7}
            };

            var ret = matrix.MatrixInverse<double>(arr1);
            var result = new Int32[3, 3]
            {
                {-1, -2, -1},
                {-2, -5, -3},
                {2, 2, 1}
            };

            // Assert.AreEqual(result, ret.Item1, "Inverse Error");
        }

    }
}
