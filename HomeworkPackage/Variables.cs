using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPackage
{
    using System;
    using System.ComponentModel.Design.Serialization;

    namespace HomeworkPackage
    {

        static public class Variables
        {

            // Пользователь вводит 2 числа (A и B). Выведите в консоль решение 5*A+B^2 / (B-A)
            static public double CalculateStrangeFormula(double a, double b)
            {
                if (a == b)
                {
                    throw new Exception("Divide by 0 error");
                }
                return (5 * a + b * b) / (b - a);
            }

            // Пользователь вводит 2 числа (A и B). Поменяйте 
            // содержимое переменных A и B местами.

            static public void Swap(ref double a, ref double b)
            {
                double temp = a;
                a = b;
                b = temp;
            }

            //Пользователь вводит 3 числа (A, B и С). 
            //Выведите в консоль решение(значение X) линейного уравнения стандартного вида 
            //A*X+B=C.

            static public double SolveLinearEquation(double a, double b, double c)
            {
                if (a == 0)
                {
                    if (c - b == 0)
                    {
                        throw new Exception("Solution undetermined: 0 divided by 0 exception");
                    }
                    else
                    {
                        throw new Exception("Solution not found: divided by 0 exception");
                    }
                }
                else
                {
                    return (c - b) / a;
                }
            }

            // Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие 
            // координаты 2-х точек на координатной плоскости. Выведите 
            // уравнение прямой в формате Y=B+AX, проходящей через эти точки.
            // B= result[0], A=result[1]

            static public double[] FindLineCoeffientsByPoints(double x1, double y1, double x2, double y2)
            {
                double[] result = new double[2];

                if (x1 == x2)
                {
                    throw new Exception("This line cannot be determined by an equation y=Ax+B. x1 cannot be equal to x2");
                }
                else
                {
                    double a = (y2 - y1) / (x2 - x1);
                    double b = -a * x1 + y1;

                    result[0] = b;
                    result[1] = a;
                }
                return result;
            }

        }
    }

}
