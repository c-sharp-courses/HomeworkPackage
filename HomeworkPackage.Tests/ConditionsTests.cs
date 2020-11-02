using NUnit.Framework;
using HomeworkPackage;
using HomeworkPackage.HomeworkPackage;
using System;

namespace HomeworkPackage.Tests
{
    public class ConditionsTests
    {
        public double delta = 0.001;

        [TestCase(0, 1, -1)]
        [TestCase(2, 2, 4)]
        [TestCase(2, 1, 3)]

        public void GetSomeStupidResult(int a, int b, int expected)
        {
            int actual = Conditions.GetSomeStupidResult(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1, new int[] { 1 })]
        [TestCase(1, -1, new int[] { 4 })]
        [TestCase(0, -1, new int[] { 3, 4 })]
        [TestCase(0, 0, new int[] { 1, 2, 3, 4 })]

        public void DetermineQuarter(double x, double y, int[] expected)
        {
            int[] actual = Conditions.DetermineQuarter(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(12, "двенадцать")]
        [TestCase(46, "сорок шесть")]
        [TestCase(8, "восемь")]

        public void ConvertNumberToString(int number, string expected)
        {
            string actual = Conditions.ConvertNumberToString(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(244)]
        public void ConvertNumberToStringNegative(int number)
        {
            try
            {
                Conditions.ConvertNumberToString(number);
            }
            catch
            {
                Assert.Pass();
            }
        }

        [TestCase(1, 5, 6, new double[] {-3, -2})]
        [TestCase(1, 0, 0, new double[] {0})]
        [TestCase(0, 1, 1, new double[] {-1})]

        public void SolveQuadraticEquation(double a, double b, double c, double[] expected)
        {
            double[] actual = Conditions.SolveQuadraticEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

    }
}
