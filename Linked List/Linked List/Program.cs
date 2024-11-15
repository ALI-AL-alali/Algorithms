using System;
using System.Collections.Generic;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Linked_List list = new Linked_List();

            // إضافة عناصر إلى القائمة
            Console.WriteLine("Add Node to beginning of list:");
            list.AddFirst(10);
            list.AddFirst(40);
            list.AddFirst(30);
            list.AddFirst(50);
            Node node = new Node(55);
            list.AddFirst(node);
            list.Print();

            // طباعة بشكل عكسي 
            Console.WriteLine("\nPrint the list in reverse:");
            list.PrintReverse(node);
            Console.WriteLine();

            // إضافة عناصر في النهاية
            Console.WriteLine("\nAdd Node to the end of the list:");
            list.AddLast(20);
            list.AddLast(60);
            list.Print();

            // إدراج عنصر في موقع محدد
            Console.WriteLine("\nAdd Node at specific location (add 25 at location 2):");
            list.AddByIndex(25, 2);
            list.Print();

            // فرز اللائحة 
            Console.WriteLine("\nSorting the list:");
            list.Sorting();
            list.Print();

            // إدراج عنصر في موقع صحيح
            Console.WriteLine("\nAdd a node(35) in the right place: ");
            list.AddByData(35);
            list.Print();

            // بحث عن عنصر معين    
            Console.WriteLine("\nSearch for Node (25):");
            int index = list.Serach(25);
            if (index != -1)
                Console.WriteLine("Node 25 is at location: " + index);
            else
                Console.WriteLine("Node 25 is not in the list.");

            // بحث عن عنصر معين    
            Console.WriteLine("\nSearch for Node (11):");
            int i = list.Serach(11);
            if (i != -1)
                Console.WriteLine("Node 11 is at location: " + index);
            else
                Console.WriteLine("Node 11 is not in the list.");

            // حذف العنصر الأول
            Console.WriteLine("\nDelete first Node:");
            list.DeleteFirst();
            list.Print();

            // حذف العنصر الأخير
            Console.WriteLine("\nDelete last Node:");
            list.DeleteLast();
            list.Print();

            // حذف العنصر حسب الموقع
            Console.WriteLine("\nDelete Node at specific location (delete Node at location 2):");
            list.DeleteByIndex(2);
            list.Print();

            // حذف عنصر حسب البيانات
            Console.WriteLine("Delete node(25) according to the data:");
            list.DeleteByData(25);
            list.Print();

            // افراغ اللائحة 
            Console.WriteLine("\nClear entire list:");
            list.Clear();
            list.Print();
        }
    }
}
