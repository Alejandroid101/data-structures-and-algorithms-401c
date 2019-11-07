using System;
using System.Collections.Generic;
using System.Text;

namespace CH16_FizzBuzzTree
{
    class Traverse<T>
    {
        public Node<object> Root { get; set; }
        
        public Traverse(object value)
        {
            Root = new Node<object>(value);
        }

        public List<object> PreOrder(Node<object> node)
        {
            List<object> traversal = new List<object>();

            PreOrder(node, traversal);
            return traversal;
        }

        private void PreOrder(Node<object> node, List<object> traversal)
        {
            traversal.Add(node.Value);
            if(Convert.ToInt32(node.Value) % 15 == 0)
            {
                node.Value = "FizzBuzz";
                traversal.Add(node.Value);
            }
            else if(Convert.ToInt32(node.Value) % 3 == 0)
            {
                node.Value = "Fizz";
                traversal.Add(node.Value);
            }
            else if(Convert.ToInt32(node.Value) % 5 == 0)
            {
                node.Value = "Buzz";
                traversal.Add(node.Value);
            }

            if (node.LeftChild != null)
            {
                PreOrder(node.LeftChild, traversal);
            }
            if (node.RightChild != null)
            {
                PreOrder(node.RightChild, traversal);
            }
        }


    }
}
