﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeCh15
{
    class Tree<T>
    {
        public Node<T> Root { get; set; }

        public Tree(T value)
        {
            Root = new Node<T>(value);
        }

        //preorder

        public List<T> PreOrder(Node<T> node)
        {
            List<T> traversal = new List<T>();

            PreOrder(node, traversal);
            return traversal;
        }

        private void PreOrder(Node<T> node, List<T> traversal)
        {
            traversal.Add(node.Value);

            if (node.LeftChild != null)
            {
                PreOrder(node.LeftChild, traversal);
            }
            if (node.RightChild != null)
            {
                PreOrder(node.RightChild, traversal);
            }
        }

        //inorder 

        public List<T> InOrder(Node<T> node)
        {
            List<T> traversal = new List<T>();

            InOrder(node, traversal);
            return traversal;
        }

        public void InOrder(Node<T> node, List<T> traversal)
        {

            if (node.LeftChild != null)
            {
                InOrder(node.LeftChild, traversal);
            }
            traversal.Add(node.Value);
            if (node.RightChild != null)
            {
                InOrder(node.RightChild, traversal);
            }
        }

        //postorder

        public List<T> PostOrder(Node<T> node)
        {
            List<T> traversal = new List<T>();

            PostOrder(node, traversal);
            return traversal;
        }

        public void PostOrder(Node<T> node, List<T> traversal)
        {

            if (node.LeftChild != null)
            {
                PostOrder(node.LeftChild, traversal);
            }
            if (node.RightChild != null)
            {
                PostOrder(node.RightChild, traversal);
            }
            traversal.Add(node.Value);
        }

        public List<T> BreadthFirst(Node<T> node)
        {
            Queue<Node<T>> breadth = new Queue<Node<T>>();
            List<T> values = new List<T>();

            breadth.Enqueue(node);

            while (breadth.TryPeek(out node))
            {
                Node<T> front = breadth.Dequeue();
                values.Add(front.Value);

                if(front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }

                if(front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
            return values;
        }
    }
}
