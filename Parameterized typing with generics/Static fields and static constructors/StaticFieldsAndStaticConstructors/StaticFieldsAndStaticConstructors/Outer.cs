using System;

namespace StaticFieldsAndStaticConstructor
{
    public class Outer<T>
    {
    
        public class Inner<U,V> 
        {
            static Inner()
            {
                Console.WriteLine("Outer<{0}>.Inner<{1},{2}>",
                                   typeof(T).Name,
                                   typeof(U).Name,
                                   typeof(V).Name);
            }
            
            public  static  void DummyMethod(){}
        }
            static Outer()
                {
                    Console.WriteLine("abc");
                }
         public  static void Test(){}
    }
}