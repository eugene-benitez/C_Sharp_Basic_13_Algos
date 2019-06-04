using System;
using System.Collections.Generic;

namespace Basic_13_C_
{
    class Program
    {

        // public static void PrintNumbers(int num = 255)
        // {
        //     for (int a = 0; a <= num; a++)
        //     {
        //         Console.WriteLine(a);
        //     }
        // }

        // public static void PrintOdds(int num = 255)
        // {
        //     for (int b = 0; b <= num; b++)
        //     {
        //         if (b % 2 != 0)
        //         {
        //             Console.WriteLine(b);
        //         }
        //     }
        // }

        // public static void PrintSum(int num = 10)
        // {
        //     int sum = 0;
        //     for (int c = 0; c <= num; c++)
        //     {
        //         Console.WriteLine(c);
        //         sum += c;
        //         Console.WriteLine(sum);
        //     }

        // }

        // public static void LoopArray(int[] numbers)
        // {
        //     for (int d = 0; d < numbers.Length; d++)
        //     {
        //         Console.WriteLine(numbers[d]);
        //     }
        // }

        // public static int FindMax(int[] numbers)
        // {
        //     int max = numbers[0];
        //     for (int e = 1; e < numbers.Length; e++)
        //     {
        //         if (numbers[e] > max)
        //         {
        //             max = numbers[e];
        //         }
        //     }
        //     Console.WriteLine(max);
        //     return max;
        // }

        // public static void GetAverage(int[] numbers)
        // {
        //     int sum = 0;
        //     int avg = 0;
        //     for (int f = 0; f < numbers.Length; f++)
        //     {
        //         sum = numbers[f] + sum;
        //     }
        //     avg = sum / numbers.Length;
        //     Console.WriteLine(avg);
        // }

        public static int[] OddArray(int num = 10)
        {
            int[] odd = new int[255];
            int n = 0;
            for (int g = 0; g <= num; g++)
            {
                if (g % 2 != 0)
                {
                    odd[n] = g;
                    n += 1;
                    System.Console.WriteLine(g);
                }
            }
            return odd;
        }


        // public static int GreaterThanY(int[] numbers, int y)
        // {
        //     int greater = 0;
        //     foreach (int i in numbers)
        //     {
        //         if (i > y)
        //         {
        //             greater += 1;
        //         }
        //     }
        //     System.Console.WriteLine(greater);
        //     return greater;
        // }


        // public static void SquareArrayValues(int[] numbers)
        // {
        //     for (int n = 0; n < numbers.Length; n++)
        //     {
        //         numbers[n] = numbers[n] * numbers[n];
        //         System.Console.WriteLine(numbers[n]);
        //     }
        //     return;
        // }

        // public static void EliminateNegatives(int[] numbers)
        // {
        //     for (int w = 0; w < numbers.Length; w++)
        //     {
        //         if (numbers[w] < 0)
        //         {
        //             numbers[w] = numbers[w] * 0;
        //         }
        //         System.Console.WriteLine(numbers[w]);
        //     }
        //     return;
        // }


        public static void MinMaxAverage(int[] numbers)
        {
            int max = numbers[0];
            int min = numbers[0];
            double avg = numbers[0];
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                sum += numbers[i];
            }
            System.Console.WriteLine("Minimum is: " + min);
            System.Console.WriteLine("Maximum is: " + max);
            avg = sum / numbers.Length;
            System.Console.WriteLine("Average is: " + avg);
        }

        // public static void ShiftValues(int[] numbers)
        // {
        //     for (int i = 0; i < numbers.Length; i++)
        //     {
        //         if (i == numbers.Length - 1)
        //         {
        //             numbers[i] = 0;
        //             System.Console.WriteLine(numbers[i]);
        //         }
        //         else
        //         {
        //             numbers[i] = numbers[i + 1];
        //             System.Console.WriteLine(numbers[i]);
        //         }
        //     }
        // }


        public static object[] NumToString(int[] numbers)
        {
            object[] array = new object[numbers.Length];
            for (int a = 0; a < numbers.Length; a++)
            {
                if (numbers[a] < 0)
                {
                    array[a] = "Dojo";
                    System.Console.WriteLine(array[a]);
                }

                else
                {
                    array[a] = numbers[a];
                    System.Console.WriteLine(array[a]);
                }
            }
            return array;
        }


        public static void Main(string[] args)
        {
            int[] arr;
            arr = new int[] { -1, -3, 2 };
            // Console.WriteLine("1 TO 255");
            // PrintNumbers();
            // Console.WriteLine("ODDS 1 TO 255");
            // PrintOdds();
            // Console.WriteLine("PRINT SUM");
            // PrintSum();
            // Console.WriteLine("ITERATE THROUGH ARRAY");
            // LoopArray(arr);
            // Console.WriteLine("FIND MAX");
            // FindMax(arr);
            // Console.WriteLine("FIND AVERAGE");
            // GetAverage(arr);
            Console.WriteLine("OddArray");
            OddArray();
            // Console.WriteLine("GREATER THAN Y");
            // GreaterThanY(arr, 1);
            // Console.WriteLine("Square Array Values");
            // SquareArrayValues(arr);
            // Console.WriteLine("Eliminate Negatives");
            // EliminateNegatives(arr);
            // Console.WriteLine("Min Max Average");
            // MinMaxAverage(arr);
            // Console.WriteLine("Shifting Values in an Array");
            // ShiftValues(arr);
            // Console.WriteLine("Number to String");
            // NumToString(arr);


        }
    }
}