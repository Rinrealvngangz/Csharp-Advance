using System;
using System.Collections;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            stack.Push("D");
            
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("After remove"+ '\n');

            stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
