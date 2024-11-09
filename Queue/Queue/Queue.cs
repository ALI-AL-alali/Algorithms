using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Queue
    {
        int Count = 0;  
        public Node First { get; set; }
        public Node Last { get; set; }
        public Queue() { }
        public Queue(Node first)
        {
            First = first;
        }
        public Queue(Node first, Node last)
        {
            First = first;
            Last = last;
        }
        public void EnQueue(Node node)
        {
            if(First == null)
            {
                First = node;
                Last = node;
            }
            Last.Next = node;
            Last = node;
            Count++;
        }
        public void DeQueue()
        {
            if(First == null)
            {
                Console.WriteLine("Queue Is Empty");
                return;
            }
            First = First.Next;
            Count--;
        }
        public void Print()
        {
            Node node = First;
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(node.Data + "\t");
                node = node.Next;
            }
        }
    }
}
