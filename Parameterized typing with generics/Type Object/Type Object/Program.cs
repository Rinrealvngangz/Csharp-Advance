using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace TypeObject
{
    class Program
    {
        static void PrintTypeParameter<T>()
        {
            Console.WriteLine(typeof(T));
        }
        static void Main(string[] args)
        {
            string listTypeName = "System.Collections.Generic.List`1";
            Type defByName = Type.GetType(listTypeName);
            Type closedByName = Type.GetType(listTypeName + "[System.String]");
            Type closedByMethod = defByName.MakeGenericType(typeof(string));
            Type closedByTypeof = typeof(List<string>);
            
            Console.WriteLine(closedByMethod == closedByName);
            Console.WriteLine(closedByName == closedByTypeof);
   
            Type defByTypeof = typeof(List<>);
            Type defByMethod = closedByName.GetGenericTypeDefinition();
            
            Console.WriteLine(defByMethod == defByName);
            Console.WriteLine(defByName == defByMethod);
           object dynamic =   Activator.CreateInstance(closedByMethod);
        
           Console.WriteLine(closedByMethod.FullName);
           var objDynamic = dynamic as List<string>;
           objDynamic.Add("a");
           objDynamic.Add("b");
           Console.WriteLine(objDynamic[0]);

        }
    }
}