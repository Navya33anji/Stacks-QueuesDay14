using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class Stack
    {
         private NodeStack top;

        public void LinkedListStack()
        {
            this.top = null;
        }

        // UC1 Push to Stack
        internal void Push(int value)
        {
            NodeStack node = new NodeStack(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed to stack ", value);
        }
    }
}
