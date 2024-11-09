using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using Mountain;


class Node
{
    Mountains data;
    Node next;
    public Mountains Data { get; set; }
    public Node Next { get; set; }
    public Node() { }
    public Node(Mountains data)
    {
        this.Data = data;
    }
    public Node(Mountains data, Node next)
    {
        this.Data = data;
        this.Next = next;
    }

}

