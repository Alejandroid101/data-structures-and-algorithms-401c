﻿using System;
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
            if(Head == null)
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
                    catch(Exception e)
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

    }
}