using NUnit.Framework;
using HomeworkPackage;
using HomeworkPackage.HomeworkPackage;
using System;
using NUnit.Framework.Internal;

namespace HomeworkPackage.Tests
{
    public class LoopsTests
    {
        double delta = 0.0001;

        [TestCase(3, 4, 81)]
        [TestCase(2, -2, 0.25)]
        [TestCase(4, 0, 1)]
        public void RaiseToPow(double basis, int index, double expected)
        {
            double actual = Loops.RaiseToPow(basis, index);

            Assert.AreEqual(expected, actual, delta);
        }

        [TestCase(0, 0)]
        public void RaiseToPowNegative(double basis, int index)
        {
            try
            {
                Loops.RaiseToPow(basis, index);
            }
            catch
            {
                Assert.Pass();
            }
        }

        [TestCase(200, new int[] { 200, 400, 600, 800 })]
        [TestCase(300, new int[] { 300, 600, 900 })]
        [TestCase(2000, new int[] { })]
        public void GetArrayOfMultiples(int number, int[] expected)
        {
            int[] actual = Loops.GetArrayOfMultiples(number);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(16, 3)]
        [TestCase(10, 3)]
        [TestCase(1024, 31)]
        public void GetIntSqrt(int number, int expected)
        {
            int actual = Loops.GetIntSqrt(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-1)]
        public void GetIntSqrtNegative(int number)
        {
            try
            {
                Loops.GetIntSqrt(number);
            }
            catch
            {
                Assert.Pass();
            }

        }


        [TestCase(16, 8)]
        [TestCase(51, 17)]
        [TestCase(-24, 12)]
        public void GetGreatestDivisor(int number, int expected)
        {
            int actual = Loops.GetGreatestDivisor(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 8)]
        [TestCase(7, 13)]
        [TestCase(8, 21)]
        public void GetFibbonacci(int index, int expected)
        {
            int actual = Loops.GetFibbonacci(index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(18, 24, 6)]
        [TestCase(100, -100, 100)]
        [TestCase(-16, 48, 16)]
        public void GetGreatestCommonDivisor(int A, int B, int expected)
        {
            int actual = Loops.GetGreatestCommonDivisor(A, B);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(27, 3)]
        [TestCase(125, 5)]
        [TestCase(1000, 10)]
        public void GetCubicRoot(int cube, int expected)
        {
            int actual = Loops.GetCubicRoot(cube);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(12341, 3)]
        [TestCase(96822, 1)]
        [TestCase(222, 0)]
        static public void GetOddDigitsCount(int number, int expected)
        {
            int actual = Loops.GetOddDigitsCount(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(234, 432)]
        [TestCase(10002, 20001)]
        [TestCase(14643, 34641)]

        static public void Reverse(int number, int expected)
        {
            int actual = Loops.Reverse(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 4)]
        [TestCase(20, 9)]
        [TestCase(30, 14)]
        static public void CountEvenerNumbersInRange(int upperLimit, int expected)
        {
            int actual = Loops.CountEvenerNumbersInRange(upperLimit);
            Assert.AreEqual(expected, actual);
        }

    }
}
