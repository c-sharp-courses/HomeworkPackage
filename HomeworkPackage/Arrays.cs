using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPackage
{
    static public class Arrays
    {
        // Creating a random array of ints in a certain range
        static public int[] CreateRandomArray(int Length, int lowerLimit = 0, int upperLimit = 100)
        {
            Random random = new Random();
            int[] result = new int[Length];

            for (int i = 0; i < Length; i++)
            {
                result[i] = random.Next(lowerLimit, upperLimit);
            }
            return result;
        }

        static public int[] CopyArray(int[] numbers)
        {
            int[] result = new int[numbers.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = numbers[i];
            }
            return result;
        }

        // Вывод массива:
        static public void Print(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + "\t");
            }
            Console.WriteLine();
        }


        // Найти минимальный элемент массива

        static public int GetMin(int[] numbers)
        {
            int min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        // Найти максимальный элемент массива

        static public int GetMax(int[] numbers)
        {
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        //Найти индекс минимального элемента массива
        static public int GetMinIndex(int[] numbers)
        {
            int index_min = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[index_min])
                {
                    index_min = i;
                }
            }
            return index_min;
        }

        // Найти индекс минимального элемента массива
        static public int GetMaxIndex(int[] numbers)
        {
            int index_max = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[index_max])
                {
                    index_max = i;
                }
            }
            return index_max;
        }

        // Посчитать сумму элементов массива с нечетными индексами

        static public int GetOddIndexSum(int[] numbers)
        {
            int sum = 0;

            for (int i = 1; i < numbers.Length; i += 2)
            {
                sum += numbers[i];
            }

            return sum;
        }

        // Сделать реверс массива(массив в обратном направлении)

        static public int[] ReverseArray(int[] numbers)
        {
            int length = numbers.Length;
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = numbers[length - i - 1];
            }
            return result;
        }

        // Посчитать количество нечетных элементов массива

        static public int CountOddElements(int[] numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }


        // Поменять местами первую и вторую половину массива, например, 
        // для массива 1 2 3 4,  результат 3 4 1 2,  или для 12345 - 45312.
        static public int[] SwapHalves(int[] numbers)
        {
            int length = numbers.Length;
            int halfLength = (length + 1) / 2;
            int[] result = new int[length];

            for (int i = 0; i < length - halfLength; i++)
            {
                result[i] = numbers[i + halfLength];
                result[i + halfLength] = numbers[i];
            }

            if (length % 2 != 0)
                result[length / 2] = numbers[length / 2];

            return result;
        }
        // сортировка выбором по возрастанию
        static public int[] SelectSortAscending(int[] numbers)
        {
            int[] result = CopyArray(numbers);

            int min_index;
            int temp;

            for (int i = 0; i < result.Length - 1; i++)
            {
                min_index = i;

                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[j] < result[min_index])
                    {
                        min_index = j;
                    }
                }

                temp = result[min_index];
                result[min_index] = result[i];
                result[i] = temp;
            }

            return result;
        }

        // сортировка вставками по убыванию 
        static public int[] InsertSortDescending(int[] numbers)
        {
            int[] result = CopyArray(numbers);

            int temp;

            for (int i = 1; i < result.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (result[j - 1] < result[j])
                    {
                        // swapping elements
                        temp = result[j];
                        result[j] = result[j - 1];
                        result[j - 1] = temp;
                    }
                }
            }

            return result;
        }
    }
}
