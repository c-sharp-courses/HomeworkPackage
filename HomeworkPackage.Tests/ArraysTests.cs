using NUnit.Framework;
using HomeworkPackage;
using HomeworkPackage.HomeworkPackage;
using System;

namespace HomeworkPackage.Tests
{
    class ArraysTests
    {
        [TestCase(new[] { 4, 2, 3, 5, 7 }, 2)]
        [TestCase(new[] { -1, 0, 3, 2, 3 }, -1)]
        [TestCase(new[] { 4, 2, 3, 5, -230 }, -230)]
        public void GetMin(int[] numbers, int expected)
        {
            int actual = Arrays.GetMin(numbers);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 4, 2, 3, 5, 7 }, 7)]
        [TestCase(new[] { -1, 0, 3, 2, 3 }, 3)]
        [TestCase(new[] { 4, 2, 3, 5, -230 }, 5)]
        public void GetMax(int[] numbers, int expected)
        {
            int actual = Arrays.GetMax(numbers);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 4, 2, 3, 5, 7 }, 1)]
        [TestCase(new[] { -1, 0, 3, 2, 3 }, 0)]
        [TestCase(new[] { 4, 2, 3, 5, -230 }, 4)]
        public void GetMinIndex(int[] numbers, int expected)
        {
            int actual = Arrays.GetMinIndex(numbers);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new[] { 4, 2, 3, 5, 7 }, 4)]
        [TestCase(new[] { -1, 0, 3, 2, 3 }, 2)]
        [TestCase(new[] { 4, 2, 3, 5, -230 }, 3)]
        public void GetMaxIndex(int[] numbers, int expected)
        {
            int actual = Arrays.GetMaxIndex(numbers);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3 }, new[] { 3, 2, 1 })]
        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 4, 3, 2, 1 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 5, 4, 3, 2, 1 })]
        public void ReverseArray(int[] numbers, int[] expected)
        {
            int[] actual = Arrays.ReverseArray(numbers);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 4, 2, 3, 5, 7 }, 3)]
        [TestCase(new[] { -1, 0, 3, 2, 3 }, 3)]
        [TestCase(new[] { 4, 2, 3, 5, -230 }, 2)]

        public void CountOddElements(int[] numbers, int expected)
        {
            int actual = Arrays.CountOddElements(numbers);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new[] { 1, 2, 3 }, new[] { 3, 2, 1 })]
        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 3, 4, 1, 2 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 4, 5, 3, 1, 2 })]
        public void SwapHalves(int[] numbers, int[] expected)
        {
            int[] actual = Arrays.SwapHalves(numbers);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 4, 2, 3, 5, 7 }, new[] { 2, 3, 4, 5, 7})]
        [TestCase(new[] { -1, 0, 3, 2, 3 }, new[] { -1, 0, 2, 3, 3 })]
        [TestCase(new[] { 4, 2, 3, 5, -230 }, new[] {-230, 2, 3, 4, 5 })]
        static public void SelectSortAscending(int[] numbers, int[] expected)
        {
            int[] actual = Arrays.SelectSortAscending(numbers);
            Assert.AreEqual(expected, actual);
        }
        
        
        [TestCase(new[] { 4, 2, 3, 5, 7 }, new[] { 7, 5, 4, 3, 2 })]
        [TestCase(new[] { -1, 0, 3, 2, 3 }, new[] { 3, 3 ,2, 0, -1 })]
        [TestCase(new[] { 4, 2, 3, 5, -230 }, new[] {5, 4, 3, 2, -230})]
        static public void InsertSortDescending(int[] numbers, int[] expected)
        {
            int[] actual = Arrays.InsertSortDescending(numbers);
            Assert.AreEqual(expected, actual);
        }

    }
}
