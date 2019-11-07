using System;
using System.Collections.Generic;

namespace CH16_FizzBuzzTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Fizziness and the Buzziness!");
            Traverse();
        }

        static void Traverse()
        {
            Traverse<object> tree = new Traverse<object>(4);

            Node<object> node2 = new Node<object>(8);
            Node<object> node3 = new Node<object>(15);
            Node<object> node4 = new Node<object>(16);
            Node<object> node5 = new Node<object>(6);
            Node<object> node6 = new Node<object>(10);
            Node<object> node7 = new Node<object>(2);

            tree.Root.LeftChild = node2;
            tree.Root.RightChild = node3;
            node2.LeftChild = node4;
            node2.RightChild = node5;
            node3.LeftChild = node6;
            node3.RightChild = node7;


            List<object> preOrder = tree.PreOrder(tree.Root);
            Console.WriteLine(string.Join(',', preOrder));
            Console.WriteLine();
        }

    }
}
