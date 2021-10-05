using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            #region UC1 Creat Stack
            Console.WriteLine("-----UC1-----");
            Stack_UC1_UC2 stack = new Stack_UC1_UC2();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Printstack();
            #endregion
            Console.WriteLine("\n----------------------------------------------------");


        }
    }
}