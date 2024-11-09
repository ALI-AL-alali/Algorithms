using System;

namespace LinearSearch_Generics
{
    class Linear_Search<T>
    {
        T[] array;

        public Linear_Search() { }

        public Linear_Search(int index)
        {
            array = new T[index];
        }

        public void Input(T[] arr)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = arr[i];
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

        public int Search(T val)
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.array[i].Equals(val))
                {
                    return i;
                }
            }
            return -1;
        }

        public int SearchRec(T val, int i)
        {
            if (array.Length == i)
            {
                return -1;
            }
            if (array[i].Equals(val))
            {
                return i;
            }
            return SearchRec(val, i + 1);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Length of Array: ");
            int length = int.Parse(Console.ReadLine());

            Linear_Search<string> search = new Linear_Search<string>(length);
            string[] array = new string[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter The String: ");
                array[i] = Console.ReadLine();
            }

            search.Input(array);
            search.Print();

            Console.Write("Enter The String you want to search for: ");
            string str = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("The value you are looking for is in the Location: " + search.Search(str));
            Console.WriteLine("The value you are looking for is in the Recursion : " + search.SearchRec(str, 0));
        }
    }
}
