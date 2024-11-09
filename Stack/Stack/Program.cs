using System;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<< HELLO >>>");
            Stack stack = new Stack();
            int x;
            do
            {
                Console.Write("Enter The Number : \n" +
                    "1.Add Node in The Stack\n" +
                    "2.Remove[Delete] Node in The Stack\n" +
                    "3.Print Stack\n" +
                    "4.EXIT\n" +
                    "==>");
                x = int.Parse(Console.ReadLine());
                switch(x)
                {
                    case 1:
                        Console.WriteLine("============{ Add In Stack }============");
                        Node node = new Node();
                        Console.Write("Enter The Number : ");
                        int num = int.Parse(Console.ReadLine());   
                        node.Data = num;
                        stack.Push(node);
                        Console.WriteLine("=========================================");
                        break;
                    case 2:
                        Console.WriteLine("==========={ Remove In Stack }===========");
                        Console.WriteLine($"The Number Has Deleted {stack.Top.Data}");
                        stack.Pop();    
                        Console.WriteLine("=========================================");
                        break;
                        case 3:
                        Console.WriteLine("==========={ Print Data Stack }==========");
                        stack.Print();
                        Console.WriteLine("=========================================");
                        break;
                }
            } while(x < 4);
        }
    }
}
