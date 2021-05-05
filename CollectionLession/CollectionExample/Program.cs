using System;
using System.Collections;
using System.Collections.Generic;


namespace CollectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(23);
           // arrayList.Add("hello");
            arrayList.Add(213);
            arrayList.Add(3);
            arrayList.Sort();
         
            foreach( var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.RemoveAt(1);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.ForEach(n => Console.WriteLine(n));
            arrayList.AddRange(list);
            Console.WriteLine(arrayList.Count);
            Console.ReadKey();

        }
    }
}
