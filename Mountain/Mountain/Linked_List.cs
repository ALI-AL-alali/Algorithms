using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mountain;

namespace Mountain
{
    class Linked_List
    {
        public Node First { get; set; }
        public Node Last { get; set; }
        int Count = 0;
        public Linked_List() { }
        public bool Empty=> Count == 0;
        public void Add_Last(Node node)
        {
            if (Empty)
            {
                First = node;
                Last = node;
                Count++;
                return;
            }
            Last.Next = node;
            Last = node;
            Count++;
        }
        public void Over_Hight()
        {

            if (First == null)
            {
                Console.WriteLine("The List is Empty.");
                return;
            }
            Node node = First;
            Mountains Max = First.Next.Data;
            for (int i = 0; i < Count; i++) 
            {
                if (node.Data.Hight > Max.Hight)
                {
                    Max = node.Data;
                }
                node = node.Next;
            }
            Console.WriteLine($"Name Mountain : {Max.Name}\n" +
                                $"Hight Mountain : {Max.Hight}\n" +
                                $"Name Contre : {Max.Countre}\n");
        }
        public int Count_Mountains(string countre)
        {
            if (First == null)
            {
                Console.WriteLine("The List is Empty.");
                return -1;
            }
            int c = 0;
            Node node = First;
            for (int i = 0; i < Count; i++)
            {
                if(node.Data.Countre == countre)
                {
                    c++;
                }
                node = node.Next;
            }
            return c;
        }
    }
}
