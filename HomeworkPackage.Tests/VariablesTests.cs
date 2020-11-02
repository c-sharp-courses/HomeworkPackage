using NUnit.Framework;
using HomeworkPackage;
using HomeworkPackage.HomeworkPackage;
using System;

namespace HomeworkPackage.Tests
{

    public class VariablesTests
    {
        public double delta = 0.001;

        [TestCase(2.0, 1.0, -11)]
        [TestCase(3, 2, -19)]
        [TestCase(1, 0, -5)]
        public void CalculateStrangeFormula(double a, double b, double expected)
        {
            double actual = Variables.CalculateStrangeFormula(a, b);

            Assert.AreEqual(expected, actual, delta);
        }


        [TestCase(1, 1)]
        public void CalculateStrangeFormulaNegative(double a, double b)
        {
            try
            {
                Variables.CalculateStrangeFormula(a, b);
            }
            catch
            {
                Assert.Pass();
            }
        }

        [TestCase(1, 1, 0, -1)]
        [TestCase(2, 1, 0, -0.5)]
        [TestCase(1, 2, 0, -2)]
        public void SolveLinearEquation(double a, double b, double c, double expected)
        {
            double actual = Variables.SolveLinearEquation(a, b, c);
            Assert.AreEqual(expected, actual, delta);
        }

        [TestCase(0, 1, 1)]
        [TestCase(0, 0, 1)]
        public void SolveLinearEquationNegative(double a, double b, double c)
        {
            try
            {
                Variables.SolveLinearEquation(a, b, c);
            }
            catch
            {
                Assert.Pass();
            }
        }

        [TestCase(0, 0, 1, 1, new double[2] { 0, 1 })]
        [TestCase(1, 0, 0, 1, new double[2] { 1, -1 })]
        [TestCase(0, 0, 1, 2, new double[2] { 0, 2 })]
        public void FindLineCoeffientsByPoints(double x1, double y1, double x2, double y2, double[] expected)
        {
            
            double[] actual = new double[2];
               actual = Variables.FindLineCoeffientsByPoints(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(1, 0, 1, 4)]
        public void FindLineCoeffientsByPointsNegative(double x1, double y1, double x2, double y2)
        {
            try
            {
                Variables.FindLineCoeffientsByPoints( x1, y1, x2, y2);
            }
            catch
            {
                Assert.Pass();
            }
        }

    }
}