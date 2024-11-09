using System;

namespace Insert_Sorting
{
    internal class Program
    {
        public static void Insert_Sorting1()
        {
            int[] array = { 5, 8, -1, 13, -2, 5 };
            Console.WriteLine("===================== Insert_Sorting 1 =====================");

            for (int i = 1; i < array.Length; i++) 
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key) 
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;

                Console.WriteLine("The Cycle " + i);
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
            Insert_Sorting1();
        }
    }
}
