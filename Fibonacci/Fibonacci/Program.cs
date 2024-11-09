using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Fibonacci
{
    class Fibonation
    {
        public long Fib_I(int a)
        {
            if (a <= 1) return a;
            long num1 = 0, num2 = 1, num3 = 0;
            for (int i = 2; i <= a; i++)
            {
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
            }
            return num3;
        }
        public long Fib_R(int a)
        {
            if (a <= 1) { return a; }
            else { return Fib_R(a - 1) + Fib_R(a - 2); }
        }
    }
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Fibonation fibonation = new Fibonation();
            int n;
            do
            {
                Console.Write("Enter The Number :\n1.Fibonation_I\n2.Fibonation_R\n3.Exit\n==> ");
                n = int.Parse(Console.ReadLine());
                int num;
                switch (n)
                {
                    case 1:
                        Console.Write("Enter The Number Fibonation : ");
                        num = int.Parse(Console.ReadLine());
                        var watch1 = new Stopwatch();
                        watch1.Start();
                        Console.WriteLine("Fibonation = " + fibonation.Fib_I(num));
                        watch1.Stop();
                        Console.WriteLine(watch1.Elapsed);
                        break;
                    case 2:
                        Console.Write("Enter The Number Fibonation : ");
                        num = int.Parse(Console.ReadLine());
                        var watch2 = new Stopwatch();
                        watch2.Start();
                        Console.WriteLine("Fibonation = " + fibonation.Fib_R(num));
                        watch2.Stop();
                        Console.WriteLine(watch2.Elapsed);
                        break;
                }
                Console.WriteLine("=============================");
            } while (n <= 2);


        }
    }
}
