using System;
using System.Collections.Generic;

namespace GenericIterator
{
    class program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9,10};
            CountingEnumerable counter = new CountingEnumerable(numbers);
            foreach (var x in counter )
            {
                Console.WriteLine(x);
            }
        }
    }
}