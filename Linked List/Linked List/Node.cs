using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    internal class Node
    {
        int data;
        Node next;
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node() { }
        public Node(int data)
        {
            this.Data = data;
        }
        public Node(int data, Node next)
        {
            this.Data = data;
            this.Next = next;
        }

    }
}
