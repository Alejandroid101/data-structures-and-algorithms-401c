using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkList list = new LinkList();

            Node node1 = new Node(5);
            Node node2 = new Node(10);
            Node node3 = new Node(15);
            Node node4 = new Node(20);
            Node node5 = new Node(25);

            list.Head = node1;

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;

            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            list.Append(5);
        }
    }
}
