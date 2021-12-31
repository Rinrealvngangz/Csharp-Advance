using System;
using System.Collections.Generic;

namespace LiminationsOfGeneric
{
    class Program
    {
        static T FindMean<T>(IEnumerable<T> data) 
        {
            //T sum = default(T);
           
            dynamic sum =0 ;
            int count = 0;
            foreach (T datum in data)
            {
                sum += datum;
                count++;
            }

            return sum / count;
        }
        static void Main(string[] args)
        {
            int rs = FindMean(new List<int>() {1, 2, 3, 4, 5});
            Console.WriteLine(rs);
        }
        
    }
}