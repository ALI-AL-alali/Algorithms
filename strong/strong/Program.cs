using System;
using System.Security.Claims;

namespace strong
{
    class ElectoralSorting
    {
        int[] sortArray;
        public int SortArray { set; get; }
        public ElectoralSorting() { }
        public ElectoralSorting(int index)
        {
            sortArray = new int[index];
        }


        public void Fill()
        {
            Random random = new Random();
            for (int i = 0; i < this.sortArray.Length; i++)
            {
                this.sortArray[i] = random.Next(0, 100);
            }

        }
        public void Print()
        {
            Console.WriteLine();
            for (int i = 0; i < sortArray.Length; i++)
            {
                Console.Write(sortArray[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public void SelectionStrong()
        {
            int temp = 0;
            for (int i = 0; i < sortArray.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < sortArray.Length; j++)
                {
                    if (sortArray[min] > sortArray[j])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    temp = sortArray[min];
                    sortArray[min] = sortArray[i];
                    sortArray[i] = temp;
                }
            }
        }
        public void SelectionStrongRec()
        { 
            for (int i = 0; i < sortArray.Length - 1; i++)
            {
                int min = i;
                SeartchMin(i, min);
            }
        }
        public int SeartchMin(int i, int min)
        {
            int temp = 0;

            if (i >= sortArray.Length)
            {
                return i;
            }
            if (sortArray[i] < sortArray[min])
            {
                min = i;
            }
            return SeartchMin(i + 1, min);
        }
    }
    internal class Program
    {
            static void Main(string[] args)
            {
                Console.Write("Enter The Leingth Array : ");
                int index = int.Parse(Console.ReadLine());
                ElectoralSorting Sorting = new ElectoralSorting(index);
                Sorting.Fill();
                Sorting.Print();
                Console.WriteLine("=============================={ Strong Iterative }==============================");
                Sorting.SelectionStrong();
                Sorting.Print();
                Console.WriteLine("=============================={ Strong Recursive }==============================");
                Sorting.SelectionStrongRec();
                Sorting.Print();

            }    
    }
}