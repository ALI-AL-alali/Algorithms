using System;

class Program
{
    static void Hanoi_R(int n, char A, char C, char B)
    {
        if (n > 0)
        {
            Hanoi_R(n - 1, A, B, C);

            Console.WriteLine("Move disk "+ n + " from " + A + " to " + C);

            Hanoi_R(n - 1, B, C, A);
        }
    }
    static void Hanoi_I(int n, char A, char C, char B)
    {

        for (int i = 1; i <= (n * n) - 1; i++) 
        {

        }
    }
    static void Main()
    {
        int n = 3;
        Hanoi_R(n, 'A', 'C', 'B');
    }

}
