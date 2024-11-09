using System;

namespace Linear_Search
{
    class Linear_Search
    {
        int[] array;
        public Linear_Search() { }
        public Linear_Search(int index)
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
                Console.Write( array[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public int Search(int val)
        {
            if (true)
            {
                for (int i = 0; i < this.array.Length; i++)
                {
                    if (this.array[i] == val)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        public int SearchRec(int val,int i)
        {
            if(array.Length == i)
            {
                return -1;
            }
            if(array[i] == val)
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
            Console.Write("Enter The Length Array : ");
            int length = int.Parse(Console.ReadLine());
            Linear_Search Search = new Linear_Search(length);
            Search.Fill();
            Search.Print();
            Console.Write("Enter The Number you want : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("The value you are looking for is in the location : " + Search.Search(num));
            Console.WriteLine("The value you are looking for is in the location : " + Search.SearchRec(num,0));

        }
    }
}
