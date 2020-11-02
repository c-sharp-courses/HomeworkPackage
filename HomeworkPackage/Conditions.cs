using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPackage
{
    static public class Conditions
    { // Пользователь вводит 2 числа(A и B).
      // Если A > B, подсчитать A+B, если A = B, подсчитать A* B, если A < B, подсчитать A-B.

        static public int GetSomeStupidResult(int a, int b)
        {
            switch (Math.Sign(a - b))
            {
                case 0:
                    return a * b;
                case 1:
                    return a + b;
                default:
                    return a - b;
            }
        }


        // Пользователь вводит 2 числа(X и Y).Определить какой четверти принадлежит точка с координатами(X, Y).

        static public int[] DetermineQuarter(double x, double y)
        {
            int signX = Math.Sign(x);
            int signY = Math.Sign(y);

            switch (signX + signY)
            {
                case 2:
                    return new int[1] {1};
                case -2:
                    return new int[1] {3};
                case 1:
                    if (signY > 0)
                        return new int[2] {1, 2};
                    else
                        return new int[2] { 1, 4 };
                case -1:
                    if (signX < 0)
                        return new int[2] { 2, 3 };
                    else
                        return new int[2] { 3, 4 };
                default: //0
                    switch (signX - signY)
                    {
                        case -2:
                            return new int[1] { 2 };
                        case 2:
                            return new int[1] { 4 };
                        default: //x=y=0
                            return new int[4] {1,2,3,4};
                    }
            }
        }

        // Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X) 
        // квадратного уравнения стандартного вида, где AX2+BX+C=0.

        static public double[] SolveQuadraticEquation(double a, double b, double c)
        {

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        throw new Exception("Division by 0: any number is a solution");
                    }
                    else
                    {
                        throw new Exception("Division by 0: no solution found");
                    }
                }
                else
                {
                    return new double[1] { -c / b };
                }
            }
            else
            {
                double discriminant = b * b - 4 * a * c;
                switch (Math.Sign(discriminant))
                {
                    case -1:
                        throw new Exception("Negative discriminant: no solution found");
                    case 1:
                        double x1 = (-b - Math.Sqrt(discriminant)) / 2 / a;
                        double x2 = (-b + Math.Sqrt(discriminant)) / 2 / a;
                        return new double[2] { x1, x2 };
                    default: // 0
                        return new double[1] { -b / 2 / a };
                }
            }
        }

        //Пользователь вводит двузначное число. 
        //Выведите в консоль прописную запись этого числа. 
        //Например при вводе “25” в консоль будет выведено “двадцать пять”.

        static public string ConvertNumberToString(int number)
        {
            int firstDigit = number / 10;
            int secondDigit = number % 10;
            bool teenFlag = false;

            string result = "";

            if (number >= 100)
            {
                throw new Exception("Please provide a two-digit number");
            }

            switch (firstDigit)
            {
                case 1:
                    teenFlag = true;
                    switch (secondDigit)
                    {
                        case 0:
                            result = "десять";
                            break;
                        case 1:
                            result = "одиннадцать";
                            break;
                        case 2:
                            result = "двенадцать";
                            break;
                        case 3:
                            result = "тринадцать";
                            break;
                        case 4:
                            result = "четырнадцать";
                            break;
                        case 5:
                            result = "пятнадцать";
                            break;
                        case 6:
                            result = "шестнадцать";
                            break;
                        case 7:
                            result = "семнадцать";
                            break;
                        case 8:
                            result = "восемнадцать";
                            break;
                        case 9:
                            result = "девятнадцать";
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    result = "двадцать ";
                    break;
                case 3:
                    result = "тридцать ";
                    break;
                case 4:
                    result = "сорок ";
                    break;
                case 5:
                    result = "пятьдесят ";
                    break;
                case 6:
                    result = "шестьдесят ";
                    break;
                case 7:
                    result = "семьдесят ";
                    break;
                case 8:
                    result = "восемьдесят ";
                    break;
                case 9:
                    result = "девяносто ";
                    break;
                default: //0
                    break;

            }

            if (!teenFlag)
            {
                switch (secondDigit)
                {
                    case 0:
                        break;
                    case 1:
                        result += "один";
                        break;
                    case 2:
                        result += "два";
                        break;
                    case 3:
                        result += "три";
                        break;
                    case 4:
                        result += "четыре";
                        break;
                    case 5:
                        result += "пять";
                        break;
                    case 6:
                        result += "шесть";
                        break;
                    case 7:
                        result += "семь";
                        break;
                    case 8:
                        result += "восемь";
                        break;
                    default: //9
                        result += "девять";
                        break;
                }
            }

            return result;
        }

    }
}
