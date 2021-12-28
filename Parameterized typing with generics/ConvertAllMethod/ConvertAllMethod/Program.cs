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
        
        static void Main(string[] args)
        {
            List<int> intergers = new List<int>();
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
           }
        }
    }
}