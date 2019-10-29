using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks
{
    public class PseudoQueue
    {
            Stack stack1 = new Stack();

            Stack stack2 = new Stack();

        public void Enqueue(int value)
        {
            while( stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
            stack1.Push(value);
        }

        public int Dequeue()
        {
            int value = (int)stack1.Pop();
            return value;
        }
    }
}
