using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkList list = new LinkList();

            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            list.Append(5);
        }
    }
}
