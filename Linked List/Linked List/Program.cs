using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Linked_List linkedList = new Linked_List();
            // إضافة عناصر في البداية
            linkedList.AddFirst(10);
            linkedList.AddFirst(20);
            linkedList.AddFirst(30);

            Console.WriteLine("The linked list after adding elements from the beginning :");
            linkedList.Print();

            // إضافة عناصر في النهاية
            linkedList.AddLast(40);
            linkedList.AddLast(50);

            Console.WriteLine("The linked list after adding elements from the end :");
            linkedList.Print();

            // إدراج عنصر في موقع محدد
            linkedList.InsertIn(25, 2);

            Console.WriteLine("Linked list after adding an element at a specific location :");
            linkedList.Print();

            // حذف العنصر الأول
            linkedList.DeleteFirst();

            Console.WriteLine("Linked list after deleting an element from the beginning :");
            linkedList.Print();

            // حذف العنصر الأخير
            linkedList.DeleteLast();

            Console.WriteLine("Linked list after deleting an element from the end :");
            linkedList.Print();

            // حذف عنصر حسب البيانات
            linkedList.DeleteByData(25);

            Console.WriteLine("Linked list after deleting an item from a specific location :");
            linkedList.Print();
        }
    }
}
