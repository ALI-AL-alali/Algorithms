using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linked_List
{
    class Linked_List
    {
        Node first;
        int count = 0;
        public Node First { get; set; }
        public int Count { get; set; }
        public Linked_List() { }
        public Linked_List(Node first)
        {
            this.first = first;
        }
        public void AddFirst(int Data)
        {
            Node node = new Node(Data);
            node.Next = first;
            first = node;
            count++;
        }
        public void AddFirst(Node Data)
        {
            Data.Next = first;
            first = Data;
            count++;
        }
        public void AddLast(int Data)
        {
            if (first == null)
            {
                AddFirst(Data);
                return;
            }
            Node move = first;
            while (move.Next != null)
                move = move.Next;
            Node node = new Node(Data);
            move.Next = node;
            count++;
        }
        public void AddLast(Node Data)
        {
            if (first == null)
            {
                AddFirst(Data);
                return;
            }
            Node move = first;
            while (move.Next != null)
                move = move.Next;
            move.Next = Data;
            count++;
        }
        public void InsertIn(int Data, int loc)
        {
            Node node = new Node(Data);
            if (loc > count || loc < 0)
            {
                Console.WriteLine("Can't Insert!!");
                return;
            }
            if (loc == 0)
            {
                AddFirst(Data);
                return;
            }
            if (loc == count)
            {
                AddLast(Data);
                return;
            }
            Node move = first;
            for (int i = 0; i < loc - 1; i++)
            {
                move = move.Next;
            }
            node.Next = move.Next;
            move.Next = node;
            count++;
        }
        public bool IsEmpty() { return first == null; }
        public void DeleteFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty Linked List!!");
                return;
            }
            first = first.Next;
            count--;
        }
        public void DeleteLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty Linked List!!");
                return;
            }
            if (first.Next == null)
            {
                first = null;
                count--;
                return;
            }
            Node del = first;
            while (del.Next.Next != null)
            {
                del = del.Next;
            }
            del.Next = null;
            count--;
        }
        public void DeleteByData(int data)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty Linked List!!");
                return;
            }
            if (first.Data == data)
            {
                DeleteFirst();
                return;
            }
            Node prve = first;
            Node curr = first.Next;
            while (curr != null && curr.Data != data)
            {
                prve = curr; //prve = prve.Next;
                curr = curr.Next; // curr = prve.Next.Next;
            }
            if (curr == null)
            {
                Console.WriteLine("Data not found in the list!!");
                return;
            }
            prve.Next = curr.Next; //prve = prve.Next.Next;
            curr.Next = null;
            count--;
        }

        public void Print()
        {
            Node temp = first;
            while (temp != null)
            {
                Console.Write("  =>  " + temp.Data);
                temp = temp.Next;
            }
            Console.WriteLine();
        }
    }

}
