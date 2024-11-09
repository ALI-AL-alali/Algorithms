using System;
using System.Diagnostics;
namespace Bubble_sorting
{                                          /// الفرز الفقاعي
    internal class Program
    {
        public static void Bubble_sorting1()
        {
            int[] array = { 5, 8, -1, 13, -2, 5 };
            Console.WriteLine("===================== Electoral_Sorting 1 =====================");

            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.WriteLine("The Cycle " + (i + 1));
                for (int j = 1; j < array.Length - i; j++)
                {
                    if (array[j] < array[j - 1])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                    for (int k = 0; k < array.Length; k++)
                    {
                        Console.Write(array[k] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("====================");
            }

        }
        public static void Bubble_sorting2()
        {
            int[] array = { 5, 8, -1, 13, -2, 5 };
            Console.WriteLine("===================== Electoral_Sorting 2 =====================");

            for (int i = 0;i < array.Length - 1; i++)
            {
                Console.WriteLine("The Cycle " + (i + 1));
                int min = i;
                for (int j = 1;j < array.Length - i; j++)
                {
                    if(array[j] < array[min])
                    {
                        min = j;
                    }
                if (min != i)
                {
                    int temp = array[j - 1];
                    array[j - 1] = array[min];
                    array[min] = temp;
                }
                }
                for (int k = 0; k < array.Length; k++)
                {
                    Console.Write(array[k] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine("====================");
            }
        }
        static void Main(string[] args)
        {
            Bubble_sorting1();
            Bubble_sorting2();
        }
    }
}
