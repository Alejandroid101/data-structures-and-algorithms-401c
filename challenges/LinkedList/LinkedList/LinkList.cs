using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkList
    {
        public Node Head { get; set; }

        public LinkList()
        {
            Head = null;
        }

        public void Append(int value)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }


        public void insertBefore(int value, int newVal)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {

                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                    try
                    {
                        if (current.Next.Data == newVal)
                        {
                            current.Next = newNode;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                current.Next = newNode;
            }
        }


        public void insertAfter(int value, int newVal)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                    try
                    {
                        if (current.Data == newVal)
                        {
                            current.Next = newNode;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                current.Next = newNode;
            }
        }
        //CodeChallenge 5
        public void Insert(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = Head;
            Head = newNode;
        }

        public bool Includes(int value)
        {
            Node currentNode = Head;
            while (currentNode != null)
            {
                if(currentNode.Data == value)
                {
                return  true;
                }
                currentNode = currentNode.Next;
            }
            return false;
        }

        public string ToString(int value)
        {
            Node currentNode = Head;
            string allValues = "";
            while(currentNode.Next != null)
            {
                allValues += $"{currentNode.Data}, ";
                currentNode = currentNode.Next;
            }
            allValues += currentNode.Data;
            return allValues;

        }

        public int SelectFromEnd(int k)
        {
            Node newNode = new Node(k);
            int val = 0;
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                int posK = 0;
                int counter = 0;
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                    counter++;
                }
                while (current.Next != null)
                {
                    if (counter == posK)
                    {
                        Console.WriteLine($"value of k found: {current.Data}");
                        return current.Data;
                    }
                    current = current.Next;
                    counter++;
                    val = current.Data;
                }
            }
            return val;
        }

    }
}
