using System;

namespace Binary_Search
{
    class Binary_Search
    {
        int[] array;
        public Binary_Search() { }
        public Binary_Search(int index)
        {
            array = new int[index];
        }
        public void Fill()
        {
            Random random = new Random();
            for (int i = 0; i < this.array.Length; i++)
            {
                this.array[i] = random.Next(0, 100);
            }
        }
        public void Print()
        {
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public void Electoral_Sorting()
        {
            int temp = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int ii = i + 1; ii < array.Length; ii++)
                {
                    if (array[min] > array[ii])
                    {
                        min = ii;
                    }
                }
                if (min != i)
                {
                    temp = array[min];
                    array[min] = array[i];
                    array[i] = temp;
                }
            }

        }
        public int Search(int val)
        {
            int start = 0, end = array.Length;
            while (start <= end)
            {
                int med = (start + end) / 2;
                if (val == array[med])
                {
                    return med;
                }
                else if (val > array[med])
                {
                    start = med + 1;
                }
                else
                {
                    end = med - 1;
                }
            }
            return -1;
        }
        public int Search(int val, int start, int end)
        {
            if (start <= end)
            {
                int med = (start + end) / 2;
                if (val == array[med])
                {
                    return med;
                }
                else if (val > array[med])
                {
                    return Search(val, med + 1, end);
                }
                return Search(val, start, med - 1);
            }
            return -1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Length Array : ");
            int length = int.Parse(Console.ReadLine());
            Binary_Search Search = new Binary_Search(length);
            Search.Fill();
            Search.Electoral_Sorting();
            Search.Print();
            Console.Write("Enter The Number you want : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("The value you are looking for is in the location Search_Recursion : " + Search.Search(num, 0, length - 1));
            Console.WriteLine();
            Console.WriteLine("The value you are looking for is in the location Search_Iteration : " + Search.Search(num));

        }
    }
}