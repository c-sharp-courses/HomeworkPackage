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
        static public class DoubleArrays
        {

            // Найти минимальный элемент массива
            static public int[,] CreateRandomTable(int rows, int columns, int upperLimit = 100)
            {
                int[,] table = new int[rows, columns];
                Random random = new Random();

                for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                    {
                        table[i, j] = random.Next(100);
                    }
                }
                return table;
            }

            static public void Print(int[,] table)
            {
                for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                    {
                        Console.Write(table[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            static public int GetMin(int[,] table)
            {
                int min = table[0, 0];

                for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                    {
                        if (min > table[i, j])
                        {
                            min = table[i, j];
                        }
                    }
                }
                return min;
            }
            static public int GetMax(int[,] table)
            {
                int max = table[0, 0];

                for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                    {
                        if (max < table[i, j])
                        {
                            max = table[i, j];
                        }
                    }
                }
                return max;
            }

            static public int[] GetMinIndex(int[,] table)
            {
                int[] result = new int[2];

                int rowMinIndex = 0;
                int columnMinIndex = 0;

                for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                    {
                        if (table[rowMinIndex, columnMinIndex] > table[i, j])
                        {
                            rowMinIndex = i;
                            columnMinIndex = j;
                        }
                    }
                }
                result[0] = rowMinIndex;
                result[1] = columnMinIndex;
                return result;
            }
            static public int[] GetMaxIndex(int[,] table)
            {
                int[] result = new int[2];

                int rowMaxIndex = 0;
                int columnMaxIndex = 0;

                for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                    {
                        if (table[rowMaxIndex, columnMaxIndex] < table[i, j])
                        {
                            rowMaxIndex = i;
                            columnMaxIndex = j;
                        }
                    }
                }
                result[0] = rowMaxIndex;
                result[1] = columnMaxIndex;
                return result;
            }

            //найти горки 
            static public int CountHighestElements(int[,] table)
            {
                int counter = 0;
                for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                    {
                        if ((i == 0 || table[i - 1, j] <= table[i, j]) &&
                           (j == 0 || table[i, j - 1] <= table[i, j]) &&
                           (i == table.GetLength(0) - 1 || table[i + 1, j] <= table[i, j]) &&
                           (j == table.GetLength(1) - 1 || table[i, j + 1] <= table[i, j]))
                        {
                            counter++;
                        }

                    }
                }
                return counter;
            }

            static public int[,] Transpose(int[,] table)
            {
                int rows = table.GetLength(0);
                int columns = table.GetLength(1);

                int[,] transposedTable = new int[columns, rows];

                for (int i = 0; i < table.GetLength(1); i++)
                {
                    for (int j = 0; j < table.GetLength(0); j++)
                    {
                        transposedTable[i, j] = table[j, i];
                    }
                }
                return transposedTable;
            }


        }
    }

}
