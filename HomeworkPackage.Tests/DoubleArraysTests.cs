using NUnit.Framework;
using HomeworkPackage;
using HomeworkPackage.HomeworkPackage;
using System;

namespace HomeworkPackage.Tests
{
    public class DoubleArraysTests
    {

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        public void TestTranspose(int aNumb, int expNumb)
        {
            int[,] expected = GetExpectedTransposeMock(expNumb);

            int[,] a = GetArrayMock(aNumb);
            int[,] actual = DoubleArrays.Transpose(a);


            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 1)]
        public void TestGetMin(int aNumb, int expected)
        {
            int[,] a = GetArrayMock(aNumb);
            int actual = DoubleArrays.GetMin(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 9)]
        [TestCase(2, 6)]
        [TestCase(3, 4)]
        public void TestGetMax(int aNumb, int expected)
        {
            int[,] a = GetArrayMock(aNumb);
            int actual = DoubleArrays.GetMax(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] {0, 0})]
        [TestCase(2, new int[] {0, 0})]
        [TestCase(3, new int[] {0, 0})]
        public void TestGetMinIndex(int aNumb, int[] expected)
        {
            int[,] a = GetArrayMock(aNumb);
            int[] actual = DoubleArrays.GetMinIndex(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] {2, 2})]
        [TestCase(2, new int[] {1, 2})]
        [TestCase(3, new int[] {0, 3})]
        public void TestGetMaxIndex(int aNumb, int[] expected)
        {
            int[,] a = GetArrayMock(aNumb);
            int[] actual = DoubleArrays.GetMaxIndex(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(4, 5)]
        public void TestCountHighestElements(int aNumb, int expected)
        {
            int[,] a = GetArrayMock(aNumb);
            int actual = DoubleArrays.CountHighestElements(a);

            Assert.AreEqual(expected, actual);
        }

        int[,] GetArrayMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new int[,]
                    {
                        {1,2,3},
                        {4,5,6},
                        {7,8,9}
                    };
                case 2:
                    return new int[,]
                    {
                        {1, 2, 3 },
                        {4, 5, 6 }
                    };
                case 3:
                    return new int[,]
                    {
                        {1, 2, 3, 4}
                    };
                case 4:
                    return new int[,]
                    {
                        {1, 0, 0, 7},
                        {0, 1, 0, 0 },
                        {0, 0, 1, 0 },
                        {7, 0, 6, 1 }
                    };

                default:
                    throw new Exception();
            }
        }

        int[,] GetExpectedTransposeMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new int[,]
                    {
                        {1,4,7},
                        {2,5,8},
                        {3,6,9}
                    };
                case 2:
                    return new int[,]
                    {
                        {1, 4 },
                        {2, 5 },
                        {3, 6 }
                    };
                case 3:
                    return new int[,]
                    {
                        {1 },
                        {2 },
                        {3 },
                        {4 }
                    };          
                default:
                    throw new Exception();
            }
        } 
        
       

    }
}
