using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            #region UC2 peek and pop till empty
            Console.WriteLine("-----UC2-----");
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Printstack();
            stack.Peek();
            stack.Pop();
            stack.EmptyStack();
            #endregion
            Console.WriteLine("\n----------------------------------------------------");
        }
    }
}
