using System;
using System.Collections.Generic;

namespace NullableType
{
    class Program
    {
        static void Main(string[] args)
        {

              int? nullable = 5;
              object boxed = nullable;
             Console.WriteLine(boxed.GetType());
             
             Console.WriteLine(nullable.GetHashCode());
  
             Console.WriteLine(nullable.GetValueOrDefault(10));
  
              int normal = (int)boxed;
              Console.WriteLine(normal);
  
              nullable = (int?) boxed;
              
              Console.WriteLine(nullable);
  
              nullable = new int?();
  
              boxed = nullable;
              Console.WriteLine(boxed == null);
  
              nullable = (int?) boxed;
              
              Console.WriteLine(nullable.HasValue);

                var person = new Person(name: "test",
                    birth: new DateTime(1912, 6, 23),
                    death: new DateTime(1954, 6, 7));
                
                var person1 = new Person(name: "test 1",
                    birth: new DateTime(1938, 1, 10),
                    death: null);
            
                // Helper class for providing partial comparer
               int? cmp = PartialComparer.Compare(1, 0);
               Console.WriteLine(cmp);
               var first = new List<int>(){1, 2, 3};
               var second = new List<int>(){1,2,3};
               cmp = PartialComparer.ReferenceCompare(first, second);
               Console.WriteLine(cmp);
        }

    }
}