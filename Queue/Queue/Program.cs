using System;
using Queue;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<< HELLO >>>");
            Queue queue = new Queue();
            int x;
            do
            {
                Console.Write("Enter The Number : \n" +
                    "1.Add Node in The Queue\n" +
                    "2.Remove[Delete] Node in The Queue\n" +
                    "3.Print Queue\n" +
                    "4.EXIT\n" +
                    "==> ");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.WriteLine("============{ Add In Queue }============");
                        Node node = new Node();
                        Console.Write("Enter The Number : ");
                        int num = int.Parse(Console.ReadLine());
                        node.Data = num;
                        queue.EnQueue(node);
                        Console.WriteLine("=========================================");
                        break;
                    case 2:
                        Console.WriteLine("==========={ Remove In Queue }===========");
                        Console.WriteLine($"The Number Has Deleted {queue.First.Data}");
                        queue.DeQueue();
                        Console.WriteLine("=========================================");
                        break;
                    case 3:
                        Console.WriteLine("==========={ Print Data Queue }==========");
                        queue.Print();
                        Console.WriteLine("=========================================");
                        break;
                }
            } while (x < 4);
        }
    }
}
