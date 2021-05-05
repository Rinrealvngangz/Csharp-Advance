using System;
using System.Collections;

namespace HashTableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();
            hash.Add('A', 1);
            hash.Add('B', 2);
            hash.Add('C', 3);
            hash.Add('D', 4);

            if (hash.ContainsKey('A'))
            {
                Console.WriteLine(hash['A']);
            }
            Console.ReadKey();
        }
    }
}
