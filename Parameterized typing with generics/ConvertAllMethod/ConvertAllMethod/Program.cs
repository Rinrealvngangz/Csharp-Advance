using System;
using System.Collections.Generic;

namespace ConvertAllMethod
{
    class Program 
    {
        static double TakeSquareRoot(int x)
        {
            return Math.Sqrt(x);
        }

        static int CompareToDefault<T>(T value) where T : IComparable<T>
        {
            
            return value.CompareTo(default(T));
        }

        static bool AreReferencesEqual<T>(T first, T second)
            where T : class
        {
            return first == second;
        }
        
        
        
        static void Main(string[] args)
        {
            // ConverAll method
            
           /* List<int> intergers = new List<int>();
            intergers.Add(1);
            intergers.Add((2));
            intergers.Add(3);
            intergers.Add(4);
            Converter<int, double> converter = TakeSquareRoot;
            List<double> doubles;
           doubles =  intergers.ConvertAll<double>(converter);
           foreach (var d in doubles)
           {
               Console.WriteLine(d);
           }*/
           
           
       
        // Comparing a given value to the default in a generic way
        
        /*   Console.WriteLine(CompareToDefault("x"));
           
           Console.WriteLine(CompareToDefault(10));
           
           Console.WriteLine(CompareToDefault(0));
           
           Console.WriteLine(CompareToDefault(-10));
           
           Console.WriteLine(CompareToDefault(DateTime.MinValue));*/
           
      
       /* string name = "jon";
        string intro1 = "My name is " + name;
        string intro2 = "My name is " + name;
       Console.WriteLine(intro1 == intro2);
       Console.WriteLine(AreReferencesEqual(intro1,intro2));*/

       // Generic class representing a pair of values
       Pair<int, string> pair = new Pair<int, string>(10, "value");

       pair.Equals(new Pair<int, string>(10, "value"));
       
       pair.GetHashCode();

        }
    }
}