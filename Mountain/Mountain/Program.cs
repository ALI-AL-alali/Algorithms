using System;
using Mountain;

Console.WriteLine("<<<  HELLO  >>>");
Node node = new Node();
Linked_List linked_List = new Linked_List();
int x;
do
{
    Console.Write("Enter The Number : \n" +
    "1.Add Data Mountain\n" +
    "2.Data Over Hight Mountain\n" +
    "3.Number Of Mountain in The Countre Do You Want\n" +
    "4.EXIT\n" +
    "==> ");
    x = int.Parse(Console.ReadLine());
    switch (x)
    {
        case 1:
            Console.WriteLine("=============={ Add Data Mountain }==============");
            Console.Write("Enter The Name Mountain : ");
            string name = Console.ReadLine();
            Console.Write("Enter The Hight : ");
            double hight = double.Parse(Console.ReadLine());
            Console.Write("Enter The Name Countre : ");
            string countre = Console.ReadLine();
            Mountains mountain = new Mountains();
            mountain.Name = name;
            mountain.Hight = hight;
            mountain.Countre = countre;
            node.Data = mountain;
            linked_List.Add_Last(node);
            Console.WriteLine("=================================================");
            break;
        case 2:
            Console.WriteLine("============={ Over Hight Mountain }=============");
            linked_List.Over_Hight();
            Console.WriteLine("==================================================");
            break;
        case 3:
            Console.WriteLine("========{ Number Of Mountain in Countre  }========");
            Console.Write("Enter The Name Contre : ");
            string c = Console.ReadLine();
            Console.WriteLine($"Number of Mountain in {c} : " + linked_List.Count_Mountains(c));
            Console.WriteLine("==================================================");
            break;
    }
} while (x < 4);
