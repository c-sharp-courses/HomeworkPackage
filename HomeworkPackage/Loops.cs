using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPackage
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace HomeworkPackage
    {
        static public class Loops
        {
            // Пользователь вводит 2 числа (A и B). Возвести число A в степень B.
            static public double RaiseToPow(double basis, int index)
            {
                double result = 1;

                if (basis == 0 && index == 0)
                    throw new Exception("Cannot calculate 0^0");

                while (index > 0)
                {
                    result *= basis;
                    index--;
                }

                while (index < 0)
                {
                    result /= basis;
                    index++;
                }

                return result;
            }

            // Пользователь вводит число (A). Вывести все числа от 1 до 1000, которые делятся на A.
            static public int[] GetArrayOfMultiples(int number, int upperLimit = 1000)
            {
                int[] result = new int[(upperLimit-1) / number];
                int index = 0;
                for (int i = number; i < upperLimit; i++)
                {
                    if (i % number == 0)
                    {
                        result[index] = i;
                        index++;
                    }
                }
                return result;
            }

            // Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.

            static public int GetIntSqrt(int number)
            {
                int count = 1;
                if(number <= 0)
                {
                    throw new Exception("Number must be positive");
                }
                while (count * count < number)
                {
                    count++;
                }
                return count - 1;
            }


            // Пользователь вводит 1 число(A). Вывести наибольший делитель(кроме самого A) числа A.
            static public int GetGreatestDivisor(int number)
            {
                int i = 2;
                while (number % i != 0)
                    i++;

                return Math.Abs(number / i);
            }

            // Пользователь вводит 1 число (N).Выведите N - ое число ряда фибоначчи.
            // В ряду фибоначчи каждое следующее число является суммой двух предыдущих. 
            // Первое и второе считаются равными 1.

            static public int GetFibbonacci(int index)
            {
                int previousTerm = 1;
                int nextTerm = 1;
                int temp;

                for (int i = 1; i < index - 1; i++)
                {
                    temp = nextTerm;
                    nextTerm = temp + previousTerm;
                    previousTerm = temp;
                }
                return nextTerm;
            }


            //Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.

            static public int GetGreatestCommonDivisor(int A, int B)
            {
                int a = Math.Max(Math.Abs(A), Math.Abs(B));
                int b = Math.Min(Math.Abs(A), Math.Abs(B));
                int temp;

                while (b > 0)
                {
                    temp = b;
                    b = a % b; 
                    a = temp;  
                }

                return a;
            }

            // Пользователь вводит целое положительное число, которое является кубом числа N.
            // Найдите число N методом половинного деления. 
            static public int GetCubicRoot(int cube)  // argument supposed to be a perfect cube
            {
                int a = 0;
                int b = cube;
                int complexity = (int)Math.Log2(cube) + 1;


                while (((a + b) / 2) * ((a + b) / 2) * ((a + b) / 2) != cube)
                {
                    if (((a + b) / 2) * ((a + b) / 2) * ((a + b) / 2) > cube)
                    {
                        b = (a + b) / 2;
                    }
                    else
                    {
                        a = (a + b) / 2;
                    }
                    complexity--;
                    if (complexity < 0)
                        throw new Exception("Input should be a perfect cube");
                }
                return (a + b) / 2;
            }


            // Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
            static public int GetOddDigitsCount(int number)
            {
                int oddDigitsCount = 0;

                while (number > 0)
                {
                    if (number % 2 != 0)
                    {
                        oddDigitsCount++;
                    }
                    number /= 10;
                }

                return oddDigitsCount;
            }

            // Пользователь вводит 1 число. Найти число, которое является зеркальным отображением
            // последовательности цифр заданного числа, например, задано число 123, вывести 321
            static public int Reverse(int number)
            {
                int result = 0;
                
                while (number > 0)
                {
                    result += number % 10;
                    number /= 10;
                    result *= 10;
                }
                result /= 10;

                return result;
            }


            // Пользователь вводит целое положительное  число(N).
            // Выведите количество чисел в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных. 

            static public int SumOddDigits(int number)
            {
                int x = number;
                int result = 0;
                while (x > 0)
                {
                    if (x % 2 != 0)
                    {
                        result += x % 10;
                    }
                    x /= 10;
                }
                return result;
            }


            static public int SumEvenDigits(int number)
            {
                int x = number;
                int result = 0;
                while (x > 0)
                {
                    if (x % 2 == 0)
                    {
                        result += x % 10;
                    }
                    x /= 10;
                }
                return result;
            }

            static public int CountEvenerNumbersInRange(int upperLimit)
            {
                int count = 0;

                for (int number = 1; number <= upperLimit; number++)
                {
                    if (SumEvenDigits(number) > SumOddDigits(number))
                        count++;
                }
                return count;
            }
        }


    }

}
