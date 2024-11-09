using System;
using System.Diagnostics;

namespace Fatorial
{
    class Factorial
    {
        public long Factorial_I(int num)
        {
            long res = 1;
            for(int i = num ; i >= 2; i--)
            {
                res *= i;
            }
            return res;
        }
        public long Factorial_R(int num) 
        {
            if (num < 2) return 1;

            return num * Factorial_R(num - 1);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Factorial factorial = new Factorial();
            int n;
            do
            {
                Console.Write("Enter The Number :\n1.Factorial_I\n2.Factorial_R\n3.Exit\n==> ");
                n = int.Parse(Console.ReadLine());
                int num;
                switch (n)
                {
                    case 1:
                        Console.Write("Enter The Number Factorial : ");
                         num = int.Parse(Console.ReadLine());
                        var watch1 = new Stopwatch();
                        watch1.Start();
                        Console.WriteLine(num + "! = " + factorial.Factorial_I(num));
                        watch1.Stop();
                        Console.WriteLine(watch1.Elapsed);
                        break;
                    case 2:
                        Console.Write("Enter The Number Factorial : ");
                        num = int.Parse(Console.ReadLine());
                        var watch2 = new Stopwatch();
                        watch2.Start();
                        Console.WriteLine(num + "! = "+ factorial.Factorial_R(num));
                        watch2.Stop();
                        Console.WriteLine(watch2.Elapsed);
                        break;
                }
                Console.WriteLine("=============================");
            } while (n <= 2);
        }
    }
}
