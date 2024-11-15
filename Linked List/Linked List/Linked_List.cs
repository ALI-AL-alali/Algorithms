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
            if (IsEmpty())
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
            if (IsEmpty())
            {
                AddFirst(Data);
                return;
            }
            Node temp = first;
            while (temp.Next != null)
                temp = temp.Next;
            temp.Next = Data;
            count++;
        }
        public void AddByIndex(int Data, int loc)
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
        public void AddByData(int data)
        {
            if (IsEmpty())
            {
                AddFirst(data);
                return;
            }
            Node move = new Node(data);
            Node temp = first;
            while (temp.Next != null && temp.Next.Data < data)
            {
                temp = temp.Next;
            }
            move.Next = temp.Next;
            temp.Next = move;
            count++;
        }
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
        public void DeleteByIndex(int index)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty Linked List!!");
                return;
            }
            if (index < 0 || index >= count)
            {
                Console.WriteLine("Index is longer than list length!!");
                return;
            }
            if (index == 0)
            {
                DeleteFirst();
                return;
            }
            Node temp = first;
            for (int i = 0; i < index - 1; i++)
            {
                temp = temp.Next;
            }
            temp.Next = temp.Next.Next;
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
        public int Serach(int data)
        {
            if (IsEmpty())
            {
                return -1;
            }
            Node temp = first;
            int index = 0;
            while (temp != null)
            {
                if (temp.Data == data)
                {
                    return index;
                }
                temp = temp.Next;
                index++;
            }
            return -1;
        }
        public void Sorting()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty Linked List!!");
                return;
            }
            for(Node x = first; x != null; x = x.Next)
            {
                for(Node y = x; y != null; y = y.Next)
                {
                    if(x.Data > y.Data)
                    {
                        int temp = x.Data;
                        x.Data = y.Data;
                        y.Data = temp;
                    }
                }
            }
        }
        public bool IsEmpty()
        {
            return first == null; 
        }
        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty Linked List!!");
                return;
            }
            Node temp = first;
            while (temp != null)
            {
                Console.Write($"=>  {temp.Data}  ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
        public void PrintReverse(Node temp)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty Linked List!!");
                return;
            }
            if(temp == null)
            {
                return;
            }
                PrintReverse(temp.Next);
                Console.Write($"  {temp.Data}  <=");
        }
        public void Clear()
        {
            first = null;
            count = 0;
        }
    }
}
