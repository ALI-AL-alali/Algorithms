using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Stack
    {
        int Count = 0;
        public Node Top { get; set; }
        public Stack() { }
        public Stack(Node top)
        {
            Top = top;
        }
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
            Count++;
        }
        public void Pop()
        {
            if (Top == null)
            {
                Console.WriteLine("Stack Is Empty");
                return;
            }
            Top = Top.Next;
            Count--;
        }
        public void Print()
        {
            Node node = Top;
            for(int i = 0; i < Count; i++)
            {
                Console.WriteLine(node.Data + "\t");
                node = node.Next;
            }
        }
    }
}
